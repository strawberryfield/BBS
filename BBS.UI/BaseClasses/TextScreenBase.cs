// copyright (c) 2020 Roberto Ceccarelli - CasaSoft
// http://strawberryfield.altervista.org 
// 
// This file is part of CasaSoft BBS
// 
// CasaSoft BBS is free software: 
// you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// CasaSoft BBS is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  
// See the GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with CasaSoft BBS.  
// If not, see <http://www.gnu.org/licenses/>.

using Casasoft.BBS.Interfaces;
using Casasoft.BBS.Parser;
using Casasoft.TextHelpers;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;

namespace Casasoft.BBS.UI
{
    /// <summary>
    /// Implements a text based screen
    /// </summary>
    public class TextScreenBase : ScreenBase
    {
        #region properties
        /// <summary>
        /// Lines of text body
        /// </summary>
        protected List<string> Text;

        /// <summary>
        /// Lines of text header
        /// </summary>
        protected List<string> Header;

        /// <summary>
        /// Lines of text Footer
        /// </summary>
        protected List<string> Footer;

        /// <summary>
        /// Result of text parsing
        /// </summary>
        protected BBSCodeResult Data;

        /// <summary>
        /// List of supplied arguments
        /// </summary>
        protected string[] Params;
        #endregion

        /// <summary>
        /// Avaliable screen sections
        /// </summary>
        public enum Sections { Header, Body, Footer }

        #region constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public TextScreenBase(IBBSClient c, IServer s) : base(c, s) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public TextScreenBase(IBBSClient c, IServer s, IScreen prev) : base(c, s, prev) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        public TextScreenBase(IBBSClient c, IServer s, string txt) : this(c, s, txt, null) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public TextScreenBase(IBBSClient c, IServer s, string txt, IScreen prev) : this(c, s, prev)
        {
            Text = new List<string>();
            Header = new List<string>();
            Footer = new List<string>();

            _moduleParam = txt;
            if (!string.IsNullOrWhiteSpace(txt))
            {
                Params = txt.Split(';');
                if (!string.IsNullOrWhiteSpace(Params[0]))
                    ReadText(Params[0]);

                dataAreaStart = Header.Count + 1;
                dataAreaSize = client.screenHeight - Header.Count - Footer.Count;
            }
        }
        #endregion

        #region show
        /// <summary>
        /// Rows available for text body
        /// </summary>
        protected int dataAreaSize;

        /// <summary>
        /// First row for text body
        /// </summary>
        protected int dataAreaStart;

        /// <summary>
        /// Focused row background color
        /// </summary>
        protected ANSICodes.Colors FocusedBackground;

        /// <summary>
        /// Reads the text and stores it in lists of lines
        /// </summary>
        /// <param name="name">File to load</param>
        protected virtual void ReadText(string name)
        {
            BBSCodeTranslator translator = new BBSCodeTranslator(client, server);
            Data = translator.GetProcessed(GetFile(name));
            if (!Data.HasBodyFocusedBackground)
            {
                NameValueCollection appearance = (NameValueCollection)ConfigurationManager.GetSection("Appearance");
                FocusedBackground = ANSI.GetColorByName(appearance["FocusedColor"], true);
            }
            else
                FocusedBackground = Data.BodyFocusedBackground;

            Text = Data.GetRows();
            Header = Data.GetHeaderRows();
            Footer = Data.GetFooterRows();
        }

        /// <summary>
        /// Current line of text body
        /// </summary>
        protected int currentLine;

        /// <summary>
        /// First line of text body shown
        /// </summary>
        protected int firstDisplayedLine;

        /// <summary>
        /// current active screen line
        /// </summary>
        protected int currentScreenLine => currentLine - firstDisplayedLine + dataAreaStart;

        /// <summary>
        /// Displays the text
        /// </summary>
        public override void Show()
        {
            firstDisplayedLine = 0;
            Redraw();
            currentLine = firstDisplayedLine;
        }

