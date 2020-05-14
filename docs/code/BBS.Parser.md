<a name='assembly'></a>
# BBS.Parser

## Contents

- [Attributes](#T-Casasoft-BBS-Parser-Attributes 'Casasoft.BBS.Parser.Attributes')
  - [#ctor()](#M-Casasoft-BBS-Parser-Attributes-#ctor 'Casasoft.BBS.Parser.Attributes.#ctor')
  - [TryAdd(attrName,attrValue)](#M-Casasoft-BBS-Parser-Attributes-TryAdd-System-String,System-String- 'Casasoft.BBS.Parser.Attributes.TryAdd(System.String,System.String)')
  - [TryGetValue(attrName,attrValue)](#M-Casasoft-BBS-Parser-Attributes-TryGetValue-System-String,System-String@- 'Casasoft.BBS.Parser.Attributes.TryGetValue(System.String,System.String@)')
- [AttributesDict](#T-Casasoft-BBS-Parser-AttributesDict 'Casasoft.BBS.Parser.AttributesDict')
  - [#ctor()](#M-Casasoft-BBS-Parser-AttributesDict-#ctor 'Casasoft.BBS.Parser.AttributesDict.#ctor')
  - [Add(tag,attrName,attrValue)](#M-Casasoft-BBS-Parser-AttributesDict-Add-Casasoft-BBS-Parser-Tags,System-String,System-String- 'Casasoft.BBS.Parser.AttributesDict.Add(Casasoft.BBS.Parser.Tags,System.String,System.String)')
  - [GetAttributes(tag)](#M-Casasoft-BBS-Parser-AttributesDict-GetAttributes-Casasoft-BBS-Parser-Tags- 'Casasoft.BBS.Parser.AttributesDict.GetAttributes(Casasoft.BBS.Parser.Tags)')
- [BBSCodeListener](#T-Casasoft-BBS-Parser-BBSCodeListener 'Casasoft.BBS.Parser.BBSCodeListener')
  - [#ctor(c,s,filename)](#M-Casasoft-BBS-Parser-BBSCodeListener-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.Parser.BBSCodeListener.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [Parsed](#P-Casasoft-BBS-Parser-BBSCodeListener-Parsed 'Casasoft.BBS.Parser.BBSCodeListener.Parsed')
  - [EnterBbsCodeAttribute(context)](#M-Casasoft-BBS-Parser-BBSCodeListener-EnterBbsCodeAttribute-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext- 'Casasoft.BBS.Parser.BBSCodeListener.EnterBbsCodeAttribute(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext)')
  - [EnterBbsCodeChardata(context)](#M-Casasoft-BBS-Parser-BBSCodeListener-EnterBbsCodeChardata-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext- 'Casasoft.BBS.Parser.BBSCodeListener.EnterBbsCodeChardata(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext)')
  - [EnterBbsCodeElement(context)](#M-Casasoft-BBS-Parser-BBSCodeListener-EnterBbsCodeElement-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext- 'Casasoft.BBS.Parser.BBSCodeListener.EnterBbsCodeElement(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext)')
  - [EnterBbsCodeEntity(context)](#M-Casasoft-BBS-Parser-BBSCodeListener-EnterBbsCodeEntity-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext- 'Casasoft.BBS.Parser.BBSCodeListener.EnterBbsCodeEntity(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext)')
  - [ExitBbsCodeElement(context)](#M-Casasoft-BBS-Parser-BBSCodeListener-ExitBbsCodeElement-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext- 'Casasoft.BBS.Parser.BBSCodeListener.ExitBbsCodeElement(Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext)')
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
- [Entities](#T-Casasoft-BBS-Parser-Entities 'Casasoft.BBS.Parser.Entities')
  - [AGRAVE](#F-Casasoft-BBS-Parser-Entities-AGRAVE 'Casasoft.BBS.Parser.Entities.AGRAVE')
  - [AMP](#F-Casasoft-BBS-Parser-Entities-AMP 'Casasoft.BBS.Parser.Entities.AMP')
  - [CONNECTIONTIME](#F-Casasoft-BBS-Parser-Entities-CONNECTIONTIME 'Casasoft.BBS.Parser.Entities.CONNECTIONTIME')
  - [EACUTE](#F-Casasoft-BBS-Parser-Entities-EACUTE 'Casasoft.BBS.Parser.Entities.EACUTE')
  - [EGRAVE](#F-Casasoft-BBS-Parser-Entities-EGRAVE 'Casasoft.BBS.Parser.Entities.EGRAVE')
  - [IGRAVE](#F-Casasoft-BBS-Parser-Entities-IGRAVE 'Casasoft.BBS.Parser.Entities.IGRAVE')
  - [LEFTCURLY](#F-Casasoft-BBS-Parser-Entities-LEFTCURLY 'Casasoft.BBS.Parser.Entities.LEFTCURLY')
  - [OGRAVE](#F-Casasoft-BBS-Parser-Entities-OGRAVE 'Casasoft.BBS.Parser.Entities.OGRAVE')
  - [REMOTE](#F-Casasoft-BBS-Parser-Entities-REMOTE 'Casasoft.BBS.Parser.Entities.REMOTE')
  - [RIGHTCURLY](#F-Casasoft-BBS-Parser-Entities-RIGHTCURLY 'Casasoft.BBS.Parser.Entities.RIGHTCURLY')
  - [SCREENHEIGHT](#F-Casasoft-BBS-Parser-Entities-SCREENHEIGHT 'Casasoft.BBS.Parser.Entities.SCREENHEIGHT')
  - [SCREENWIDTH](#F-Casasoft-BBS-Parser-Entities-SCREENWIDTH 'Casasoft.BBS.Parser.Entities.SCREENWIDTH')
  - [TERMINALTYPE](#F-Casasoft-BBS-Parser-Entities-TERMINALTYPE 'Casasoft.BBS.Parser.Entities.TERMINALTYPE')
  - [UGRAVE](#F-Casasoft-BBS-Parser-Entities-UGRAVE 'Casasoft.BBS.Parser.Entities.UGRAVE')
  - [USERNAME](#F-Casasoft-BBS-Parser-Entities-USERNAME 'Casasoft.BBS.Parser.Entities.USERNAME')
- [EntitiesDict](#T-Casasoft-BBS-Parser-EntitiesDict 'Casasoft.BBS.Parser.EntitiesDict')
  - [#ctor(c)](#M-Casasoft-BBS-Parser-EntitiesDict-#ctor-Casasoft-BBS-Interfaces-IBBSClient- 'Casasoft.BBS.Parser.EntitiesDict.#ctor(Casasoft.BBS.Interfaces.IBBSClient)')
  - [GetValue(name)](#M-Casasoft-BBS-Parser-EntitiesDict-GetValue-System-String- 'Casasoft.BBS.Parser.EntitiesDict.GetValue(System.String)')
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
- [Tags](#T-Casasoft-BBS-Parser-Tags 'Casasoft.BBS.Parser.Tags')
  - [ACTION](#F-Casasoft-BBS-Parser-Tags-ACTION 'Casasoft.BBS.Parser.Tags.ACTION')
  - [BACKCOLOR](#F-Casasoft-BBS-Parser-Tags-BACKCOLOR 'Casasoft.BBS.Parser.Tags.BACKCOLOR')
  - [BEEP](#F-Casasoft-BBS-Parser-Tags-BEEP 'Casasoft.BBS.Parser.Tags.BEEP')
  - [BLINK](#F-Casasoft-BBS-Parser-Tags-BLINK 'Casasoft.BBS.Parser.Tags.BLINK')
  - [BODY](#F-Casasoft-BBS-Parser-Tags-BODY 'Casasoft.BBS.Parser.Tags.BODY')
  - [BOLD](#F-Casasoft-BBS-Parser-Tags-BOLD 'Casasoft.BBS.Parser.Tags.BOLD')
  - [CLS](#F-Casasoft-BBS-Parser-Tags-CLS 'Casasoft.BBS.Parser.Tags.CLS')
  - [COLOR](#F-Casasoft-BBS-Parser-Tags-COLOR 'Casasoft.BBS.Parser.Tags.COLOR')
  - [FIGGLE](#F-Casasoft-BBS-Parser-Tags-FIGGLE 'Casasoft.BBS.Parser.Tags.FIGGLE')
  - [FOOTER](#F-Casasoft-BBS-Parser-Tags-FOOTER 'Casasoft.BBS.Parser.Tags.FOOTER')
  - [HEADER](#F-Casasoft-BBS-Parser-Tags-HEADER 'Casasoft.BBS.Parser.Tags.HEADER')
  - [HIDDEN](#F-Casasoft-BBS-Parser-Tags-HIDDEN 'Casasoft.BBS.Parser.Tags.HIDDEN')
  - [HR](#F-Casasoft-BBS-Parser-Tags-HR 'Casasoft.BBS.Parser.Tags.HR')
  - [MOVE](#F-Casasoft-BBS-Parser-Tags-MOVE 'Casasoft.BBS.Parser.Tags.MOVE')
  - [P](#F-Casasoft-BBS-Parser-Tags-P 'Casasoft.BBS.Parser.Tags.P')
  - [REVERSE](#F-Casasoft-BBS-Parser-Tags-REVERSE 'Casasoft.BBS.Parser.Tags.REVERSE')
  - [UNDERLINE](#F-Casasoft-BBS-Parser-Tags-UNDERLINE 'Casasoft.BBS.Parser.Tags.UNDERLINE')
- [TagsDict](#T-Casasoft-BBS-Parser-TagsDict 'Casasoft.BBS.Parser.TagsDict')
  - [#ctor()](#M-Casasoft-BBS-Parser-TagsDict-#ctor 'Casasoft.BBS.Parser.TagsDict.#ctor')
  - [TryGetValue(tagname,tag)](#M-Casasoft-BBS-Parser-TagsDict-TryGetValue-System-String,Casasoft-BBS-Parser-Tags@- 'Casasoft.BBS.Parser.TagsDict.TryGetValue(System.String,Casasoft.BBS.Parser.Tags@)')

<a name='T-Casasoft-BBS-Parser-Attributes'></a>
## Attributes `type`

##### Namespace

Casasoft.BBS.Parser

##### Summary

List of attributes of a tag

<a name='M-Casasoft-BBS-Parser-Attributes-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='M-Casasoft-BBS-Parser-Attributes-TryAdd-System-String,System-String-'></a>
### TryAdd(attrName,attrValue) `method`

##### Summary

Tries to add a value to the dictionary

##### Returns

true if add is successful

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| attrName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | attribute name |
| attrValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | attribute value |

<a name='M-Casasoft-BBS-Parser-Attributes-TryGetValue-System-String,System-String@-'></a>
### TryGetValue(attrName,attrValue) `method`

##### Summary

Tries to get a value from the dictionary

##### Returns

true if get is successful

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| attrName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | attribute name |
| attrValue | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') | returned value |

<a name='T-Casasoft-BBS-Parser-AttributesDict'></a>
## AttributesDict `type`

##### Namespace

Casasoft.BBS.Parser

##### Summary

Attributes lists for every tag

<a name='M-Casasoft-BBS-Parser-AttributesDict-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='M-Casasoft-BBS-Parser-AttributesDict-Add-Casasoft-BBS-Parser-Tags,System-String,System-String-'></a>
### Add(tag,attrName,attrValue) `method`

##### Summary

Adds an attribute for a tag

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tag | [Casasoft.BBS.Parser.Tags](#T-Casasoft-BBS-Parser-Tags 'Casasoft.BBS.Parser.Tags') |  |
| attrName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | attribute name |
| attrValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | attribute value |

<a name='M-Casasoft-BBS-Parser-AttributesDict-GetAttributes-Casasoft-BBS-Parser-Tags-'></a>
### GetAttributes(tag) `method`

##### Summary

Gets the attributes list for a tag

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tag | [Casasoft.BBS.Parser.Tags](#T-Casasoft-BBS-Parser-Tags 'Casasoft.BBS.Parser.Tags') |  |

##### Remarks

The returned list is removed from the dictionary

<a name='T-Casasoft-BBS-Parser-BBSCodeListener'></a>
## BBSCodeListener `type`

##### Namespace

Casasoft.BBS.Parser

##### Summary

This class provides the implementation of [IBBSCodeParserListener](#T-Casasoft-BBS-Parser-IBBSCodeParserListener 'Casasoft.BBS.Parser.IBBSCodeParserListener'),

<a name='M-Casasoft-BBS-Parser-BBSCodeListener-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,filename) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Reference to the client |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Reference to the server |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the parsed file |

<a name='P-Casasoft-BBS-Parser-BBSCodeListener-Parsed'></a>
### Parsed `property`

##### Summary

The processed data

<a name='M-Casasoft-BBS-Parser-BBSCodeListener-EnterBbsCodeAttribute-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext-'></a>
### EnterBbsCodeAttribute(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeAttribute](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeAttribute 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeAttribute').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeAttributeContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeAttributeContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeListener-EnterBbsCodeChardata-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext-'></a>
### EnterBbsCodeChardata(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeChardata](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeChardata 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeChardata').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeChardataContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeChardataContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeListener-EnterBbsCodeElement-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext-'></a>
### EnterBbsCodeElement(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeElement](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeElement 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeElement').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeListener-EnterBbsCodeEntity-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext-'></a>
### EnterBbsCodeEntity(context) `method`

##### Summary

Enter a parse tree produced by [bbsCodeEntity](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeEntity 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeEntity').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeEntityContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeEntityContext') | The parse tree. |

<a name='M-Casasoft-BBS-Parser-BBSCodeListener-ExitBbsCodeElement-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext-'></a>
### ExitBbsCodeElement(context) `method`

##### Summary

Exit a parse tree produced by [bbsCodeElement](#M-Casasoft-BBS-Parser-BBSCodeParser-bbsCodeElement 'Casasoft.BBS.Parser.BBSCodeParser.bbsCodeElement').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext](#T-Casasoft-BBS-Parser-BBSCodeParser-BbsCodeElementContext 'Casasoft.BBS.Parser.BBSCodeParser.BbsCodeElementContext') | The parse tree. |

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

<a name='T-Casasoft-BBS-Parser-Entities'></a>
## Entities `type`

##### Namespace

Casasoft.BBS.Parser

##### Summary

Available tags

<a name='F-Casasoft-BBS-Parser-Entities-AGRAVE'></a>
### AGRAVE `constants`

##### Summary

a with grave accent

<a name='F-Casasoft-BBS-Parser-Entities-AMP'></a>
### AMP `constants`

##### Summary

Ampersand

<a name='F-Casasoft-BBS-Parser-Entities-CONNECTIONTIME'></a>
### CONNECTIONTIME `constants`

##### Summary

date and time of client connection

<a name='F-Casasoft-BBS-Parser-Entities-EACUTE'></a>
### EACUTE `constants`

##### Summary

e with acute accent

<a name='F-Casasoft-BBS-Parser-Entities-EGRAVE'></a>
### EGRAVE `constants`

##### Summary

e with grave accent

<a name='F-Casasoft-BBS-Parser-Entities-IGRAVE'></a>
### IGRAVE `constants`

##### Summary

i with grave accent

<a name='F-Casasoft-BBS-Parser-Entities-LEFTCURLY'></a>
### LEFTCURLY `constants`

##### Summary

Left curly bracket

<a name='F-Casasoft-BBS-Parser-Entities-OGRAVE'></a>
### OGRAVE `constants`

##### Summary

o with grave accent

<a name='F-Casasoft-BBS-Parser-Entities-REMOTE'></a>
### REMOTE `constants`

##### Summary

Remote ip address

<a name='F-Casasoft-BBS-Parser-Entities-RIGHTCURLY'></a>
### RIGHTCURLY `constants`

##### Summary

Right curly bracket

<a name='F-Casasoft-BBS-Parser-Entities-SCREENHEIGHT'></a>
### SCREENHEIGHT `constants`

##### Summary

Rows in the terminal

<a name='F-Casasoft-BBS-Parser-Entities-SCREENWIDTH'></a>
### SCREENWIDTH `constants`

##### Summary

Columns in the terminal

<a name='F-Casasoft-BBS-Parser-Entities-TERMINALTYPE'></a>
### TERMINALTYPE `constants`

##### Summary

Terminal type id

<a name='F-Casasoft-BBS-Parser-Entities-UGRAVE'></a>
### UGRAVE `constants`

##### Summary

u with grave accent

<a name='F-Casasoft-BBS-Parser-Entities-USERNAME'></a>
### USERNAME `constants`

##### Summary

Username

<a name='T-Casasoft-BBS-Parser-EntitiesDict'></a>
## EntitiesDict `type`

##### Namespace

Casasoft.BBS.Parser

##### Summary

List of available entities

<a name='M-Casasoft-BBS-Parser-EntitiesDict-#ctor-Casasoft-BBS-Interfaces-IBBSClient-'></a>
### #ctor(c) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Reference to the client |

<a name='M-Casasoft-BBS-Parser-EntitiesDict-GetValue-System-String-'></a>
### GetValue(name) `method`

##### Summary

Gets entity value by name

##### Returns

string.Empty if the name is not found

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

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

<a name='T-Casasoft-BBS-Parser-Tags'></a>
## Tags `type`

##### Namespace

Casasoft.BBS.Parser

##### Summary

Available tags

<a name='F-Casasoft-BBS-Parser-Tags-ACTION'></a>
### ACTION `constants`

##### Summary

Defines a [Action](#T-Casasoft-BBS-Parser-BBSCodeResult-Action 'Casasoft.BBS.Parser.BBSCodeResult.Action')

<a name='F-Casasoft-BBS-Parser-Tags-BACKCOLOR'></a>
### BACKCOLOR `constants`

##### Summary

Sets the color for the background

<a name='F-Casasoft-BBS-Parser-Tags-BEEP'></a>
### BEEP `constants`

##### Summary

Sounds on the terminal

<a name='F-Casasoft-BBS-Parser-Tags-BLINK'></a>
### BLINK `constants`

##### Summary

Sets blink mode for the text

<a name='F-Casasoft-BBS-Parser-Tags-BODY'></a>
### BODY `constants`

##### Summary

Defines the body section

<a name='F-Casasoft-BBS-Parser-Tags-BOLD'></a>
### BOLD `constants`

##### Summary

Sets bold mode for the text

<a name='F-Casasoft-BBS-Parser-Tags-CLS'></a>
### CLS `constants`

##### Summary

Clears the screen

<a name='F-Casasoft-BBS-Parser-Tags-COLOR'></a>
### COLOR `constants`

##### Summary

Sets the color for the text

<a name='F-Casasoft-BBS-Parser-Tags-FIGGLE'></a>
### FIGGLE `constants`

##### Summary

Writes text with giant characters

<a name='F-Casasoft-BBS-Parser-Tags-FOOTER'></a>
### FOOTER `constants`

##### Summary

Defines the footer section

<a name='F-Casasoft-BBS-Parser-Tags-HEADER'></a>
### HEADER `constants`

##### Summary

Defines the header section

<a name='F-Casasoft-BBS-Parser-Tags-HIDDEN'></a>
### HIDDEN `constants`

##### Summary

Defines an hidden section

<a name='F-Casasoft-BBS-Parser-Tags-HR'></a>
### HR `constants`

##### Summary

Draws a row

<a name='F-Casasoft-BBS-Parser-Tags-MOVE'></a>
### MOVE `constants`

##### Summary

Move cursor on terminal

<a name='F-Casasoft-BBS-Parser-Tags-P'></a>
### P `constants`

##### Summary

Defines a paragraph

<a name='F-Casasoft-BBS-Parser-Tags-REVERSE'></a>
### REVERSE `constants`

##### Summary

Sets reverse mode for the text

<a name='F-Casasoft-BBS-Parser-Tags-UNDERLINE'></a>
### UNDERLINE `constants`

##### Summary

Sets underline mode for the text

<a name='T-Casasoft-BBS-Parser-TagsDict'></a>
## TagsDict `type`

##### Namespace

Casasoft.BBS.Parser

##### Summary

Dictionary of the tags

<a name='M-Casasoft-BBS-Parser-TagsDict-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='M-Casasoft-BBS-Parser-TagsDict-TryGetValue-System-String,Casasoft-BBS-Parser-Tags@-'></a>
### TryGetValue(tagname,tag) `method`

##### Summary

Tries to get a tag by its name

##### Returns

True if tag is found

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tagname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| tag | [Casasoft.BBS.Parser.Tags@](#T-Casasoft-BBS-Parser-Tags@ 'Casasoft.BBS.Parser.Tags@') |  |
