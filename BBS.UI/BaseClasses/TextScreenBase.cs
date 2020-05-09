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
using System.Collections.Generic;

namespace Casasoft.BBS.UI
{
    public class TextScreenBase : ScreenBase
    {
        protected List<string> Text;
        protected List<string> Header;
        protected List<string> Footer;
        protected BBSCodeResult Data;
        protected string[] Params;

        public TextScreenBase(IBBSClient c, IServer s) : base(c, s) { }
        public TextScreenBase(IBBSClient c, IServer s, IScreen prev) : base(c, s, prev) { }
        public TextScreenBase(IBBSClient c, IServer s, string txt) : this(c, s, txt, null) { }
        public TextScreenBase(IBBSClient c, IServer s, string txt, IScreen prev) : this(c, s, prev)
        {
            Text = new List<string>();
            Header = new List<string>();
            Footer = new List<string>();

            if (!string.IsNullOrWhiteSpace(txt))
            { 
                Params = txt.Split(';');
                if (!string.IsNullOrWhiteSpace(Params[0]))
                    ReadText(Params[0]);                    
            }
        }

        protected int dataAreaSize;
        protected int dataAreaStart;

        private void ReadText(string name)
        {
            BBSCodeTranslator translator = new BBSCodeTranslator(client, server);
            Data = translator.GetProcessed(name);
            Text = Data.GetRows();
            Header = Data.GetHeaderRows();
            Footer = Data.GetFooterRows();
            dataAreaStart = Header.Count + 1;
            dataAreaSize = client.screenHeight - Header.Count - Footer.Count;
        }

        protected int currentLine;
        protected int firstDisplayedLine;
        public override void Show()
        {
            firstDisplayedLine = 0;
            currentLine = Redraw();
        }

        protected virtual int Redraw()
        {
            Write(ANSI.ClearScreen());
            ShowLines(Header, 0, Header.Count, 1);
            ShowLines(Footer, 0, Footer.Count, dataAreaStart + dataAreaSize);
            Write(ANSI.SaveCursorPosition);
            int ret = ShowLines();
            Write(ANSI.RestoreCursorPosition);
            return ret;
        }

        protected int ShowScreenLines(int start)
        {
            ClearBody();
            int ret = ShowLines(start);
            Write(ANSI.RestoreCursorPosition);
            return ret;
        }
        protected int ShowScreenLines() => ShowScreenLines(firstDisplayedLine);

        #region text move
        protected void GoHome()
        {
            if (firstDisplayedLine == 0) currentLine = 0;
            else
            {
                firstDisplayedLine = 0;
                currentLine = ShowScreenLines();
            }
        }

        protected void GoEnd()
        {
            if (Text.Count > dataAreaSize && firstDisplayedLine+dataAreaSize < Text.Count) 
            {
                firstDisplayedLine = Text.Count - dataAreaSize;
                ShowScreenLines();
            }
            currentLine = Text.Count - 1;
        }

        protected void PageDown()
        {
            if (Text.Count > dataAreaSize && firstDisplayedLine + dataAreaSize < Text.Count)
            {
                firstDisplayedLine += dataAreaSize - 1;
                currentLine = ShowScreenLines();
            }
            else currentLine = Text.Count - 1;
        }

        protected void HalfPageDown()
        {
            if (Text.Count > dataAreaSize && firstDisplayedLine + dataAreaSize < Text.Count)
            {
                firstDisplayedLine += dataAreaSize / 2;
                currentLine = ShowScreenLines();
            }
            else currentLine = Text.Count - 1;
        }

        protected void PageUp()
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

        protected void HalfPageUp()
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
        #endregion

        #region messages and control chars handling
        public override void HandleMessage(string msg)
        {
            if (string.IsNullOrWhiteSpace(msg))
            {
                if (Text.Count > dataAreaSize && currentLine < Text.Count)
                    PageDown();
                else
                    ShowNext();
            }

            if (Data != null && Data.Actions.Count > 0) execAction(msg.Trim().ToUpper());
        }

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

        protected virtual void HandleHalfPageDown() => HalfPageDown();
        protected virtual void HandleHalfPageUp() => HalfPageUp();
        protected virtual void HandleRedraw() => Redraw();

        protected override void HandleHome() => GoHome();
        protected override void HandleEnd() => GoEnd();
        protected override void HandlePageUp() => PageUp();
        protected override void HandlePageDown() => PageDown();
        protected override void HandleF1() => ShowHelp();

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

        protected virtual void ShowHelp()
        {
            client.screen = ScreenFactory.Create(client, server, "Help", this);
            client.screen.Show();
        }
        #endregion

        public override void ShowNext()
        {
            execAction(string.Empty);
            if(Previous != null)
            {
                client.screen = Previous;
                client.screen.Show();
            }
        }

        #region special chars handling
        protected override void HandleControlC()
        {
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
        #endregion

        #region show lines
        protected int ShowLines(List<string> lines, int start, int len, int offset)
        {
            int ret = start;
            for (; ret < start + len && ret < lines.Count; ++ret)
            {
                MoveTo(ret + offset - start, 1);
                Write(lines[ret]);
            }
            return ret;
        }

        protected int ShowLines(int start, int len) => ShowLines(Text, start, len, dataAreaStart);
        protected int ShowLines(int start) => ShowLines(start, dataAreaSize);
        protected int ShowLines() => ShowLines(firstDisplayedLine, dataAreaSize);

        protected void ClearBody()
        {
            for (int j = dataAreaStart; j < dataAreaStart + dataAreaSize; j++) ClearLine(j);
        }
        #endregion
    }
}