        /// <summary>
        /// Redraws the screen
        /// </summary>
        /// <returns></returns>
        protected virtual int Redraw()
        {
            Write(ANSI.ClearScreen());
            ShowLines(Header, 0, Header.Count, 1);
            ShowLines(Footer, 0, Footer.Count, dataAreaStart + dataAreaSize);
            Write(ANSI.SaveCursorPosition);
            if (Data.HasBodyAlternateBackground) ClearBody();
            int ret = ShowLines();
            Write(ANSI.RestoreCursorPosition);
            return ret;
        }

        private int ShowScreenLines(int start)
        {
            ClearBody();
            int ret = ShowLines(start);
            Write(ANSI.RestoreCursorPosition);
            return ret;
        }
        private int ShowScreenLines() => ShowScreenLines(firstDisplayedLine);
        #endregion

        #region show lines
        /// <summary>
        /// Draws lines of text
        /// </summary>
        /// <param name="lines">Section to draw</param>
        /// <param name="start">first line of text to draw</param>
        /// <param name="len">number of text lines to draw</param>
        /// <param name="offset">first line of screen to use</param>
        /// <param name="isBody">true is a drawing body request</param>
        /// <returns>last line of text written</returns>
        protected int ShowLines(List<string> lines, int start, int len, int offset, bool isBody = false)
        {
            int ret = start;
            for (; ret < start + len && ret < lines.Count; ++ret)
            {
                int line = ret + offset - start;
                MoveTo(line, 1);
                if (isBody && Data.HasBodyAlternateBackground)
                    setColorLine(line);
                Write(lines[ret]);
            }
            return ret - 1;
        }

        /// <summary>
        /// Draws lines of the text body
        /// </summary>
        /// <param name="start">first line of text to draw</param>
        /// <param name="len">number of text lines to draw</param>
        /// <returns>last line of text written</returns>
        /// <remarks>
        /// first screen line used is <see cref="dataAreaStart"/>
        /// </remarks>
        protected int ShowLines(int start, int len) => ShowLines(Text, start, len, dataAreaStart, true);

        /// <summary>
        /// Draws lines of the text body
        /// </summary>
        /// <param name="start">first line of text to draw</param>
        /// <returns>last line of text written</returns>
        /// <remarks>
        /// first screen line used is <see cref="dataAreaStart"/>
        /// maximum number of lines written is <see cref="dataAreaSize"/>
        /// </remarks>
        protected int ShowLines(int start) => ShowLines(start, dataAreaSize);

        /// <summary>
        /// Draws lines of the text body
        /// </summary>
        /// <returns>last line of text written</returns>
        /// <remarks>
        /// first drawed line is stored in <see cref="firstDisplayedLine"/>
        /// first screen line used is <see cref="dataAreaStart"/>
        /// maximum number of lines written is <see cref="dataAreaSize"/>
        /// </remarks>
        protected int ShowLines() => ShowLines(firstDisplayedLine, dataAreaSize);

        /// <summary>
        /// Clears all lines of the text body
        /// </summary>
        protected void ClearBody()
        {
            for (int j = dataAreaStart; j < dataAreaStart + dataAreaSize; j++)
            {
                if (Data.HasBodyAlternateBackground)
                    setColorLine(j);
                ClearLine(j);
            }
        }

        /// <summary>
        /// Sets colors for body line
        /// </summary>
        /// <param name="line"></param>
        protected void setColorLine(int line)
        {
            if (line % 2 > 0) Write(ANSI.WriteBackColor(Data.BodyAlternateBackground));
            else Write(ANSI.WriteBackColor(ANSI.defaultBackColor));
        }

        /// <summary>
        /// Clears all lines of the header
        /// </summary>
        protected void ClearHeader()
        {
            for (int j = 1; j < dataAreaStart; j++)
            {
                if (Data.HasHeaderBackground)
                    Write(ANSI.WriteBackColor(Data.HeaderBackground));
                ClearLine(j);
            }
        }

