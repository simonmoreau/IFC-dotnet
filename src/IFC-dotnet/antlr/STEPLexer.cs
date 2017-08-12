//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from STEP.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace STEP {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class STEPLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, Digit=13, Digits=14, Letter=15, CapitalLetter=16, 
		DateTime=17, ENDSEC=18, FILE_DESCRIPTION=19, FILE_NAME=20, FILE_SCHEMA=21, 
		HEADER=22, Id=23, ISO=24, ISO_END=25, StringLiteral=26, TypeRef=27, Undefined=28, 
		NewlineChar=29, WS=30, Comments=31;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "Digit", "Digits", "Letter", "CapitalLetter", 
		"DateTime", "ENDSEC", "FILE_DESCRIPTION", "FILE_NAME", "FILE_SCHEMA", 
		"HEADER", "Id", "ISO", "ISO_END", "StringLiteral", "TypeRef", "Undefined", 
		"NewlineChar", "WS", "Comments"
	};


	public STEPLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public STEPLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'('", "','", "')'", "';'", "'''", "'.'", "'='", "'ViewDefinition'", 
		"'['", "']'", "'CoordinationView'", "'QuantityTakeOffAddOnView'", null, 
		null, null, null, null, "'ENDSEC'", "'FILE_DESCRIPTION'", "'FILE_NAME'", 
		"'FILE_SCHEMA'", "'HEADER'", null, null, null, null, null, "'$'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, "Digit", "Digits", "Letter", "CapitalLetter", "DateTime", "ENDSEC", 
		"FILE_DESCRIPTION", "FILE_NAME", "FILE_SCHEMA", "HEADER", "Id", "ISO", 
		"ISO_END", "StringLiteral", "TypeRef", "Undefined", "NewlineChar", "WS", 
		"Comments"
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

	public override string GrammarFileName { get { return "STEP.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static STEPLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '!', '\x123', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', 
		'\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\a', '\xF', '\x91', 
		'\n', '\xF', '\f', '\xF', '\xE', '\xF', '\x94', '\v', '\xF', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', 
		'\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', 
		'\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1B', '\x3', '\x1B', '\a', '\x1B', '\xF8', '\n', '\x1B', '\f', 
		'\x1B', '\xE', '\x1B', '\xFB', '\v', '\x1B', '\x3', '\x1B', '\x3', '\x1B', 
		'\x3', '\x1C', '\x3', '\x1C', '\a', '\x1C', '\x101', '\n', '\x1C', '\f', 
		'\x1C', '\xE', '\x1C', '\x104', '\v', '\x1C', '\x3', '\x1D', '\x3', '\x1D', 
		'\x3', '\x1E', '\x6', '\x1E', '\x109', '\n', '\x1E', '\r', '\x1E', '\xE', 
		'\x1E', '\x10A', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', '\x6', '\x1F', 
		'\x110', '\n', '\x1F', '\r', '\x1F', '\xE', '\x1F', '\x111', '\x3', '\x1F', 
		'\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\a', ' ', 
		'\x11A', '\n', ' ', '\f', ' ', '\xE', ' ', '\x11D', '\v', ' ', '\x3', 
		' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', '\x11B', '\x2', 
		'!', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', 
		'\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', 
		'-', '\x18', '/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', 
		'\x37', '\x1D', '\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x3', 
		'\x2', '\a', '\x3', '\x2', '\x32', ';', '\x4', '\x2', '\x43', '\\', '\x63', 
		'|', '\x3', '\x2', '\x43', '\\', '\x4', '\x2', '\f', '\f', '\xE', '\xF', 
		'\x5', '\x2', '\v', '\f', '\xE', '\xF', '\"', '\"', '\x2', '\x128', '\x2', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', '\x37', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', '\x2', 
		'\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', '\x3', '\x41', '\x3', '\x2', 
		'\x2', '\x2', '\x5', '\x43', '\x3', '\x2', '\x2', '\x2', '\a', '\x45', 
		'\x3', '\x2', '\x2', '\x2', '\t', 'G', '\x3', '\x2', '\x2', '\x2', '\v', 
		'I', '\x3', '\x2', '\x2', '\x2', '\r', 'K', '\x3', '\x2', '\x2', '\x2', 
		'\xF', 'M', '\x3', '\x2', '\x2', '\x2', '\x11', 'O', '\x3', '\x2', '\x2', 
		'\x2', '\x13', '^', '\x3', '\x2', '\x2', '\x2', '\x15', '`', '\x3', '\x2', 
		'\x2', '\x2', '\x17', '\x62', '\x3', '\x2', '\x2', '\x2', '\x19', 's', 
		'\x3', '\x2', '\x2', '\x2', '\x1B', '\x8C', '\x3', '\x2', '\x2', '\x2', 
		'\x1D', '\x8E', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x95', '\x3', '\x2', 
		'\x2', '\x2', '!', '\x97', '\x3', '\x2', '\x2', '\x2', '#', '\x99', '\x3', 
		'\x2', '\x2', '\x2', '%', '\xA5', '\x3', '\x2', '\x2', '\x2', '\'', '\xAC', 
		'\x3', '\x2', '\x2', '\x2', ')', '\xBD', '\x3', '\x2', '\x2', '\x2', '+', 
		'\xC7', '\x3', '\x2', '\x2', '\x2', '-', '\xD3', '\x3', '\x2', '\x2', 
		'\x2', '/', '\xDA', '\x3', '\x2', '\x2', '\x2', '\x31', '\xDD', '\x3', 
		'\x2', '\x2', '\x2', '\x33', '\xE7', '\x3', '\x2', '\x2', '\x2', '\x35', 
		'\xF5', '\x3', '\x2', '\x2', '\x2', '\x37', '\xFE', '\x3', '\x2', '\x2', 
		'\x2', '\x39', '\x105', '\x3', '\x2', '\x2', '\x2', ';', '\x108', '\x3', 
		'\x2', '\x2', '\x2', '=', '\x10F', '\x3', '\x2', '\x2', '\x2', '?', '\x115', 
		'\x3', '\x2', '\x2', '\x2', '\x41', '\x42', '\a', '*', '\x2', '\x2', '\x42', 
		'\x4', '\x3', '\x2', '\x2', '\x2', '\x43', '\x44', '\a', '.', '\x2', '\x2', 
		'\x44', '\x6', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', '\a', '+', 
		'\x2', '\x2', '\x46', '\b', '\x3', '\x2', '\x2', '\x2', 'G', 'H', '\a', 
		'=', '\x2', '\x2', 'H', '\n', '\x3', '\x2', '\x2', '\x2', 'I', 'J', '\a', 
		')', '\x2', '\x2', 'J', '\f', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\a', 
		'\x30', '\x2', '\x2', 'L', '\xE', '\x3', '\x2', '\x2', '\x2', 'M', 'N', 
		'\a', '?', '\x2', '\x2', 'N', '\x10', '\x3', '\x2', '\x2', '\x2', 'O', 
		'P', '\a', 'X', '\x2', '\x2', 'P', 'Q', '\a', 'k', '\x2', '\x2', 'Q', 
		'R', '\a', 'g', '\x2', '\x2', 'R', 'S', '\a', 'y', '\x2', '\x2', 'S', 
		'T', '\a', '\x46', '\x2', '\x2', 'T', 'U', '\a', 'g', '\x2', '\x2', 'U', 
		'V', '\a', 'h', '\x2', '\x2', 'V', 'W', '\a', 'k', '\x2', '\x2', 'W', 
		'X', '\a', 'p', '\x2', '\x2', 'X', 'Y', '\a', 'k', '\x2', '\x2', 'Y', 
		'Z', '\a', 'v', '\x2', '\x2', 'Z', '[', '\a', 'k', '\x2', '\x2', '[', 
		'\\', '\a', 'q', '\x2', '\x2', '\\', ']', '\a', 'p', '\x2', '\x2', ']', 
		'\x12', '\x3', '\x2', '\x2', '\x2', '^', '_', '\a', ']', '\x2', '\x2', 
		'_', '\x14', '\x3', '\x2', '\x2', '\x2', '`', '\x61', '\a', '_', '\x2', 
		'\x2', '\x61', '\x16', '\x3', '\x2', '\x2', '\x2', '\x62', '\x63', '\a', 
		'\x45', '\x2', '\x2', '\x63', '\x64', '\a', 'q', '\x2', '\x2', '\x64', 
		'\x65', '\a', 'q', '\x2', '\x2', '\x65', '\x66', '\a', 't', '\x2', '\x2', 
		'\x66', 'g', '\a', '\x66', '\x2', '\x2', 'g', 'h', '\a', 'k', '\x2', '\x2', 
		'h', 'i', '\a', 'p', '\x2', '\x2', 'i', 'j', '\a', '\x63', '\x2', '\x2', 
		'j', 'k', '\a', 'v', '\x2', '\x2', 'k', 'l', '\a', 'k', '\x2', '\x2', 
		'l', 'm', '\a', 'q', '\x2', '\x2', 'm', 'n', '\a', 'p', '\x2', '\x2', 
		'n', 'o', '\a', 'X', '\x2', '\x2', 'o', 'p', '\a', 'k', '\x2', '\x2', 
		'p', 'q', '\a', 'g', '\x2', '\x2', 'q', 'r', '\a', 'y', '\x2', '\x2', 
		'r', '\x18', '\x3', '\x2', '\x2', '\x2', 's', 't', '\a', 'S', '\x2', '\x2', 
		't', 'u', '\a', 'w', '\x2', '\x2', 'u', 'v', '\a', '\x63', '\x2', '\x2', 
		'v', 'w', '\a', 'p', '\x2', '\x2', 'w', 'x', '\a', 'v', '\x2', '\x2', 
		'x', 'y', '\a', 'k', '\x2', '\x2', 'y', 'z', '\a', 'v', '\x2', '\x2', 
		'z', '{', '\a', '{', '\x2', '\x2', '{', '|', '\a', 'V', '\x2', '\x2', 
		'|', '}', '\a', '\x63', '\x2', '\x2', '}', '~', '\a', 'm', '\x2', '\x2', 
		'~', '\x7F', '\a', 'g', '\x2', '\x2', '\x7F', '\x80', '\a', 'Q', '\x2', 
		'\x2', '\x80', '\x81', '\a', 'h', '\x2', '\x2', '\x81', '\x82', '\a', 
		'h', '\x2', '\x2', '\x82', '\x83', '\a', '\x43', '\x2', '\x2', '\x83', 
		'\x84', '\a', '\x66', '\x2', '\x2', '\x84', '\x85', '\a', '\x66', '\x2', 
		'\x2', '\x85', '\x86', '\a', 'Q', '\x2', '\x2', '\x86', '\x87', '\a', 
		'p', '\x2', '\x2', '\x87', '\x88', '\a', 'X', '\x2', '\x2', '\x88', '\x89', 
		'\a', 'k', '\x2', '\x2', '\x89', '\x8A', '\a', 'g', '\x2', '\x2', '\x8A', 
		'\x8B', '\a', 'y', '\x2', '\x2', '\x8B', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '\x8C', '\x8D', '\t', '\x2', '\x2', '\x2', '\x8D', '\x1C', '\x3', 
		'\x2', '\x2', '\x2', '\x8E', '\x92', '\x5', '\x1B', '\xE', '\x2', '\x8F', 
		'\x91', '\x5', '\x1B', '\xE', '\x2', '\x90', '\x8F', '\x3', '\x2', '\x2', 
		'\x2', '\x91', '\x94', '\x3', '\x2', '\x2', '\x2', '\x92', '\x90', '\x3', 
		'\x2', '\x2', '\x2', '\x92', '\x93', '\x3', '\x2', '\x2', '\x2', '\x93', 
		'\x1E', '\x3', '\x2', '\x2', '\x2', '\x94', '\x92', '\x3', '\x2', '\x2', 
		'\x2', '\x95', '\x96', '\t', '\x3', '\x2', '\x2', '\x96', ' ', '\x3', 
		'\x2', '\x2', '\x2', '\x97', '\x98', '\t', '\x4', '\x2', '\x2', '\x98', 
		'\"', '\x3', '\x2', '\x2', '\x2', '\x99', '\x9A', '\x5', '\x1D', '\xF', 
		'\x2', '\x9A', '\x9B', '\a', '/', '\x2', '\x2', '\x9B', '\x9C', '\x5', 
		'\x1D', '\xF', '\x2', '\x9C', '\x9D', '\a', '/', '\x2', '\x2', '\x9D', 
		'\x9E', '\x5', '\x1D', '\xF', '\x2', '\x9E', '\x9F', '\a', 'V', '\x2', 
		'\x2', '\x9F', '\xA0', '\x5', '\x1D', '\xF', '\x2', '\xA0', '\xA1', '\a', 
		'<', '\x2', '\x2', '\xA1', '\xA2', '\x5', '\x1D', '\xF', '\x2', '\xA2', 
		'\xA3', '\a', '<', '\x2', '\x2', '\xA3', '\xA4', '\x5', '\x1D', '\xF', 
		'\x2', '\xA4', '$', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA6', '\a', 
		'G', '\x2', '\x2', '\xA6', '\xA7', '\a', 'P', '\x2', '\x2', '\xA7', '\xA8', 
		'\a', '\x46', '\x2', '\x2', '\xA8', '\xA9', '\a', 'U', '\x2', '\x2', '\xA9', 
		'\xAA', '\a', 'G', '\x2', '\x2', '\xAA', '\xAB', '\a', '\x45', '\x2', 
		'\x2', '\xAB', '&', '\x3', '\x2', '\x2', '\x2', '\xAC', '\xAD', '\a', 
		'H', '\x2', '\x2', '\xAD', '\xAE', '\a', 'K', '\x2', '\x2', '\xAE', '\xAF', 
		'\a', 'N', '\x2', '\x2', '\xAF', '\xB0', '\a', 'G', '\x2', '\x2', '\xB0', 
		'\xB1', '\a', '\x61', '\x2', '\x2', '\xB1', '\xB2', '\a', '\x46', '\x2', 
		'\x2', '\xB2', '\xB3', '\a', 'G', '\x2', '\x2', '\xB3', '\xB4', '\a', 
		'U', '\x2', '\x2', '\xB4', '\xB5', '\a', '\x45', '\x2', '\x2', '\xB5', 
		'\xB6', '\a', 'T', '\x2', '\x2', '\xB6', '\xB7', '\a', 'K', '\x2', '\x2', 
		'\xB7', '\xB8', '\a', 'R', '\x2', '\x2', '\xB8', '\xB9', '\a', 'V', '\x2', 
		'\x2', '\xB9', '\xBA', '\a', 'K', '\x2', '\x2', '\xBA', '\xBB', '\a', 
		'Q', '\x2', '\x2', '\xBB', '\xBC', '\a', 'P', '\x2', '\x2', '\xBC', '(', 
		'\x3', '\x2', '\x2', '\x2', '\xBD', '\xBE', '\a', 'H', '\x2', '\x2', '\xBE', 
		'\xBF', '\a', 'K', '\x2', '\x2', '\xBF', '\xC0', '\a', 'N', '\x2', '\x2', 
		'\xC0', '\xC1', '\a', 'G', '\x2', '\x2', '\xC1', '\xC2', '\a', '\x61', 
		'\x2', '\x2', '\xC2', '\xC3', '\a', 'P', '\x2', '\x2', '\xC3', '\xC4', 
		'\a', '\x43', '\x2', '\x2', '\xC4', '\xC5', '\a', 'O', '\x2', '\x2', '\xC5', 
		'\xC6', '\a', 'G', '\x2', '\x2', '\xC6', '*', '\x3', '\x2', '\x2', '\x2', 
		'\xC7', '\xC8', '\a', 'H', '\x2', '\x2', '\xC8', '\xC9', '\a', 'K', '\x2', 
		'\x2', '\xC9', '\xCA', '\a', 'N', '\x2', '\x2', '\xCA', '\xCB', '\a', 
		'G', '\x2', '\x2', '\xCB', '\xCC', '\a', '\x61', '\x2', '\x2', '\xCC', 
		'\xCD', '\a', 'U', '\x2', '\x2', '\xCD', '\xCE', '\a', '\x45', '\x2', 
		'\x2', '\xCE', '\xCF', '\a', 'J', '\x2', '\x2', '\xCF', '\xD0', '\a', 
		'G', '\x2', '\x2', '\xD0', '\xD1', '\a', 'O', '\x2', '\x2', '\xD1', '\xD2', 
		'\a', '\x43', '\x2', '\x2', '\xD2', ',', '\x3', '\x2', '\x2', '\x2', '\xD3', 
		'\xD4', '\a', 'J', '\x2', '\x2', '\xD4', '\xD5', '\a', 'G', '\x2', '\x2', 
		'\xD5', '\xD6', '\a', '\x43', '\x2', '\x2', '\xD6', '\xD7', '\a', '\x46', 
		'\x2', '\x2', '\xD7', '\xD8', '\a', 'G', '\x2', '\x2', '\xD8', '\xD9', 
		'\a', 'T', '\x2', '\x2', '\xD9', '.', '\x3', '\x2', '\x2', '\x2', '\xDA', 
		'\xDB', '\a', '%', '\x2', '\x2', '\xDB', '\xDC', '\x5', '\x1D', '\xF', 
		'\x2', '\xDC', '\x30', '\x3', '\x2', '\x2', '\x2', '\xDD', '\xDE', '\a', 
		'K', '\x2', '\x2', '\xDE', '\xDF', '\a', 'U', '\x2', '\x2', '\xDF', '\xE0', 
		'\a', 'Q', '\x2', '\x2', '\xE0', '\xE1', '\x3', '\x2', '\x2', '\x2', '\xE1', 
		'\xE2', '\a', '/', '\x2', '\x2', '\xE2', '\xE3', '\x5', '\x1D', '\xF', 
		'\x2', '\xE3', '\xE4', '\a', '/', '\x2', '\x2', '\xE4', '\xE5', '\x5', 
		'\x1D', '\xF', '\x2', '\xE5', '\xE6', '\a', '=', '\x2', '\x2', '\xE6', 
		'\x32', '\x3', '\x2', '\x2', '\x2', '\xE7', '\xE8', '\a', 'G', '\x2', 
		'\x2', '\xE8', '\xE9', '\a', 'P', '\x2', '\x2', '\xE9', '\xEA', '\a', 
		'\x46', '\x2', '\x2', '\xEA', '\xEB', '\a', '/', '\x2', '\x2', '\xEB', 
		'\xEC', '\a', 'K', '\x2', '\x2', '\xEC', '\xED', '\a', 'U', '\x2', '\x2', 
		'\xED', '\xEE', '\a', 'Q', '\x2', '\x2', '\xEE', '\xEF', '\x3', '\x2', 
		'\x2', '\x2', '\xEF', '\xF0', '\a', '/', '\x2', '\x2', '\xF0', '\xF1', 
		'\x5', '\x1D', '\xF', '\x2', '\xF1', '\xF2', '\a', '/', '\x2', '\x2', 
		'\xF2', '\xF3', '\x5', '\x1D', '\xF', '\x2', '\xF3', '\xF4', '\a', '=', 
		'\x2', '\x2', '\xF4', '\x34', '\x3', '\x2', '\x2', '\x2', '\xF5', '\xF9', 
		'\a', '$', '\x2', '\x2', '\xF6', '\xF8', '\x5', '\x1F', '\x10', '\x2', 
		'\xF7', '\xF6', '\x3', '\x2', '\x2', '\x2', '\xF8', '\xFB', '\x3', '\x2', 
		'\x2', '\x2', '\xF9', '\xF7', '\x3', '\x2', '\x2', '\x2', '\xF9', '\xFA', 
		'\x3', '\x2', '\x2', '\x2', '\xFA', '\xFC', '\x3', '\x2', '\x2', '\x2', 
		'\xFB', '\xF9', '\x3', '\x2', '\x2', '\x2', '\xFC', '\xFD', '\a', '$', 
		'\x2', '\x2', '\xFD', '\x36', '\x3', '\x2', '\x2', '\x2', '\xFE', '\x102', 
		'\x5', '!', '\x11', '\x2', '\xFF', '\x101', '\x5', '!', '\x11', '\x2', 
		'\x100', '\xFF', '\x3', '\x2', '\x2', '\x2', '\x101', '\x104', '\x3', 
		'\x2', '\x2', '\x2', '\x102', '\x100', '\x3', '\x2', '\x2', '\x2', '\x102', 
		'\x103', '\x3', '\x2', '\x2', '\x2', '\x103', '\x38', '\x3', '\x2', '\x2', 
		'\x2', '\x104', '\x102', '\x3', '\x2', '\x2', '\x2', '\x105', '\x106', 
		'\a', '&', '\x2', '\x2', '\x106', ':', '\x3', '\x2', '\x2', '\x2', '\x107', 
		'\x109', '\t', '\x5', '\x2', '\x2', '\x108', '\x107', '\x3', '\x2', '\x2', 
		'\x2', '\x109', '\x10A', '\x3', '\x2', '\x2', '\x2', '\x10A', '\x108', 
		'\x3', '\x2', '\x2', '\x2', '\x10A', '\x10B', '\x3', '\x2', '\x2', '\x2', 
		'\x10B', '\x10C', '\x3', '\x2', '\x2', '\x2', '\x10C', '\x10D', '\b', 
		'\x1E', '\x2', '\x2', '\x10D', '<', '\x3', '\x2', '\x2', '\x2', '\x10E', 
		'\x110', '\t', '\x6', '\x2', '\x2', '\x10F', '\x10E', '\x3', '\x2', '\x2', 
		'\x2', '\x110', '\x111', '\x3', '\x2', '\x2', '\x2', '\x111', '\x10F', 
		'\x3', '\x2', '\x2', '\x2', '\x111', '\x112', '\x3', '\x2', '\x2', '\x2', 
		'\x112', '\x113', '\x3', '\x2', '\x2', '\x2', '\x113', '\x114', '\b', 
		'\x1F', '\x2', '\x2', '\x114', '>', '\x3', '\x2', '\x2', '\x2', '\x115', 
		'\x116', '\a', '\x31', '\x2', '\x2', '\x116', '\x117', '\a', ',', '\x2', 
		'\x2', '\x117', '\x11B', '\x3', '\x2', '\x2', '\x2', '\x118', '\x11A', 
		'\v', '\x2', '\x2', '\x2', '\x119', '\x118', '\x3', '\x2', '\x2', '\x2', 
		'\x11A', '\x11D', '\x3', '\x2', '\x2', '\x2', '\x11B', '\x11C', '\x3', 
		'\x2', '\x2', '\x2', '\x11B', '\x119', '\x3', '\x2', '\x2', '\x2', '\x11C', 
		'\x11E', '\x3', '\x2', '\x2', '\x2', '\x11D', '\x11B', '\x3', '\x2', '\x2', 
		'\x2', '\x11E', '\x11F', '\a', ',', '\x2', '\x2', '\x11F', '\x120', '\a', 
		'\x31', '\x2', '\x2', '\x120', '\x121', '\x3', '\x2', '\x2', '\x2', '\x121', 
		'\x122', '\b', ' ', '\x2', '\x2', '\x122', '@', '\x3', '\x2', '\x2', '\x2', 
		'\t', '\x2', '\x92', '\xF9', '\x102', '\x10A', '\x111', '\x11B', '\x3', 
		'\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace STEP
