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
		SEA_WS=1, EntityRef=2, TAG_OPEN=3, BBS_TEXT=4, ENTITY_NAME=5, TAG_CLOSE=6, 
		TAG_SLASH_CLOSE=7, TAG_SLASH=8, TAG_EQUALS=9, TAG_NAME=10, TAG_WHITESPACE=11, 
		ATTVALUE_VALUE=12, ATTRIBUTE=13;
	public const int
		TAG=1, ATTVALUE=2;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE", "TAG", "ATTVALUE"
	};

	public static readonly string[] ruleNames = {
		"SEA_WS", "EntityRef", "TAG_OPEN", "BBS_TEXT", "ENTITY_NAME", "Entity_NameChar", 
		"Entity_NameStartChar", "TAG_CLOSE", "TAG_SLASH_CLOSE", "TAG_SLASH", "TAG_EQUALS", 
		"TAG_NAME", "TAG_WHITESPACE", "HEXDIGIT", "DIGIT", "TAG_NameChar", "TAG_NameStartChar", 
		"ATTVALUE_VALUE", "ATTRIBUTE", "ATTCHAR", "ATTCHARS", "HEXCHARS", "DECCHARS", 
		"DOUBLE_QUOTE_STRING", "SINGLE_QUOTE_STRING"
	};


	public BBSCodeLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public BBSCodeLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, "'{'", null, null, "'}'", "'/}'", "'/'", "'='"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SEA_WS", "EntityRef", "TAG_OPEN", "BBS_TEXT", "ENTITY_NAME", "TAG_CLOSE", 
		"TAG_SLASH_CLOSE", "TAG_SLASH", "TAG_EQUALS", "TAG_NAME", "TAG_WHITESPACE", 
		"ATTVALUE_VALUE", "ATTRIBUTE"
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
		'\x5964', '\x2', '\xF', '\xBE', '\b', '\x1', '\b', '\x1', '\b', '\x1', 
		'\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', 
		'\x4', '\x4', '\x5', '\t', '\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', 
		'\t', '\a', '\x4', '\b', '\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', 
		'\t', '\n', '\x4', '\v', '\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', 
		'\t', '\r', '\x4', '\xE', '\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', 
		'\x10', '\t', '\x10', '\x4', '\x11', '\t', '\x11', '\x4', '\x12', '\t', 
		'\x12', '\x4', '\x13', '\t', '\x13', '\x4', '\x14', '\t', '\x14', '\x4', 
		'\x15', '\t', '\x15', '\x4', '\x16', '\t', '\x16', '\x4', '\x17', '\t', 
		'\x17', '\x4', '\x18', '\t', '\x18', '\x4', '\x19', '\t', '\x19', '\x4', 
		'\x1A', '\t', '\x1A', '\x3', '\x2', '\x3', '\x2', '\x5', '\x2', ':', '\n', 
		'\x2', '\x3', '\x2', '\x6', '\x2', '=', '\n', '\x2', '\r', '\x2', '\xE', 
		'\x2', '>', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x6', 
		'\x5', 'J', '\n', '\x5', '\r', '\x5', '\xE', '\x5', 'K', '\x3', '\x6', 
		'\x3', '\x6', '\a', '\x6', 'P', '\n', '\x6', '\f', '\x6', '\xE', '\x6', 
		'S', '\v', '\x6', '\x3', '\a', '\x3', '\a', '\x5', '\a', 'W', '\n', '\a', 
		'\x3', '\b', '\x5', '\b', 'Z', '\n', '\b', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\a', '\r', 'm', '\n', '\r', 
		'\f', '\r', '\xE', '\r', 'p', '\v', '\r', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', 
		'\x5', '\x11', '~', '\n', '\x11', '\x3', '\x12', '\x5', '\x12', '\x81', 
		'\n', '\x12', '\x3', '\x13', '\a', '\x13', '\x84', '\n', '\x13', '\f', 
		'\x13', '\xE', '\x13', '\x87', '\v', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x5', '\x14', '\x92', '\n', '\x14', '\x3', 
		'\x15', '\x5', '\x15', '\x95', '\n', '\x15', '\x3', '\x16', '\x6', '\x16', 
		'\x98', '\n', '\x16', '\r', '\x16', '\xE', '\x16', '\x99', '\x3', '\x16', 
		'\x5', '\x16', '\x9D', '\n', '\x16', '\x3', '\x17', '\x3', '\x17', '\x6', 
		'\x17', '\xA1', '\n', '\x17', '\r', '\x17', '\xE', '\x17', '\xA2', '\x3', 
		'\x18', '\x6', '\x18', '\xA6', '\n', '\x18', '\r', '\x18', '\xE', '\x18', 
		'\xA7', '\x3', '\x18', '\x5', '\x18', '\xAB', '\n', '\x18', '\x3', '\x19', 
		'\x3', '\x19', '\a', '\x19', '\xAF', '\n', '\x19', '\f', '\x19', '\xE', 
		'\x19', '\xB2', '\v', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', 
		'\x3', '\x1A', '\a', '\x1A', '\xB8', '\n', '\x1A', '\f', '\x1A', '\xE', 
		'\x1A', '\xBB', '\v', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x2', '\x2', 
		'\x1B', '\x5', '\x3', '\a', '\x4', '\t', '\x5', '\v', '\x6', '\r', '\a', 
		'\xF', '\x2', '\x11', '\x2', '\x13', '\b', '\x15', '\t', '\x17', '\n', 
		'\x19', '\v', '\x1B', '\f', '\x1D', '\r', '\x1F', '\x2', '!', '\x2', '#', 
		'\x2', '%', '\x2', '\'', '\xE', ')', '\xF', '+', '\x2', '-', '\x2', '/', 
		'\x2', '\x31', '\x2', '\x33', '\x2', '\x35', '\x2', '\x5', '\x2', '\x3', 
		'\x4', '\xF', '\x4', '\x2', '\v', '\v', '\"', '\"', '\x4', '\x2', '(', 
		'(', '}', '}', '\b', '\x2', '/', '\x30', '\x32', ';', '\x61', '\x61', 
		'\xB9', '\xB9', '\x302', '\x371', '\x2041', '\x2042', '\n', '\x2', '<', 
		'<', '\x43', '\\', '\x63', '|', '\x2072', '\x2191', '\x2C02', '\x2FF1', 
		'\x3003', '\xD801', '\xF902', '\xFDD1', '\xFDF2', '\xFFFF', '\x5', '\x2', 
		'\v', '\f', '\xF', '\xF', '\"', '\"', '\x5', '\x2', '\x32', ';', '\x43', 
		'H', '\x63', 'h', '\x3', '\x2', '\x32', ';', '\x4', '\x2', '/', '\x30', 
		'\x61', '\x61', '\x5', '\x2', '\xB9', '\xB9', '\x302', '\x371', '\x2041', 
		'\x2042', '\x3', '\x2', '\"', '\"', '\t', '\x2', '%', '%', '-', '=', '?', 
		'?', '\x41', '\x41', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x4', 
		'\x2', '$', '$', '>', '>', '\x4', '\x2', ')', ')', '>', '>', '\x2', '\xC5', 
		'\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x3', '\x13', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '\x15', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '\x17', '\x3', '\x2', '\x2', '\x2', '\x3', '\x19', '\x3', '\x2', 
		'\x2', '\x2', '\x3', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x3', '\x1D', 
		'\x3', '\x2', '\x2', '\x2', '\x4', '\'', '\x3', '\x2', '\x2', '\x2', '\x4', 
		')', '\x3', '\x2', '\x2', '\x2', '\x5', '<', '\x3', '\x2', '\x2', '\x2', 
		'\a', '@', '\x3', '\x2', '\x2', '\x2', '\t', '\x44', '\x3', '\x2', '\x2', 
		'\x2', '\v', 'I', '\x3', '\x2', '\x2', '\x2', '\r', 'M', '\x3', '\x2', 
		'\x2', '\x2', '\xF', 'V', '\x3', '\x2', '\x2', '\x2', '\x11', 'Y', '\x3', 
		'\x2', '\x2', '\x2', '\x13', '[', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'_', '\x3', '\x2', '\x2', '\x2', '\x17', '\x64', '\x3', '\x2', '\x2', 
		'\x2', '\x19', '\x66', '\x3', '\x2', '\x2', '\x2', '\x1B', 'j', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', 'q', '\x3', '\x2', '\x2', '\x2', '\x1F', 
		'u', '\x3', '\x2', '\x2', '\x2', '!', 'w', '\x3', '\x2', '\x2', '\x2', 
		'#', '}', '\x3', '\x2', '\x2', '\x2', '%', '\x80', '\x3', '\x2', '\x2', 
		'\x2', '\'', '\x85', '\x3', '\x2', '\x2', '\x2', ')', '\x91', '\x3', '\x2', 
		'\x2', '\x2', '+', '\x94', '\x3', '\x2', '\x2', '\x2', '-', '\x97', '\x3', 
		'\x2', '\x2', '\x2', '/', '\x9E', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\xA5', '\x3', '\x2', '\x2', '\x2', '\x33', '\xAC', '\x3', '\x2', '\x2', 
		'\x2', '\x35', '\xB5', '\x3', '\x2', '\x2', '\x2', '\x37', '=', '\t', 
		'\x2', '\x2', '\x2', '\x38', ':', '\a', '\xF', '\x2', '\x2', '\x39', '\x38', 
		'\x3', '\x2', '\x2', '\x2', '\x39', ':', '\x3', '\x2', '\x2', '\x2', ':', 
		';', '\x3', '\x2', '\x2', '\x2', ';', '=', '\a', '\f', '\x2', '\x2', '<', 
		'\x37', '\x3', '\x2', '\x2', '\x2', '<', '\x39', '\x3', '\x2', '\x2', 
		'\x2', '=', '>', '\x3', '\x2', '\x2', '\x2', '>', '<', '\x3', '\x2', '\x2', 
		'\x2', '>', '?', '\x3', '\x2', '\x2', '\x2', '?', '\x6', '\x3', '\x2', 
		'\x2', '\x2', '@', '\x41', '\a', '(', '\x2', '\x2', '\x41', '\x42', '\x5', 
		'\r', '\x6', '\x2', '\x42', '\x43', '\a', '=', '\x2', '\x2', '\x43', '\b', 
		'\x3', '\x2', '\x2', '\x2', '\x44', '\x45', '\a', '}', '\x2', '\x2', '\x45', 
		'\x46', '\x3', '\x2', '\x2', '\x2', '\x46', 'G', '\b', '\x4', '\x2', '\x2', 
		'G', '\n', '\x3', '\x2', '\x2', '\x2', 'H', 'J', '\n', '\x3', '\x2', '\x2', 
		'I', 'H', '\x3', '\x2', '\x2', '\x2', 'J', 'K', '\x3', '\x2', '\x2', '\x2', 
		'K', 'I', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\x3', '\x2', '\x2', '\x2', 
		'L', '\f', '\x3', '\x2', '\x2', '\x2', 'M', 'Q', '\x5', '\x11', '\b', 
		'\x2', 'N', 'P', '\x5', '\xF', '\a', '\x2', 'O', 'N', '\x3', '\x2', '\x2', 
		'\x2', 'P', 'S', '\x3', '\x2', '\x2', '\x2', 'Q', 'O', '\x3', '\x2', '\x2', 
		'\x2', 'Q', 'R', '\x3', '\x2', '\x2', '\x2', 'R', '\xE', '\x3', '\x2', 
		'\x2', '\x2', 'S', 'Q', '\x3', '\x2', '\x2', '\x2', 'T', 'W', '\x5', '\x11', 
		'\b', '\x2', 'U', 'W', '\t', '\x4', '\x2', '\x2', 'V', 'T', '\x3', '\x2', 
		'\x2', '\x2', 'V', 'U', '\x3', '\x2', '\x2', '\x2', 'W', '\x10', '\x3', 
		'\x2', '\x2', '\x2', 'X', 'Z', '\t', '\x5', '\x2', '\x2', 'Y', 'X', '\x3', 
		'\x2', '\x2', '\x2', 'Z', '\x12', '\x3', '\x2', '\x2', '\x2', '[', '\\', 
		'\a', '\x7F', '\x2', '\x2', '\\', ']', '\x3', '\x2', '\x2', '\x2', ']', 
		'^', '\b', '\t', '\x3', '\x2', '^', '\x14', '\x3', '\x2', '\x2', '\x2', 
		'_', '`', '\a', '\x31', '\x2', '\x2', '`', '\x61', '\a', '\x7F', '\x2', 
		'\x2', '\x61', '\x62', '\x3', '\x2', '\x2', '\x2', '\x62', '\x63', '\b', 
		'\n', '\x3', '\x2', '\x63', '\x16', '\x3', '\x2', '\x2', '\x2', '\x64', 
		'\x65', '\a', '\x31', '\x2', '\x2', '\x65', '\x18', '\x3', '\x2', '\x2', 
		'\x2', '\x66', 'g', '\a', '?', '\x2', '\x2', 'g', 'h', '\x3', '\x2', '\x2', 
		'\x2', 'h', 'i', '\b', '\f', '\x4', '\x2', 'i', '\x1A', '\x3', '\x2', 
		'\x2', '\x2', 'j', 'n', '\x5', '%', '\x12', '\x2', 'k', 'm', '\x5', '#', 
		'\x11', '\x2', 'l', 'k', '\x3', '\x2', '\x2', '\x2', 'm', 'p', '\x3', 
		'\x2', '\x2', '\x2', 'n', 'l', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\x3', 
		'\x2', '\x2', '\x2', 'o', '\x1C', '\x3', '\x2', '\x2', '\x2', 'p', 'n', 
		'\x3', '\x2', '\x2', '\x2', 'q', 'r', '\t', '\x6', '\x2', '\x2', 'r', 
		's', '\x3', '\x2', '\x2', '\x2', 's', 't', '\b', '\xE', '\x5', '\x2', 
		't', '\x1E', '\x3', '\x2', '\x2', '\x2', 'u', 'v', '\t', '\a', '\x2', 
		'\x2', 'v', ' ', '\x3', '\x2', '\x2', '\x2', 'w', 'x', '\t', '\b', '\x2', 
		'\x2', 'x', '\"', '\x3', '\x2', '\x2', '\x2', 'y', '~', '\x5', '%', '\x12', 
		'\x2', 'z', '~', '\t', '\t', '\x2', '\x2', '{', '~', '\x5', '!', '\x10', 
		'\x2', '|', '~', '\t', '\n', '\x2', '\x2', '}', 'y', '\x3', '\x2', '\x2', 
		'\x2', '}', 'z', '\x3', '\x2', '\x2', '\x2', '}', '{', '\x3', '\x2', '\x2', 
		'\x2', '}', '|', '\x3', '\x2', '\x2', '\x2', '~', '$', '\x3', '\x2', '\x2', 
		'\x2', '\x7F', '\x81', '\t', '\x5', '\x2', '\x2', '\x80', '\x7F', '\x3', 
		'\x2', '\x2', '\x2', '\x81', '&', '\x3', '\x2', '\x2', '\x2', '\x82', 
		'\x84', '\t', '\v', '\x2', '\x2', '\x83', '\x82', '\x3', '\x2', '\x2', 
		'\x2', '\x84', '\x87', '\x3', '\x2', '\x2', '\x2', '\x85', '\x83', '\x3', 
		'\x2', '\x2', '\x2', '\x85', '\x86', '\x3', '\x2', '\x2', '\x2', '\x86', 
		'\x88', '\x3', '\x2', '\x2', '\x2', '\x87', '\x85', '\x3', '\x2', '\x2', 
		'\x2', '\x88', '\x89', '\x5', ')', '\x14', '\x2', '\x89', '\x8A', '\x3', 
		'\x2', '\x2', '\x2', '\x8A', '\x8B', '\b', '\x13', '\x3', '\x2', '\x8B', 
		'(', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x92', '\x5', '\x33', '\x19', 
		'\x2', '\x8D', '\x92', '\x5', '\x35', '\x1A', '\x2', '\x8E', '\x92', '\x5', 
		'-', '\x16', '\x2', '\x8F', '\x92', '\x5', '/', '\x17', '\x2', '\x90', 
		'\x92', '\x5', '\x31', '\x18', '\x2', '\x91', '\x8C', '\x3', '\x2', '\x2', 
		'\x2', '\x91', '\x8D', '\x3', '\x2', '\x2', '\x2', '\x91', '\x8E', '\x3', 
		'\x2', '\x2', '\x2', '\x91', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x91', 
		'\x90', '\x3', '\x2', '\x2', '\x2', '\x92', '*', '\x3', '\x2', '\x2', 
		'\x2', '\x93', '\x95', '\t', '\f', '\x2', '\x2', '\x94', '\x93', '\x3', 
		'\x2', '\x2', '\x2', '\x95', ',', '\x3', '\x2', '\x2', '\x2', '\x96', 
		'\x98', '\x5', '+', '\x15', '\x2', '\x97', '\x96', '\x3', '\x2', '\x2', 
		'\x2', '\x98', '\x99', '\x3', '\x2', '\x2', '\x2', '\x99', '\x97', '\x3', 
		'\x2', '\x2', '\x2', '\x99', '\x9A', '\x3', '\x2', '\x2', '\x2', '\x9A', 
		'\x9C', '\x3', '\x2', '\x2', '\x2', '\x9B', '\x9D', '\a', '\"', '\x2', 
		'\x2', '\x9C', '\x9B', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x9D', '\x3', 
		'\x2', '\x2', '\x2', '\x9D', '.', '\x3', '\x2', '\x2', '\x2', '\x9E', 
		'\xA0', '\a', '%', '\x2', '\x2', '\x9F', '\xA1', '\t', '\a', '\x2', '\x2', 
		'\xA0', '\x9F', '\x3', '\x2', '\x2', '\x2', '\xA1', '\xA2', '\x3', '\x2', 
		'\x2', '\x2', '\xA2', '\xA0', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', 
		'\x3', '\x2', '\x2', '\x2', '\xA3', '\x30', '\x3', '\x2', '\x2', '\x2', 
		'\xA4', '\xA6', '\t', '\b', '\x2', '\x2', '\xA5', '\xA4', '\x3', '\x2', 
		'\x2', '\x2', '\xA6', '\xA7', '\x3', '\x2', '\x2', '\x2', '\xA7', '\xA5', 
		'\x3', '\x2', '\x2', '\x2', '\xA7', '\xA8', '\x3', '\x2', '\x2', '\x2', 
		'\xA8', '\xAA', '\x3', '\x2', '\x2', '\x2', '\xA9', '\xAB', '\a', '\'', 
		'\x2', '\x2', '\xAA', '\xA9', '\x3', '\x2', '\x2', '\x2', '\xAA', '\xAB', 
		'\x3', '\x2', '\x2', '\x2', '\xAB', '\x32', '\x3', '\x2', '\x2', '\x2', 
		'\xAC', '\xB0', '\a', '$', '\x2', '\x2', '\xAD', '\xAF', '\n', '\r', '\x2', 
		'\x2', '\xAE', '\xAD', '\x3', '\x2', '\x2', '\x2', '\xAF', '\xB2', '\x3', 
		'\x2', '\x2', '\x2', '\xB0', '\xAE', '\x3', '\x2', '\x2', '\x2', '\xB0', 
		'\xB1', '\x3', '\x2', '\x2', '\x2', '\xB1', '\xB3', '\x3', '\x2', '\x2', 
		'\x2', '\xB2', '\xB0', '\x3', '\x2', '\x2', '\x2', '\xB3', '\xB4', '\a', 
		'$', '\x2', '\x2', '\xB4', '\x34', '\x3', '\x2', '\x2', '\x2', '\xB5', 
		'\xB9', '\a', ')', '\x2', '\x2', '\xB6', '\xB8', '\n', '\xE', '\x2', '\x2', 
		'\xB7', '\xB6', '\x3', '\x2', '\x2', '\x2', '\xB8', '\xBB', '\x3', '\x2', 
		'\x2', '\x2', '\xB9', '\xB7', '\x3', '\x2', '\x2', '\x2', '\xB9', '\xBA', 
		'\x3', '\x2', '\x2', '\x2', '\xBA', '\xBC', '\x3', '\x2', '\x2', '\x2', 
		'\xBB', '\xB9', '\x3', '\x2', '\x2', '\x2', '\xBC', '\xBD', '\a', ')', 
		'\x2', '\x2', '\xBD', '\x36', '\x3', '\x2', '\x2', '\x2', '\x19', '\x2', 
		'\x3', '\x4', '\x39', '<', '>', 'K', 'Q', 'V', 'Y', 'n', '}', '\x80', 
		'\x85', '\x91', '\x94', '\x99', '\x9C', '\xA2', '\xA7', '\xAA', '\xB0', 
		'\xB9', '\x6', '\a', '\x3', '\x2', '\x6', '\x2', '\x2', '\a', '\x4', '\x2', 
		'\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Casasoft.BBS.Parser
