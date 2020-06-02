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
using System.Text;

namespace Casasoft.TCPServer
{
    /// <summary>
    /// Handles Telnet negotiation
    /// </summary>
    public static class Negotiation
    {
        /// <summary>
        /// Negotiation codes as described in RFC 854
        /// </summary>
        /// <see cref="http://www.faqs.org/rfcs/rfc854.html"/>
        public enum Tokens
        {
            SE             = 240, //    End of subnegotiation parameters.
            NOP            = 241, //    No operation.
            DataMark       = 242, //    The data stream portion of a Synch.
                                  //    This should always be accompanied
                                  //    by a TCP Urgent notification.
            Break          = 243, //    NVT character BRK.
            IP             = 244, //    The function IP. Interrupt Process
            AO             = 245, //    The function AO. Abort output
            AYT            = 246, //    The function AYT. Are You There
            EraseChar      = 247, //    The function EC.
            EraseLine      = 248, //    The function EL.
            GoAhead        = 249, //    The GA signal.
            Subnegotiation = 250, //    Indicates that what follows is
                                  //    subnegotiation of the indicated
                                  //    option.
            WILL           = 251, //    Indicates the desire to begin
                                  //    performing, or confirmation that
                                  //    you are now performing, the
                                  //    indicated option.
            WONT           = 252, //    Indicates the refusal to perform,
                                  //    or continue performing, the
                                  //    indicated option.
            DO             = 253, //    Indicates the request that the
                                  //    other party perform, or
                                  //    confirmation that you are expecting
                                  //    the other party to perform, the
                                  //    indicated option.
            DONT           = 254, //    Indicates the demand that the
                                  //    other party stop performing,
                                  //    or confirmation that you are no
                                  //    longer expecting the other party
                                  //    to perform, the indicated option.
            IAC            = 255  //    Data Byte 255.
        }

