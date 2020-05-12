<a name='assembly'></a>
# BBS.Parser

## Contents

- [BBSCodeParserBaseListener](#T-Casasoft-BBS-Parser-BBSCodeParserBaseListener 'Casasoft.BBS.Parser.BBSCodeParserBaseListener')
  - [EnterBbsCodeAttribute(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeAttribute-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.EnterBbsCodeAttribute(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext)')
  - [EnterBbsCodeAttributeName(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeAttributeName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeNameContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.EnterBbsCodeAttributeName(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeNameContext)')
  - [EnterBbsCodeAttributeValue(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeAttributeValue-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeValueContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.EnterBbsCodeAttributeValue(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeValueContext)')
  - [EnterBbsCodeChardata(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeChardata-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.EnterBbsCodeChardata(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext)')
  - [EnterBbsCodeContent(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeContent-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeContentContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.EnterBbsCodeContent(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeContentContext)')
  - [EnterBbsCodeElement(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeElement-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.EnterBbsCodeElement(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext)')
  - [EnterBbsCodeEntity(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeEntity-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.EnterBbsCodeEntity(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext)')
  - [EnterBbsCodeTagName(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeTagName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeTagNameContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.EnterBbsCodeTagName(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeTagNameContext)')
  - [EnterEveryRule()](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterEveryRule-Antlr4-Runtime-ParserRuleContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.EnterEveryRule(Antlr4.Runtime.ParserRuleContext)')
  - [ExitBbsCodeAttribute(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeAttribute-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.ExitBbsCodeAttribute(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext)')
  - [ExitBbsCodeAttributeName(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeAttributeName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeNameContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.ExitBbsCodeAttributeName(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeNameContext)')
  - [ExitBbsCodeAttributeValue(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeAttributeValue-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeValueContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.ExitBbsCodeAttributeValue(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeValueContext)')
  - [ExitBbsCodeChardata(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeChardata-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.ExitBbsCodeChardata(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext)')
  - [ExitBbsCodeContent(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeContent-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeContentContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.ExitBbsCodeContent(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeContentContext)')
  - [ExitBbsCodeElement(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeElement-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.ExitBbsCodeElement(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext)')
  - [ExitBbsCodeEntity(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeEntity-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.ExitBbsCodeEntity(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext)')
  - [ExitBbsCodeTagName(context)](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeTagName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeTagNameContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.ExitBbsCodeTagName(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeTagNameContext)')
  - [ExitEveryRule()](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitEveryRule-Antlr4-Runtime-ParserRuleContext- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.ExitEveryRule(Antlr4.Runtime.ParserRuleContext)')
  - [VisitErrorNode()](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-VisitErrorNode-Antlr4-Runtime-Tree-IErrorNode- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.VisitErrorNode(Antlr4.Runtime.Tree.IErrorNode)')
  - [VisitTerminal()](#M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-VisitTerminal-Antlr4-Runtime-Tree-ITerminalNode- 'Casasoft.BBS.Parser.BBSCodeParserBaseListener.VisitTerminal(Antlr4.Runtime.Tree.ITerminalNode)')
- [BBSCodeTranslator](#T-Casasoft-BBS-Parser-BBSCodeTranslator 'Casasoft.BBS.Parser.BBSCodeTranslator')
  - [#ctor(c,s)](#M-Casasoft-BBS-Parser-BBSCodeTranslator-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.Parser.BBSCodeTranslator.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [GetProcessed(FileName)](#M-Casasoft-BBS-Parser-BBSCodeTranslator-GetProcessed-System-String- 'Casasoft.BBS.Parser.BBSCodeTranslator.GetProcessed(System.String)')
- [IBBSCodeParserListener](#T-Casasoft-BBS-Parser-IBBSCodeParserListener 'Casasoft.BBS.Parser.IBBSCodeParserListener')
  - [EnterBbsCodeAttribute(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeAttribute-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.EnterBbsCodeAttribute(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext)')
  - [EnterBbsCodeAttributeName(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeAttributeName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeNameContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.EnterBbsCodeAttributeName(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeNameContext)')
  - [EnterBbsCodeAttributeValue(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeAttributeValue-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeValueContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.EnterBbsCodeAttributeValue(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeValueContext)')
  - [EnterBbsCodeChardata(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeChardata-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.EnterBbsCodeChardata(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext)')
  - [EnterBbsCodeContent(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeContent-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeContentContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.EnterBbsCodeContent(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeContentContext)')
  - [EnterBbsCodeElement(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeElement-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.EnterBbsCodeElement(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext)')
  - [EnterBbsCodeEntity(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeEntity-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.EnterBbsCodeEntity(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext)')
  - [EnterBbsCodeTagName(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeTagName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeTagNameContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.EnterBbsCodeTagName(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeTagNameContext)')
  - [ExitBbsCodeAttribute(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeAttribute-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.ExitBbsCodeAttribute(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext)')
  - [ExitBbsCodeAttributeName(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeAttributeName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeNameContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.ExitBbsCodeAttributeName(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeNameContext)')
  - [ExitBbsCodeAttributeValue(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeAttributeValue-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeValueContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.ExitBbsCodeAttributeValue(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeValueContext)')
  - [ExitBbsCodeChardata(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeChardata-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.ExitBbsCodeChardata(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext)')
  - [ExitBbsCodeContent(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeContent-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeContentContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.ExitBbsCodeContent(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeContentContext)')
  - [ExitBbsCodeElement(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeElement-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.ExitBbsCodeElement(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext)')
  - [ExitBbsCodeEntity(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeEntity-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.ExitBbsCodeEntity(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext)')
  - [ExitBbsCodeTagName(context)](#M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeTagName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeTagNameContext- 'Casasoft.BBS.Parser.IBBSCodeParserListener.ExitBbsCodeTagName(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeTagNameContext)')

<a name='T-Casasoft-BBS-Parser-BBSCodeParserBaseListener'></a>
## BBSCodeParserBaseListener `type`

##### Namespace

Casasoft.BBS.Parser

##### Summary

This class provides an empty implementation of [IBBSCodeParserListener](#T-Casasoft-BBS-Parser-IBBSCodeParserListener 'Casasoft.BBS.Parser.IBBSCodeParserListener'),
which can be extended to create a listener which only needs to handle a subset
of the available methods.

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeAttribute-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext-'></a>
### EnterBbsCodeAttribute(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeAttribute](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeAttribute 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeAttribute').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeAttributeName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeNameContext-'></a>
### EnterBbsCodeAttributeName(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeAttributeName](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeAttributeName 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeAttributeName').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeNameContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeNameContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeNameContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeAttributeValue-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeValueContext-'></a>
### EnterBbsCodeAttributeValue(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeAttributeValue](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeAttributeValue 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeAttributeValue').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeValueContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeValueContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeValueContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeChardata-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext-'></a>
### EnterBbsCodeChardata(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeChardata](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeChardata 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeChardata').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeContent-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeContentContext-'></a>
### EnterBbsCodeContent(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeContent](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeContent 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeContent').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeContentContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeContentContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeContentContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeElement-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext-'></a>
### EnterBbsCodeElement(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeElement](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeElement 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeElement').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeEntity-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext-'></a>
### EnterBbsCodeEntity(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeEntity](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeEntity 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeEntity').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterBbsCodeTagName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeTagNameContext-'></a>
### EnterBbsCodeTagName(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeTagName](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeTagName 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeTagName').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeTagNameContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeTagNameContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeTagNameContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-EnterEveryRule-Antlr4-Runtime-ParserRuleContext-'></a>
### EnterEveryRule() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Remarks

The default implementation does nothing.

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeAttribute-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext-'></a>
### ExitBbsCodeAttribute(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeAttribute](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeAttribute 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeAttribute').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeAttributeName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeNameContext-'></a>
### ExitBbsCodeAttributeName(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeAttributeName](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeAttributeName 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeAttributeName').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeNameContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeNameContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeNameContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeAttributeValue-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeValueContext-'></a>
### ExitBbsCodeAttributeValue(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeAttributeValue](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeAttributeValue 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeAttributeValue').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeValueContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeValueContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeValueContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeChardata-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext-'></a>
### ExitBbsCodeChardata(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeChardata](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeChardata 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeChardata').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeContent-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeContentContext-'></a>
### ExitBbsCodeContent(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeContent](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeContent 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeContent').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeContentContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeContentContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeContentContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeElement-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext-'></a>
### ExitBbsCodeElement(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeElement](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeElement 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeElement').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeEntity-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext-'></a>
### ExitBbsCodeEntity(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeEntity](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeEntity 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeEntity').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitBbsCodeTagName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeTagNameContext-'></a>
### ExitBbsCodeTagName(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeTagName](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeTagName 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeTagName').

The default implementation does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeTagNameContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeTagNameContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeTagNameContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-ExitEveryRule-Antlr4-Runtime-ParserRuleContext-'></a>
### ExitEveryRule() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Remarks

The default implementation does nothing.

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-VisitErrorNode-Antlr4-Runtime-Tree-IErrorNode-'></a>
### VisitErrorNode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Remarks

The default implementation does nothing.

<a name='M-Casasoft-BBS-Parser-BBSCodeParserBaseListener-VisitTerminal-Antlr4-Runtime-Tree-ITerminalNode-'></a>
### VisitTerminal() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Remarks

The default implementation does nothing.

<a name='T-Casasoft-BBS-Parser-BBSCodeTranslator'></a>
## BBSCodeTranslator `type`

##### Namespace

Casasoft.BBS.Parser

##### Summary

Handles parsing of BBScode

<a name='M-Casasoft-BBS-Parser-BBSCodeTranslator-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Reference to the client |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Reference to the server |

<a name='M-Casasoft-BBS-Parser-BBSCodeTranslator-GetProcessed-System-String-'></a>
### GetProcessed(FileName) `method`

##### Summary

Process the file

##### Returns

[BBSCodeResult](#T-Casasoft-BBS-Parser-BBSCodeResult 'Casasoft.BBS.Parser.BBSCodeResult') with processed data

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| FileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File to parse |

<a name='T-Casasoft-BBS-Parser-IBBSCodeParserListener'></a>
## IBBSCodeParserListener `type`

##### Namespace

Casasoft.BBS.Parser

##### Summary

This interface defines a complete listener for a parse tree produced by
[BBSCodeParser](#T-Casasoft-BBS-Parser-BBSCodeParser 'Casasoft.BBS.Parser.BBSCodeParser').

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeAttribute-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext-'></a>
### EnterBbsCodeAttribute(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeAttribute](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeAttribute 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeAttribute').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeAttributeName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeNameContext-'></a>
### EnterBbsCodeAttributeName(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeAttributeName](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeAttributeName 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeAttributeName').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeNameContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeNameContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeNameContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeAttributeValue-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeValueContext-'></a>
### EnterBbsCodeAttributeValue(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeAttributeValue](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeAttributeValue 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeAttributeValue').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeValueContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeValueContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeValueContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeChardata-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext-'></a>
### EnterBbsCodeChardata(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeChardata](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeChardata 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeChardata').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeContent-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeContentContext-'></a>
### EnterBbsCodeContent(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeContent](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeContent 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeContent').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeContentContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeContentContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeContentContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeElement-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext-'></a>
### EnterBbsCodeElement(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeElement](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeElement 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeElement').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeEntity-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext-'></a>
### EnterBbsCodeEntity(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeEntity](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeEntity 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeEntity').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-EnterBbsCodeTagName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeTagNameContext-'></a>
### EnterBbsCodeTagName(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeTagName](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeTagName 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeTagName').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeTagNameContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeTagNameContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeTagNameContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeAttribute-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext-'></a>
### ExitBbsCodeAttribute(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeAttribute](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeAttribute 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeAttribute').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeAttributeName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeNameContext-'></a>
### ExitBbsCodeAttributeName(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeAttributeName](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeAttributeName 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeAttributeName').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeNameContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeNameContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeNameContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeAttributeValue-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeValueContext-'></a>
### ExitBbsCodeAttributeValue(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeAttributeValue](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeAttributeValue 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeAttributeValue').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeValueContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeValueContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeValueContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeChardata-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext-'></a>
### ExitBbsCodeChardata(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeChardata](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeChardata 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeChardata').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeContent-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeContentContext-'></a>
### ExitBbsCodeContent(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeContent](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeContent 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeContent').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeContentContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeContentContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeContentContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeElement-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext-'></a>
### ExitBbsCodeElement(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeElement](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeElement 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeElement').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeEntity-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext-'></a>
### ExitBbsCodeEntity(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeEntity](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeEntity 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeEntity').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-IBBSCodeParserListener-ExitBbsCodeTagName-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeTagNameContext-'></a>
### ExitBbsCodeTagName(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeTagName](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeTagName 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeTagName').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeTagNameContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeTagNameContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeTagNameContext') | The parse tree. |