        /// <summary>
        /// Clears all lines of the footer
        /// </summary>
        protected void ClearFooter()
        {
            for (int j = dataAreaStart + dataAreaSize; j <= client.screenHeight; j++)
            {
                if (Data.HasFooterBackground)
                    Write(ANSI.WriteBackColor(Data.FooterBackground));
                ClearLine(j);
            }
        }
        #endregion

        #region text move
        private void GoHome()
        {
            if (firstDisplayedLine != 0)
            {
                firstDisplayedLine = 0;
                ShowScreenLines();
            }
            currentLine = 0;
        }

        private void GoEnd()
        {
            if (Text.Count > dataAreaSize && firstDisplayedLine + dataAreaSize < Text.Count)
            {
                firstDisplayedLine = Text.Count - dataAreaSize;
                ShowScreenLines();
            }
            currentLine = Text.Count - 1;
        }

        private void PageDown()
        {
            if (Text.Count > dataAreaSize && firstDisplayedLine + dataAreaSize < Text.Count)
            {
                firstDisplayedLine += dataAreaSize - 1;
                currentLine = ShowScreenLines();
                currentLine = currentLine >= Text.Count ? currentLine - 1 : currentLine;
            }
            else currentLine = Text.Count - 1;
        }

        private void HalfPageDown()
        {
            if (Text.Count > dataAreaSize && firstDisplayedLine + dataAreaSize < Text.Count)
            {
                firstDisplayedLine += dataAreaSize / 2;
                currentLine = ShowScreenLines();
                currentLine = currentLine >= Text.Count ? currentLine - 1 : currentLine;
            }
            else currentLine = Text.Count - 1;
        }

        private void PageUp()
        {
            if (Text.Count > dataAreaSize && firstDisplayedLine > 0)
            {
                firstDisplayedLine -= (dataAreaSize - 1);
                firstDisplayedLine = firstDisplayedLine < 0 ? 0 : firstDisplayedLine;
                ShowScreenLines();
                currentLine = firstDisplayedLine;
            }
            else currentLine = 0;
        }

        private void HalfPageUp()
        {
            if (Text.Count > dataAreaSize && firstDisplayedLine > 0)
            {
                firstDisplayedLine -= (dataAreaSize / 2);
                firstDisplayedLine = firstDisplayedLine < 0 ? 0 : firstDisplayedLine;
                ShowScreenLines();
                currentLine = firstDisplayedLine;
            }
            else currentLine = 0;
        }

        private void CursorDown()
        {
            if (currentLine < firstDisplayedLine + dataAreaSize - 1 && currentLine < Text.Count - 1) currentLine++;
            else if (currentLine < Text.Count - 1)
            {
                HalfPageDown();
                currentLine = firstDisplayedLine;
            }
        }

        private void CursorUp()
        {
            if (currentLine > firstDisplayedLine) currentLine--;
            else if (currentLine > 0)
            {
                HalfPageUp();
                currentLine = firstDisplayedLine + dataAreaSize - 1;
            }
        }
        #endregion

        #region messages and control chars handling
        /// <summary>
        /// Processes message received from the client
        /// </summary>
        /// <param name="msg"></param>
        public override void HandleMessage(string msg)
        {
            if (string.IsNullOrWhiteSpace(msg))
            {
                if (Text.Count > dataAreaSize && firstDisplayedLine + dataAreaSize < Text.Count)
                    PageDown();
                else
                    ShowNext();
            }

            if (Data != null && Data.Actions.Count > 0) execAction(msg.Trim().ToUpper());
        }