        /// <summary>
        /// Negotiable options from IANA
        /// </summary>
        /// <see cref="https://www.iana.org/assignments/telnet-options/telnet-options.xhtml"/>
        public enum Operations
        {
            BinaryTransmission              = 0, 	//     [RFC856]
            Echo                            = 1, 	//     [RFC857]
            Reconnection                    = 2, 	//     [DDN Protocol Handbook, "Telnet Reconnection Option", "Telnet Output Line Width Option", "Telnet Output Page Size Option", NIC 50005, December 1985.]
            SuppressGoAhead                 = 3, 	//     [RFC858]
            ApproxMessageSizeNegotiation    = 4, 	//     ["The Ethernet, A Local Area Network: Data Link Layer and Physical Layer Specification", AA-K759B-TK, Digital Equipment Corporation, Maynard, MA.Also as: "The Ethernet - A Local Area Network", Version 1.0, Digital Equipment Corporation, Intel Corporation, Xerox Corporation, September 1980. And: "The Ethernet, A Local Area Network: Data Link Layer and Physical Layer Specifications", Digital, Intel and Xerox, November 1982. And: XEROX, "The Ethernet, A Local Area Network: Data Link Layer and Physical Layer Specification", X3T51/80-50, Xerox Corporation, Stamford, CT., October 1980.]
            Status                          = 5, 	//     [RFC859]
            TimingMark                      = 6, 	//     [RFC860]
            RemoteControlledTransAndEcho    = 7, 	//     [RFC726]
            OutputLineWidth                 = 8, 	//     [DDN Protocol Handbook, "Telnet Reconnection Option", "Telnet Output Line Width Option", "Telnet Output Page Size Option", NIC 50005, December 1985.]
            OutputPageSize                  = 9, 	//     [DDN Protocol Handbook, "Telnet Reconnection Option", "Telnet Output Line Width Option", "Telnet Output Page Size Option", NIC 50005, December 1985.]
            OutputCarriageReturnDisposition = 10, 	//     [RFC652]
            OutputHorizontalTabStops        = 11, 	//     [RFC653]
            OutputHorizontalTabDisposition  = 12, 	//     [RFC654]
            OutputFormfeedDisposition       = 13, 	//     [RFC655]
            OutputVerticalTabstops          = 14, 	//     [RFC656]
            OutputVerticalTabDisposition    = 15, 	//     [RFC657]
            OutputLinefeedDisposition       = 16, 	//     [RFC658]
            ExtendedASCII                   = 17, 	//     [RFC698]
            Logout                          = 18, 	//     [RFC727]
            ByteMacro                       = 19, 	//     [RFC735]
            DataEntryTerminal               = 20, 	//     [RFC1043], [RFC732]
            SUPDUP                          = 21, 	//     [RFC736],  [RFC734]
            SUPDUPOutput                    = 22, 	//     [RFC749]
            SendLocation                    = 23, 	//     [RFC779]
            TerminalType                    = 24, 	//     [RFC1091]
            EndOfRecord                     = 25, 	//     [RFC885]
            TACACSUserIdentification        = 26, 	//     [RFC927]
            OutputMarking                   = 27, 	//     [RFC933]
            TerminalLocationNumber          = 28, 	//     [RFC946]
            Telnet3270Regime                = 29, 	//     [RFC1041]
            X3PAD                           = 30, 	//     [RFC1053]
            NegotiateAboutWindowSize        = 31, 	//     [RFC1073]
            TerminalSpeed                   = 32, 	//     [RFC1079]
            RemoteFlowControl               = 33, 	//     [RFC1372]
            Linemode                        = 34, 	//     [RFC1184]
            XDisplayLocation                = 35, 	//     [RFC1096]
            EnvironmentOption               = 36, 	//     [RFC1408]
            AuthenticationOption            = 37, 	//     [RFC2941]
            EncryptionOption                = 38, 	//     [RFC2946]
            NewEnvironmentOption            = 39, 	//     [RFC1572]
            TN3270E                         = 40, 	//     [RFC2355]
            XAUTH                           = 41, 	//     [Rob_Earhart]
            CHARSET                         = 42, 	//     [RFC2066]
            TelnetRemoteSerialPort          = 43, 	//     [Robert_Barnes]
            ComPortControlOption            = 44, 	//     [RFC2217]
            TelnetSuppressLocalEcho         = 45, 	//     [Wirt_Atmar]
            TelnetStartTLS                  = 46, 	//     [Michael_Boe]
            KERMIT                          = 47, 	//     [RFC2840]
            SEND_URL                        = 48, 	//     [David_Croft]
            FORWARD_X                       = 49, 	//     [Jeffrey_Altman]
            TELOPT_PRAGMA_LOGON             = 138,  //    [Steve_McGregory]
            TELOPT_SSPI_LOGON               = 139,  //    [Steve_McGregory]
            TELOPT_PRAGMA_HEARTBEAT         = 140,  //    [Steve_McGregory]
            Extended_Options_List           = 255,  //    [RFC861]
        }

        /// <summary>
        /// Sends Do command
        /// </summary>
        /// <param name="op">Operation code</param>
        /// <returns>Negotiation sequence</returns>
        public static byte[] Do(Operations op) =>
            new byte[] { (byte)Tokens.IAC, (byte)Tokens.DO, (byte)op };

        /// <summary>
        /// Sends Don't command
        /// </summary>
        /// <param name="op">Operation code</param>
        /// <returns>Negotiation sequence</returns>
        public static byte[] Dont(Operations op) =>
            new byte[] { (byte)Tokens.IAC, (byte)Tokens.DONT, (byte)op };

        /// <summary>
        /// Sends Will command
        /// </summary>
        /// <param name="op">Operation code</param>
        /// <returns>Negotiation sequence</returns>
        public static byte[] Will(Operations op) =>
           new byte[] { (byte)Tokens.IAC, (byte)Tokens.WILL, (byte)op };

        /// <summary>
        /// Sends Won't command
        /// </summary>
        /// <param name="op">Operation code</param>
        /// <returns>Negotiation sequence</returns>
        public static byte[] Wont(Operations op) =>
            new byte[] { (byte)Tokens.IAC, (byte)Tokens.WONT, (byte)op };

