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
    public class ListViewerBase : TextScreenBase
    {
        public ListViewerBase(IClient c, IServer s) : base(c, s) { }
        public ListViewerBase(IClient c, IServer s, IScreen prev) : base(c, s, prev) { }
        public ListViewerBase(IClient c, IServer s, string txt) : this(c, s, txt, null) { }
        public ListViewerBase(IClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev)
        {
            lines = new List<string>();
            header = new List<string>();
            footer = new List<string>();
            ANSI = new ANSICodes();

            int body = Text.FindIndex(a => a.Trim().ToUpper() == "[TABLEBODY]");
            header.AddRange(Text.GetRange(0, body));
            footer.AddRange(Text.GetRange(body + 1, Text.Count - body - 1));

            dataAreaStart = body + 1;
            dataAreaSize = client.screenHeight - header.Count - footer.Count;
        }

        protected List<string> lines;
        protected List<string> header;
        protected List<string> footer;
        protected int dataAreaSize;
        protected int dataAreaStart;
        protected ANSICodes ANSI;


        public override void Show()
        {
            currentLine = ShowTableLines(0);
        }

        protected int ShowTableLines(int start)
        {
            Write(ANSI.ClearScreen());
            ShowLines(header, 0, header.Count);
            Write(ANSI.Move(0, dataAreaStart + dataAreaSize));
            ShowLines(footer, 0, footer.Count);
            Write(ANSI.SaveCursorPosition);
            Write(ANSI.Move(0, dataAreaStart));
            int ret = ShowLines(lines, start, dataAreaSize);
            Write(ANSI.RestoreCursorPosition);
            return ret;
        }

        public override void HandleMessage(string msg)
        {
            if (!string.IsNullOrWhiteSpace(msg) && msg.Substring(0, 1).ToUpper() == "B")
            {
                if (lines.Count > dataAreaSize && currentLine > dataAreaSize)
                {
                    int newStart = (currentLine - 1) / dataAreaSize - 1;
                    newStart = newStart < 0 ? 0 : newStart * dataAreaSize;
                    Writeln();
                    currentLine = ShowTableLines(newStart);
                }
            }

            if (string.IsNullOrWhiteSpace(msg))
            {
                if (lines.Count > dataAreaSize && currentLine < lines.Count)
                {
                    Writeln();
                    currentLine = ShowTableLines(currentLine+1);
                }
                else
                    ShowNext();
            }

            if (Data != null && Data.Actions.Count > 0) execAction(msg.Trim().ToUpper());
        }

    }
}