        /// <summary>
        /// Processes special chars sequences received from the terminal
        /// </summary>
        /// <param name="data">Buffer with data received</param>
        /// <param name="bytesReceived">Number of bytes in the buffer</param>
        public override void HandleChar(byte[] data, int bytesReceived)
        {
            base.HandleChar(data, bytesReceived);
            switch (data[0])
            {
                case 'N' - 64:   // Ctrl-N
                    HandleCursorDown();
                    break;
                case 'P' - 64:   // Ctrl-P
                    HandleCursorUp();
                    break;
                case 'F' - 64:   // Ctrl-F
                    HandlePageDown();
                    break;
                case 'B' - 64:   // Ctrl-B
                    HandlePageUp();
                    break;
                case 'D' - 64:   // Ctrl-D
                    HandleHalfPageDown();
                    break;
                case 'U' - 64:   // Ctrl-U
                    HandleHalfPageUp();
                    break;
                case 'R' - 64:   // Ctrl-R
                case 'L' - 64:   // Ctrl-L
                    HandleRedraw();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Implements Half-Page-Down Handler
        /// </summary>
        protected virtual void HandleHalfPageDown() => HalfPageDown();

        /// <summary>
        /// Implements Half-Page-Up Handler
        /// </summary>
        protected virtual void HandleHalfPageUp() => HalfPageUp();

        /// <summary>
        /// Implements Screen Redraw Handler
        /// </summary>
        protected virtual void HandleRedraw() => Redraw();

        /// <summary>
        /// Implements Home Handler
        /// </summary>
        protected override void HandleHome() => GoHome();

        /// <summary>
        /// Implements End Handler
        /// </summary>
        protected override void HandleEnd() => GoEnd();

        /// <summary>
        /// Implements Page-Up Handler
        /// </summary>
        protected override void HandlePageUp() => PageUp();

        /// <summary>
        /// Implements Page-Down Handler
        /// </summary>
        protected override void HandlePageDown() => PageDown();

        /// <summary>
        /// Implements Cursor-Up Handler
        /// </summary>
        protected override void HandleCursorUp() => CursorUp();

        /// <summary>
        /// Implements Cursor-Down Handler
        /// </summary>
        protected override void HandleCursorDown() => CursorDown();

        /// <summary>
        /// Implements F1 Handler
        /// </summary>
        /// <remarks>
        /// Shows help screen
        /// </remarks>
        protected override void HandleF1() => ShowHelp();

        /// <summary>
        /// Exec action by name
        /// </summary>
        /// <param name="act">Text entered to trigger the action</param>
        protected void execAction(string act)
        {
            if (Data == null) return;
            BBSCodeResult.Action a;
            if (Data.Actions.TryGetValue(act, out a))
            {
                client.screen = ScreenFactory.Create(client, server, a.module, a.data, this);
                client.screen.Show();
            }
            else server.ClearLastInput(client);
        }

        /// <summary>
        /// Shows help screen
        /// </summary>
        protected virtual void ShowHelp()
        {
            client.screen = ScreenFactory.Create(client, server, "Help", this);
            client.screen.Show();
        }

        /// <summary>
        /// Implements Ctrl-C handler
        /// </summary>
        /// <remarks>
        /// Return to previous screen if exists or logout 
        /// </remarks>
        protected override void HandleControlC()
        {
            client.inputMode = EInputMode.LineMode;
            if (Previous != null)
            {
                client.screen = Previous;
                client.screen.Show();
            }
            else
            {
                client.screen = ScreenFactory.Create(client, server, "Logout");
                client.screen.Show();
            }
        }


        /// <summary>
        /// Implements ESC handler
        /// </summary>
        /// <remarks>
        /// Return to previous screen if exists or logout 
        /// </remarks>
        protected override void HandleESC() => HandleControlC();

        #endregion

        /// <summary>
        /// Launches default action
        /// </summary>
        public override void ShowNext()
        {
            execAction(string.Empty);
            if (Previous != null)
            {
                client.screen = Previous;
                client.screen.Show();
            }
        }


        /// <summary>
        /// Returns complete pathname of the file
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GetFile(string data)
        {
            string assets = ConfigurationManager.AppSettings.Get("assets");
            if (data.StartsWith('@'))
            {
                NameValueCollection texts = (NameValueCollection)ConfigurationManager.GetSection("Texts");
                data = texts[data.Substring(1)];
                if (File.Exists(Path.Combine(assets, locale, data)))
                {
                    data = Path.Combine(locale, data);
                }
            }

            if (TextHelper.IsUrl(data))
                return data;
            else
                return Path.Combine(assets, data);
        }

    }
}