        /// <summary>
        /// Handles window size negotiation as described in RFC1073
        /// <see cref="https://tools.ietf.org/html/rfc1073"/>
        /// </summary>
        /// <param name="data">received data</param>
        /// <param name="c">client to update</param>
        /// <remarks>
        /// Manages sequences like
        /// <code>
        /// IAC SB NAWS "16-bit value" "16-bit valu"> IAC SE
        /// </code>
        /// Sent by the Telnet client to inform the Telnet server of the
        /// window width and height.
        /// </remarks>
        public static void HandleWindowSize(byte[] data, int offset, IBBSClient c)
        {
            if (data[offset + 1] == (byte)Tokens.Subnegotiation
                && data[offset + 2] == (byte)Operations.NegotiateAboutWindowSize)
            {
                int w = data[offset + 3] * 256 + data[offset + 4];
                int h = data[offset + 5] * 256 + data[offset + 6];
                if (w != 0) c.screenWidth = w;
                if (h != 0) c.screenHeight = h;
            }
        }

        /// <summary>
        /// Tests if client supports binary transmission
        /// </summary>
        /// <param name="data"></param>
        /// <param name="offset"></param>
        /// <param name="c"></param>
        public static void HandleBinary(byte[] data, int offset, IBBSClient c)
        {
            if (data[offset + 1] == (byte)Tokens.DO
                && data[offset + 2] == (byte)Operations.BinaryTransmission)
                c.BinaryMode = true;
        }

        /// <summary>
        /// Tests if client support Terminal Type Negotiation RFC884 - RFC1091
        /// <see cref="https://tools.ietf.org/html/rfc884"/>
        /// <see cref="https://tools.ietf.org/html/rfc1091"/>
        /// </summary>
        /// <param name="data">received bytes</param>
        /// <returns></returns>
        public static bool ClientWillTerminalType(byte[] data, int offset)
        {
            bool ret = false;
            if (data[offset + 1] == (byte)Tokens.WILL
                && data[offset + 2] == (byte)Operations.TerminalType)
                ret = true;
            return ret;
        }

        /// <summary>
        /// Sequence to request terminal type to the client RFC884 - RFC1091
        /// <see cref="https://tools.ietf.org/html/rfc884"/>
        /// <see cref="https://tools.ietf.org/html/rfc1091"/>
        /// </summary>
        /// <returns>IAC SB TERMINAL-TYPE SEND IAC SE</returns>
        public static byte[] AskForTerminalType() => new byte[]
        {
            (byte)Tokens.IAC,
            (byte)Tokens.Subnegotiation,
            (byte)Operations.TerminalType,
            1,
            (byte)Tokens.IAC,
            (byte)Tokens.SE
        };

        /// <summary>
        /// Receive terminal type from cliente RFC884 - RFC1091
        /// <see cref="https://tools.ietf.org/html/rfc884"/>
        /// <see cref="https://tools.ietf.org/html/rfc1091"/>
        /// </summary>
        /// <param name="data">received data</param>
        /// <param name="c">client to update</param>
        /// <remarks>
        /// Client sends data in the form
        /// <code>
        /// IAC SB TERMINAL-TYPE IS ... IAC SE
        /// </code>
        /// The code for IS is 0.
        /// </remarks>
        public static bool HandleTerminalType(byte[] data, int offset, IBBSClient c)
        {
            if (data[offset + 1] == (byte)Tokens.Subnegotiation
                && data[offset + 2] == (byte)Operations.TerminalType
                && data[offset + 3] == 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = offset + 4; data[j] != (byte)Tokens.IAC; j++)
                    sb.Append((char)data[j]);

                if (string.IsNullOrWhiteSpace(c.terminalType))
                    c.terminalType = sb.ToString();

                return c.TryAddTerminalType(sb.ToString());
            }
            return false;
        }
    }
}
