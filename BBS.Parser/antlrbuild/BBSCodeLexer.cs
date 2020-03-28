//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from grammar/BBSCodeLexer.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Casasoft.BBS.Parser {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class BBSCodeLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		SEA_WS=1, TAG_OPEN=2, BBS_TEXT=3, TAG_CLOSE=4, TAG_SLASH_CLOSE=5, TAG_SLASH=6, 
		TAG_EQUALS=7, TAG_NAME=8, TAG_WHITESPACE=9, ATTVALUE_VALUE=10, ATTRIBUTE=11;
	public const int
		TAG=1, ATTVALUE=2;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE", "TAG", "ATTVALUE"
	};

	public static readonly string[] ruleNames = {
		"SEA_WS", "TAG_OPEN", "BBS_TEXT", "TAG_CLOSE", "TAG_SLASH_CLOSE", "TAG_SLASH", 
		"TAG_EQUALS", "TAG_NAME", "TAG_WHITESPACE", "HEXDIGIT", "DIGIT", "TAG_NameChar", 
		"TAG_NameStartChar", "ATTVALUE_VALUE", "ATTRIBUTE", "ATTCHAR", "ATTCHARS", 
		"HEXCHARS", "DECCHARS", "DOUBLE_QUOTE_STRING", "SINGLE_QUOTE_STRING"
	};


	public BBSCodeLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public BBSCodeLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, "'{'", null, "'}'", "'/}'", "'/'", "'='"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SEA_WS", "TAG_OPEN", "BBS_TEXT", "TAG_CLOSE", "TAG_SLASH_CLOSE", 
		"TAG_SLASH", "TAG_EQUALS", "TAG_NAME", "TAG_WHITESPACE", "ATTVALUE_VALUE", 
		"ATTRIBUTE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "BBSCodeLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static BBSCodeLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\r', '\xA4', '\b', '\x1', '\b', '\x1', '\b', '\x1', 
		'\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', 
		'\x4', '\x4', '\x5', '\t', '\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', 
		'\t', '\a', '\x4', '\b', '\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', 
		'\t', '\n', '\x4', '\v', '\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', 
		'\t', '\r', '\x4', '\xE', '\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', 
		'\x10', '\t', '\x10', '\x4', '\x11', '\t', '\x11', '\x4', '\x12', '\t', 
		'\x12', '\x4', '\x13', '\t', '\x13', '\x4', '\x14', '\t', '\x14', '\x4', 
		'\x15', '\t', '\x15', '\x4', '\x16', '\t', '\x16', '\x3', '\x2', '\x3', 
		'\x2', '\x5', '\x2', '\x32', '\n', '\x2', '\x3', '\x2', '\x6', '\x2', 
		'\x35', '\n', '\x2', '\r', '\x2', '\xE', '\x2', '\x36', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x6', '\x4', 
		'>', '\n', '\x4', '\r', '\x4', '\xE', '\x4', '?', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\a', 
		'\t', 'S', '\n', '\t', '\f', '\t', '\xE', '\t', 'V', '\v', '\t', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', 
		'\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x5', '\r', '\x64', '\n', '\r', '\x3', '\xE', '\x5', '\xE', 'g', 
		'\n', '\xE', '\x3', '\xF', '\a', '\xF', 'j', '\n', '\xF', '\f', '\xF', 
		'\xE', '\xF', 'm', '\v', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x5', '\x10', 'x', '\n', '\x10', '\x3', '\x11', '\x5', 
		'\x11', '{', '\n', '\x11', '\x3', '\x12', '\x6', '\x12', '~', '\n', '\x12', 
		'\r', '\x12', '\xE', '\x12', '\x7F', '\x3', '\x12', '\x5', '\x12', '\x83', 
		'\n', '\x12', '\x3', '\x13', '\x3', '\x13', '\x6', '\x13', '\x87', '\n', 
		'\x13', '\r', '\x13', '\xE', '\x13', '\x88', '\x3', '\x14', '\x6', '\x14', 
		'\x8C', '\n', '\x14', '\r', '\x14', '\xE', '\x14', '\x8D', '\x3', '\x14', 
		'\x5', '\x14', '\x91', '\n', '\x14', '\x3', '\x15', '\x3', '\x15', '\a', 
		'\x15', '\x95', '\n', '\x15', '\f', '\x15', '\xE', '\x15', '\x98', '\v', 
		'\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\a', 
		'\x16', '\x9E', '\n', '\x16', '\f', '\x16', '\xE', '\x16', '\xA1', '\v', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x2', '\x2', '\x17', '\x5', '\x3', 
		'\a', '\x4', '\t', '\x5', '\v', '\x6', '\r', '\a', '\xF', '\b', '\x11', 
		'\t', '\x13', '\n', '\x15', '\v', '\x17', '\x2', '\x19', '\x2', '\x1B', 
		'\x2', '\x1D', '\x2', '\x1F', '\f', '!', '\r', '#', '\x2', '%', '\x2', 
		'\'', '\x2', ')', '\x2', '+', '\x2', '-', '\x2', '\x5', '\x2', '\x3', 
		'\x4', '\xE', '\x4', '\x2', '\v', '\v', '\"', '\"', '\x3', '\x2', '}', 
		'}', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x5', '\x2', 
		'\x32', ';', '\x43', 'H', '\x63', 'h', '\x3', '\x2', '\x32', ';', '\x4', 
		'\x2', '/', '\x30', '\x61', '\x61', '\x5', '\x2', '\xB9', '\xB9', '\x302', 
		'\x371', '\x2041', '\x2042', '\n', '\x2', '<', '<', '\x43', '\\', '\x63', 
		'|', '\x2072', '\x2191', '\x2C02', '\x2FF1', '\x3003', '\xD801', '\xF902', 
		'\xFDD1', '\xFDF2', '\xFFFF', '\x3', '\x2', '\"', '\"', '\t', '\x2', '%', 
		'%', '-', '=', '?', '?', '\x41', '\x41', '\x43', '\\', '\x61', '\x61', 
		'\x63', '|', '\x4', '\x2', '$', '$', '>', '>', '\x4', '\x2', ')', ')', 
		'>', '>', '\x2', '\xAB', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '\v', '\x3', '\x2', '\x2', '\x2', '\x3', '\r', '\x3', '\x2', '\x2', 
		'\x2', '\x3', '\xF', '\x3', '\x2', '\x2', '\x2', '\x3', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '\x13', '\x3', '\x2', '\x2', '\x2', '\x3', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x4', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\x4', '!', '\x3', '\x2', '\x2', '\x2', '\x5', '\x34', '\x3', '\x2', 
		'\x2', '\x2', '\a', '\x38', '\x3', '\x2', '\x2', '\x2', '\t', '=', '\x3', 
		'\x2', '\x2', '\x2', '\v', '\x41', '\x3', '\x2', '\x2', '\x2', '\r', '\x45', 
		'\x3', '\x2', '\x2', '\x2', '\xF', 'J', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'L', '\x3', '\x2', '\x2', '\x2', '\x13', 'P', '\x3', '\x2', '\x2', '\x2', 
		'\x15', 'W', '\x3', '\x2', '\x2', '\x2', '\x17', '[', '\x3', '\x2', '\x2', 
		'\x2', '\x19', ']', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x63', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', '\x66', '\x3', '\x2', '\x2', '\x2', '\x1F', 
		'k', '\x3', '\x2', '\x2', '\x2', '!', 'w', '\x3', '\x2', '\x2', '\x2', 
		'#', 'z', '\x3', '\x2', '\x2', '\x2', '%', '}', '\x3', '\x2', '\x2', '\x2', 
		'\'', '\x84', '\x3', '\x2', '\x2', '\x2', ')', '\x8B', '\x3', '\x2', '\x2', 
		'\x2', '+', '\x92', '\x3', '\x2', '\x2', '\x2', '-', '\x9B', '\x3', '\x2', 
		'\x2', '\x2', '/', '\x35', '\t', '\x2', '\x2', '\x2', '\x30', '\x32', 
		'\a', '\xF', '\x2', '\x2', '\x31', '\x30', '\x3', '\x2', '\x2', '\x2', 
		'\x31', '\x32', '\x3', '\x2', '\x2', '\x2', '\x32', '\x33', '\x3', '\x2', 
		'\x2', '\x2', '\x33', '\x35', '\a', '\f', '\x2', '\x2', '\x34', '/', '\x3', 
		'\x2', '\x2', '\x2', '\x34', '\x31', '\x3', '\x2', '\x2', '\x2', '\x35', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\x36', '\x34', '\x3', '\x2', '\x2', 
		'\x2', '\x36', '\x37', '\x3', '\x2', '\x2', '\x2', '\x37', '\x6', '\x3', 
		'\x2', '\x2', '\x2', '\x38', '\x39', '\a', '}', '\x2', '\x2', '\x39', 
		':', '\x3', '\x2', '\x2', '\x2', ':', ';', '\b', '\x3', '\x2', '\x2', 
		';', '\b', '\x3', '\x2', '\x2', '\x2', '<', '>', '\n', '\x3', '\x2', '\x2', 
		'=', '<', '\x3', '\x2', '\x2', '\x2', '>', '?', '\x3', '\x2', '\x2', '\x2', 
		'?', '=', '\x3', '\x2', '\x2', '\x2', '?', '@', '\x3', '\x2', '\x2', '\x2', 
		'@', '\n', '\x3', '\x2', '\x2', '\x2', '\x41', '\x42', '\a', '\x7F', '\x2', 
		'\x2', '\x42', '\x43', '\x3', '\x2', '\x2', '\x2', '\x43', '\x44', '\b', 
		'\x5', '\x3', '\x2', '\x44', '\f', '\x3', '\x2', '\x2', '\x2', '\x45', 
		'\x46', '\a', '\x31', '\x2', '\x2', '\x46', 'G', '\a', '\x7F', '\x2', 
		'\x2', 'G', 'H', '\x3', '\x2', '\x2', '\x2', 'H', 'I', '\b', '\x6', '\x3', 
		'\x2', 'I', '\xE', '\x3', '\x2', '\x2', '\x2', 'J', 'K', '\a', '\x31', 
		'\x2', '\x2', 'K', '\x10', '\x3', '\x2', '\x2', '\x2', 'L', 'M', '\a', 
		'?', '\x2', '\x2', 'M', 'N', '\x3', '\x2', '\x2', '\x2', 'N', 'O', '\b', 
		'\b', '\x4', '\x2', 'O', '\x12', '\x3', '\x2', '\x2', '\x2', 'P', 'T', 
		'\x5', '\x1D', '\xE', '\x2', 'Q', 'S', '\x5', '\x1B', '\r', '\x2', 'R', 
		'Q', '\x3', '\x2', '\x2', '\x2', 'S', 'V', '\x3', '\x2', '\x2', '\x2', 
		'T', 'R', '\x3', '\x2', '\x2', '\x2', 'T', 'U', '\x3', '\x2', '\x2', '\x2', 
		'U', '\x14', '\x3', '\x2', '\x2', '\x2', 'V', 'T', '\x3', '\x2', '\x2', 
		'\x2', 'W', 'X', '\t', '\x4', '\x2', '\x2', 'X', 'Y', '\x3', '\x2', '\x2', 
		'\x2', 'Y', 'Z', '\b', '\n', '\x5', '\x2', 'Z', '\x16', '\x3', '\x2', 
		'\x2', '\x2', '[', '\\', '\t', '\x5', '\x2', '\x2', '\\', '\x18', '\x3', 
		'\x2', '\x2', '\x2', ']', '^', '\t', '\x6', '\x2', '\x2', '^', '\x1A', 
		'\x3', '\x2', '\x2', '\x2', '_', '\x64', '\x5', '\x1D', '\xE', '\x2', 
		'`', '\x64', '\t', '\a', '\x2', '\x2', '\x61', '\x64', '\x5', '\x19', 
		'\f', '\x2', '\x62', '\x64', '\t', '\b', '\x2', '\x2', '\x63', '_', '\x3', 
		'\x2', '\x2', '\x2', '\x63', '`', '\x3', '\x2', '\x2', '\x2', '\x63', 
		'\x61', '\x3', '\x2', '\x2', '\x2', '\x63', '\x62', '\x3', '\x2', '\x2', 
		'\x2', '\x64', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x65', 'g', '\t', 
		'\t', '\x2', '\x2', '\x66', '\x65', '\x3', '\x2', '\x2', '\x2', 'g', '\x1E', 
		'\x3', '\x2', '\x2', '\x2', 'h', 'j', '\t', '\n', '\x2', '\x2', 'i', 'h', 
		'\x3', '\x2', '\x2', '\x2', 'j', 'm', '\x3', '\x2', '\x2', '\x2', 'k', 
		'i', '\x3', '\x2', '\x2', '\x2', 'k', 'l', '\x3', '\x2', '\x2', '\x2', 
		'l', 'n', '\x3', '\x2', '\x2', '\x2', 'm', 'k', '\x3', '\x2', '\x2', '\x2', 
		'n', 'o', '\x5', '!', '\x10', '\x2', 'o', 'p', '\x3', '\x2', '\x2', '\x2', 
		'p', 'q', '\b', '\xF', '\x3', '\x2', 'q', ' ', '\x3', '\x2', '\x2', '\x2', 
		'r', 'x', '\x5', '+', '\x15', '\x2', 's', 'x', '\x5', '-', '\x16', '\x2', 
		't', 'x', '\x5', '%', '\x12', '\x2', 'u', 'x', '\x5', '\'', '\x13', '\x2', 
		'v', 'x', '\x5', ')', '\x14', '\x2', 'w', 'r', '\x3', '\x2', '\x2', '\x2', 
		'w', 's', '\x3', '\x2', '\x2', '\x2', 'w', 't', '\x3', '\x2', '\x2', '\x2', 
		'w', 'u', '\x3', '\x2', '\x2', '\x2', 'w', 'v', '\x3', '\x2', '\x2', '\x2', 
		'x', '\"', '\x3', '\x2', '\x2', '\x2', 'y', '{', '\t', '\v', '\x2', '\x2', 
		'z', 'y', '\x3', '\x2', '\x2', '\x2', '{', '$', '\x3', '\x2', '\x2', '\x2', 
		'|', '~', '\x5', '#', '\x11', '\x2', '}', '|', '\x3', '\x2', '\x2', '\x2', 
		'~', '\x7F', '\x3', '\x2', '\x2', '\x2', '\x7F', '}', '\x3', '\x2', '\x2', 
		'\x2', '\x7F', '\x80', '\x3', '\x2', '\x2', '\x2', '\x80', '\x82', '\x3', 
		'\x2', '\x2', '\x2', '\x81', '\x83', '\a', '\"', '\x2', '\x2', '\x82', 
		'\x81', '\x3', '\x2', '\x2', '\x2', '\x82', '\x83', '\x3', '\x2', '\x2', 
		'\x2', '\x83', '&', '\x3', '\x2', '\x2', '\x2', '\x84', '\x86', '\a', 
		'%', '\x2', '\x2', '\x85', '\x87', '\t', '\x5', '\x2', '\x2', '\x86', 
		'\x85', '\x3', '\x2', '\x2', '\x2', '\x87', '\x88', '\x3', '\x2', '\x2', 
		'\x2', '\x88', '\x86', '\x3', '\x2', '\x2', '\x2', '\x88', '\x89', '\x3', 
		'\x2', '\x2', '\x2', '\x89', '(', '\x3', '\x2', '\x2', '\x2', '\x8A', 
		'\x8C', '\t', '\x6', '\x2', '\x2', '\x8B', '\x8A', '\x3', '\x2', '\x2', 
		'\x2', '\x8C', '\x8D', '\x3', '\x2', '\x2', '\x2', '\x8D', '\x8B', '\x3', 
		'\x2', '\x2', '\x2', '\x8D', '\x8E', '\x3', '\x2', '\x2', '\x2', '\x8E', 
		'\x90', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x91', '\a', '\'', '\x2', 
		'\x2', '\x90', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x90', '\x91', '\x3', 
		'\x2', '\x2', '\x2', '\x91', '*', '\x3', '\x2', '\x2', '\x2', '\x92', 
		'\x96', '\a', '$', '\x2', '\x2', '\x93', '\x95', '\n', '\f', '\x2', '\x2', 
		'\x94', '\x93', '\x3', '\x2', '\x2', '\x2', '\x95', '\x98', '\x3', '\x2', 
		'\x2', '\x2', '\x96', '\x94', '\x3', '\x2', '\x2', '\x2', '\x96', '\x97', 
		'\x3', '\x2', '\x2', '\x2', '\x97', '\x99', '\x3', '\x2', '\x2', '\x2', 
		'\x98', '\x96', '\x3', '\x2', '\x2', '\x2', '\x99', '\x9A', '\a', '$', 
		'\x2', '\x2', '\x9A', ',', '\x3', '\x2', '\x2', '\x2', '\x9B', '\x9F', 
		'\a', ')', '\x2', '\x2', '\x9C', '\x9E', '\n', '\r', '\x2', '\x2', '\x9D', 
		'\x9C', '\x3', '\x2', '\x2', '\x2', '\x9E', '\xA1', '\x3', '\x2', '\x2', 
		'\x2', '\x9F', '\x9D', '\x3', '\x2', '\x2', '\x2', '\x9F', '\xA0', '\x3', 
		'\x2', '\x2', '\x2', '\xA0', '\xA2', '\x3', '\x2', '\x2', '\x2', '\xA1', 
		'\x9F', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', '\a', ')', '\x2', 
		'\x2', '\xA3', '.', '\x3', '\x2', '\x2', '\x2', '\x16', '\x2', '\x3', 
		'\x4', '\x31', '\x34', '\x36', '?', 'T', '\x63', '\x66', 'k', 'w', 'z', 
		'\x7F', '\x82', '\x88', '\x8D', '\x90', '\x96', '\x9F', '\x6', '\a', '\x3', 
		'\x2', '\x6', '\x2', '\x2', '\a', '\x4', '\x2', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Casasoft.BBS.Parser
