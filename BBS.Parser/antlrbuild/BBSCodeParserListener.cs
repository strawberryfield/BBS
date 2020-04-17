//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from grammar/BBSCodeParser.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Casasoft.BBS.Parser {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="BBSCodeParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IBBSCodeParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="BBSCodeParser.bbsCodeEntity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBbsCodeEntity([NotNull] BBSCodeParser.BbsCodeEntityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BBSCodeParser.bbsCodeEntity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBbsCodeEntity([NotNull] BBSCodeParser.BbsCodeEntityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BBSCodeParser.bbsCodeElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBbsCodeElement([NotNull] BBSCodeParser.BbsCodeElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BBSCodeParser.bbsCodeElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBbsCodeElement([NotNull] BBSCodeParser.BbsCodeElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BBSCodeParser.bbsCodeContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBbsCodeContent([NotNull] BBSCodeParser.BbsCodeContentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BBSCodeParser.bbsCodeContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBbsCodeContent([NotNull] BBSCodeParser.BbsCodeContentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BBSCodeParser.bbsCodeAttribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBbsCodeAttribute([NotNull] BBSCodeParser.BbsCodeAttributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BBSCodeParser.bbsCodeAttribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBbsCodeAttribute([NotNull] BBSCodeParser.BbsCodeAttributeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BBSCodeParser.bbsCodeAttributeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBbsCodeAttributeName([NotNull] BBSCodeParser.BbsCodeAttributeNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BBSCodeParser.bbsCodeAttributeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBbsCodeAttributeName([NotNull] BBSCodeParser.BbsCodeAttributeNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BBSCodeParser.bbsCodeAttributeValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBbsCodeAttributeValue([NotNull] BBSCodeParser.BbsCodeAttributeValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BBSCodeParser.bbsCodeAttributeValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBbsCodeAttributeValue([NotNull] BBSCodeParser.BbsCodeAttributeValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BBSCodeParser.bbsCodeTagName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBbsCodeTagName([NotNull] BBSCodeParser.BbsCodeTagNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BBSCodeParser.bbsCodeTagName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBbsCodeTagName([NotNull] BBSCodeParser.BbsCodeTagNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BBSCodeParser.bbsCodeChardata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBbsCodeChardata([NotNull] BBSCodeParser.BbsCodeChardataContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BBSCodeParser.bbsCodeChardata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBbsCodeChardata([NotNull] BBSCodeParser.BbsCodeChardataContext context);
}
} // namespace Casasoft.BBS.Parser
