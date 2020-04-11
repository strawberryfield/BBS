﻿// copyright (c) 2020 Roberto Ceccarelli - CasaSoft
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
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;

namespace Casasoft.BBS.UI
{
    public class TextScreenBase : ScreenBase
    {
        protected string[] Text;
        protected BBSCodeResult Data;

        public TextScreenBase(IClient c, IServer s) : base(c, s) { }

        public TextScreenBase(IClient c, IServer s, string txt) : this(c, s)
        {
            ReadText(txt);
        }

        public void ReadText(string name)
        {
            BBSCodeTranslator translator = new BBSCodeTranslator();
            Data = translator.GetProcessed(name);
            Text = Data.GetRows();
        }

        private int currentLine;
        public override void Show()
        {
            currentLine = ShowLines(0, 24);
        }

        public override void HandleMessage(string msg)
        {
            if (!string.IsNullOrWhiteSpace(msg) && msg.Substring(0, 1).ToUpper() == "B")
            {
                if (Text.Length > 24 && currentLine > 23)
                {
                    int newStart = currentLine - 48;
                    newStart = newStart < 0 ? 0 : newStart;
                    ShowLines(newStart, 24);
                }
            }

            if (string.IsNullOrWhiteSpace(msg))
            {
                if (Text.Length > 24 && currentLine < Text.Length - 1)
                    ShowLines(currentLine, 24);
                else
                    ShowNext();
            }

            if (Data.Actions.Count > 0) execAction(msg.Trim().ToUpper());
        }

        private void execAction(string act)
        {
            BBSCodeResult.Action a = null;
            Data.Actions.TryGetValue(act, out a);
            if (a != null)
            {
                client.screen = ScreenFactory.Create(client, server, a.module, a.data);
                client.screen.Show();
            }
        }

        public override void ShowNext() => execAction(string.Empty);

        protected int ShowLines(int start, int len)
        {
            int ret = start;
            for (; ret < start + len && ret < Text.Length; ++ret)
            {
                server.sendMessageToClient(client, Text[ret] + "\r\n");
            }
            return ret;
        }
    }
}
