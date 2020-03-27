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

parser grammar BBSCodeParser;

options { tokenVocab='../antlrbuild/BBSCodeLexer'; }

bbsCodeElement
    : TAG_OPEN bbsCodeTagName bbsCodeAttribute* TAG_CLOSE bbsCodeContent TAG_OPEN TAG_SLASH bbsCodeTagName TAG_CLOSE
    | TAG_OPEN bbsCodeTagName bbsCodeAttribute* TAG_SLASH_CLOSE
    | TAG_OPEN bbsCodeTagName bbsCodeAttribute* TAG_CLOSE
    ;

bbsCodeContent
    : bbsCodeChardata? (bbsCodeElement bbsCodeChardata?)*
    ;

bbsCodeAttribute
    : bbsCodeAttributeName TAG_EQUALS bbsCodeAttributeValue
    | bbsCodeAttributeName
    ;

bbsCodeAttributeName
    : TAG_NAME
    ;

bbsCodeAttributeValue
    : ATTVALUE_VALUE
    ;

bbsCodeTagName
    : TAG_NAME
    ;

bbsCodeChardata
    : BBS_TEXT
    | SEA_WS
    ;

