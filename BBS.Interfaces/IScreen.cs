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

namespace Casasoft.BBS.Interfaces
{
    public interface IScreen
    {
        /// <summary>
        /// Pointer to the caller screen for backtracing
        /// </summary>
        public IScreen Previous { get; set; }
 
        /// <summary>
        /// Show screen content
        /// </summary>
        public void Show();

        /// <summary>
        /// Handles the messages received from the client
        /// </summary>
        /// <param name="msg"></param>
        public void HandleMessage(string msg);

        /// <summary>
        /// Handles special chars sequences received from the client
        /// </summary>
        /// <param name="data"></param>
        /// <param name="bytesReceived"></param>
        public void HandleChar(byte[] data, int bytesReceived);

        /// <summary>
        /// Pass the control to another screen
        /// </summary>
        public void ShowNext();
    }
}
