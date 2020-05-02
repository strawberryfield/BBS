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
        protected BBSCodeResult Data;
        protected string[] Params;

        public TextScreenBase(IClient c, IServer s) : base(c, s) { }
        public TextScreenBase(IClient c, IServer s, IScreen prev) : base(c, s, prev) { }
        public TextScreenBase(IClient c, IServer s, string txt) : this(c, s, txt, null) { }
        public TextScreenBase(IClient c, IServer s, string txt, IScreen prev) : this(c, s, prev)
        {
            Text = new List<string>();

            if (!string.IsNullOrWhiteSpace(txt))
            { 
                Params = txt.Split(';');
                if (!string.IsNullOrWhiteSpace(Params[0]))
                    ReadText(Params[0]);                    
            }
        }

        public void ReadText(string name)
        {
            BBSCodeTranslator translator = new BBSCodeTranslator(client, server);
            Data = translator.GetProcessed(name);
            Text = Data.GetRows();
        }

        protected int currentLine;
        public override void Show()
        {
            currentLine = ShowLines(0, client.screenHeight-2);
        }

        public override void HandleMessage(string msg)
        {
            if (!string.IsNullOrWhiteSpace(msg) && msg.Substring(0, 1).ToUpper() == "B")
            {
                if (Text.Count > (client.screenHeight - 1) && currentLine > (client.screenHeight - 2))
                {
                    int newStart = currentLine - (client.screenHeight - 1) * 2;
                    newStart = newStart < 0 ? 0 : newStart;
                    Writeln();
                    currentLine = ShowLines(newStart, client.screenHeight - 1);
                }
            }

            if (string.IsNullOrWhiteSpace(msg))
            {
                if (Text.Count > (client.screenHeight - 1) && currentLine < Text.Count - 1)
                {
                    Writeln();
                    currentLine = ShowLines(currentLine, (client.screenHeight - 1));
                }
                else
                    ShowNext();
            }

            if (Data != null && Data.Actions.Count > 0) execAction(msg.Trim().ToUpper());
        }

        private void execAction(string act)
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
