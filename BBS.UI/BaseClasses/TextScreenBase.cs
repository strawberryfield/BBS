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

        public void ReadText(string name)
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
        public override void Show()
        {
            currentLine = ShowScreenLines(0);
        }

        protected int ShowScreenLines(int start)
        {
            Write(ANSI.ClearScreen());
            ShowLines(Header, 0, Header.Count);
            Write(ANSI.Move(0, dataAreaStart + dataAreaSize));
            ShowLines(Footer, 0, Footer.Count);
            Write(ANSI.SaveCursorPosition);
            Write(ANSI.Move(0, dataAreaStart));
            int ret = ShowLines(start, dataAreaSize);
            Write(ANSI.RestoreCursorPosition);
            return ret;
        }

        public override void HandleMessage(string msg)
        {
            if (!string.IsNullOrWhiteSpace(msg) && msg.Substring(0, 1).ToUpper() == "B")
            {
                if (Text.Count > dataAreaSize && currentLine > dataAreaSize)
                {
                    int newStart = (currentLine - 1) / dataAreaSize - 1;
                    newStart = newStart < 0 ? 0 : newStart * dataAreaSize;
                    Writeln();
                    currentLine = ShowScreenLines(newStart);
                }
            }

            if (string.IsNullOrWhiteSpace(msg))
            {
                if (Text.Count > dataAreaSize && currentLine < Text.Count)
                {
                    Writeln();
                    currentLine = ShowScreenLines(currentLine + 1);
                }
                else
                    ShowNext();
            }

            if (Data != null && Data.Actions.Count > 0) execAction(msg.Trim().ToUpper());
        }

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

        public override void ShowNext()
        {
            execAction(string.Empty);
            if(Previous != null)
            {
                client.screen = Previous;
                client.screen.Show();
            }
        }

        public override void HandleChar(char ch)
        {
            if(ch == 0x03)
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
        }

        protected int ShowLines(List<string> lines, int start, int len)
        {
            int ret = start;
            bool isFirst = true;
            for (; ret < start + len && ret < lines.Count; ++ret)
            {
                if (!isFirst) Writeln();
                else isFirst = false;
                Write(lines[ret]);
            }
            return ret;
        }

        protected int ShowLines(int start, int len) => ShowLines(Text, start, len);

    }
}
