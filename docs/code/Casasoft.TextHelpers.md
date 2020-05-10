<a name='assembly'></a>
# Casasoft.TextHelpers

## Contents

- [ANSICodes](#T-Casasoft-BBS-Parser-ANSICodes 'Casasoft.BBS.Parser.ANSICodes')
  - [#ctor()](#M-Casasoft-BBS-Parser-ANSICodes-#ctor 'Casasoft.BBS.Parser.ANSICodes.#ctor')
  - [ColorTable](#F-Casasoft-BBS-Parser-ANSICodes-ColorTable 'Casasoft.BBS.Parser.ANSICodes.ColorTable')
  - [defaultBackColor](#F-Casasoft-BBS-Parser-ANSICodes-defaultBackColor 'Casasoft.BBS.Parser.ANSICodes.defaultBackColor')
  - [defaultForeColor](#F-Casasoft-BBS-Parser-ANSICodes-defaultForeColor 'Casasoft.BBS.Parser.ANSICodes.defaultForeColor')
  - [ClearCurrentLine](#P-Casasoft-BBS-Parser-ANSICodes-ClearCurrentLine 'Casasoft.BBS.Parser.ANSICodes.ClearCurrentLine')
  - [RestoreCursorPosition](#P-Casasoft-BBS-Parser-ANSICodes-RestoreCursorPosition 'Casasoft.BBS.Parser.ANSICodes.RestoreCursorPosition')
  - [SaveCursorPosition](#P-Casasoft-BBS-Parser-ANSICodes-SaveCursorPosition 'Casasoft.BBS.Parser.ANSICodes.SaveCursorPosition')
  - [ClearMode()](#M-Casasoft-BBS-Parser-ANSICodes-ClearMode 'Casasoft.BBS.Parser.ANSICodes.ClearMode')
  - [ClearScreen()](#M-Casasoft-BBS-Parser-ANSICodes-ClearScreen 'Casasoft.BBS.Parser.ANSICodes.ClearScreen')
  - [GetColorByName(name,isBack)](#M-Casasoft-BBS-Parser-ANSICodes-GetColorByName-System-String,System-Boolean- 'Casasoft.BBS.Parser.ANSICodes.GetColorByName(System.String,System.Boolean)')
  - [Home()](#M-Casasoft-BBS-Parser-ANSICodes-Home 'Casasoft.BBS.Parser.ANSICodes.Home')
  - [Move(col,row)](#M-Casasoft-BBS-Parser-ANSICodes-Move-System-Int32,System-Int32- 'Casasoft.BBS.Parser.ANSICodes.Move(System.Int32,System.Int32)')
  - [Move(col,row)](#M-Casasoft-BBS-Parser-ANSICodes-Move-System-String,System-String- 'Casasoft.BBS.Parser.ANSICodes.Move(System.String,System.String)')
  - [ResetMode(m)](#M-Casasoft-BBS-Parser-ANSICodes-ResetMode-Casasoft-BBS-Parser-ANSICodes-Modes- 'Casasoft.BBS.Parser.ANSICodes.ResetMode(Casasoft.BBS.Parser.ANSICodes.Modes)')
  - [SetMode()](#M-Casasoft-BBS-Parser-ANSICodes-SetMode 'Casasoft.BBS.Parser.ANSICodes.SetMode')
  - [SetMode(m)](#M-Casasoft-BBS-Parser-ANSICodes-SetMode-Casasoft-BBS-Parser-ANSICodes-Modes- 'Casasoft.BBS.Parser.ANSICodes.SetMode(Casasoft.BBS.Parser.ANSICodes.Modes)')
  - [WriteBackColor()](#M-Casasoft-BBS-Parser-ANSICodes-WriteBackColor 'Casasoft.BBS.Parser.ANSICodes.WriteBackColor')
  - [WriteForeColor()](#M-Casasoft-BBS-Parser-ANSICodes-WriteForeColor 'Casasoft.BBS.Parser.ANSICodes.WriteForeColor')
  - [WriteMode()](#M-Casasoft-BBS-Parser-ANSICodes-WriteMode 'Casasoft.BBS.Parser.ANSICodes.WriteMode')
  - [popBackColor()](#M-Casasoft-BBS-Parser-ANSICodes-popBackColor 'Casasoft.BBS.Parser.ANSICodes.popBackColor')
  - [popForeColor()](#M-Casasoft-BBS-Parser-ANSICodes-popForeColor 'Casasoft.BBS.Parser.ANSICodes.popForeColor')
  - [pushBackColor(c)](#M-Casasoft-BBS-Parser-ANSICodes-pushBackColor-Casasoft-BBS-Parser-ANSICodes-Colors- 'Casasoft.BBS.Parser.ANSICodes.pushBackColor(Casasoft.BBS.Parser.ANSICodes.Colors)')
  - [pushBackColor(name)](#M-Casasoft-BBS-Parser-ANSICodes-pushBackColor-System-String- 'Casasoft.BBS.Parser.ANSICodes.pushBackColor(System.String)')
  - [pushForeColor(c)](#M-Casasoft-BBS-Parser-ANSICodes-pushForeColor-Casasoft-BBS-Parser-ANSICodes-Colors- 'Casasoft.BBS.Parser.ANSICodes.pushForeColor(Casasoft.BBS.Parser.ANSICodes.Colors)')
  - [pushForeColor(name)](#M-Casasoft-BBS-Parser-ANSICodes-pushForeColor-System-String- 'Casasoft.BBS.Parser.ANSICodes.pushForeColor(System.String)')
  - [resetColorStack()](#M-Casasoft-BBS-Parser-ANSICodes-resetColorStack 'Casasoft.BBS.Parser.ANSICodes.resetColorStack')
- [Colors](#T-Casasoft-BBS-Parser-ANSICodes-Colors 'Casasoft.BBS.Parser.ANSICodes.Colors')
- [Modes](#T-Casasoft-BBS-Parser-ANSICodes-Modes 'Casasoft.BBS.Parser.ANSICodes.Modes')
- [TextAlign](#T-Casasoft-TextHelpers-TextAlign 'Casasoft.TextHelpers.TextAlign')
- [TextHelper](#T-Casasoft-TextHelpers-TextHelper 'Casasoft.TextHelpers.TextHelper')
  - [HR(c,len)](#M-Casasoft-TextHelpers-TextHelper-HR-System-Char,System-Int32- 'Casasoft.TextHelpers.TextHelper.HR(System.Char,System.Int32)')
  - [HR(c)](#M-Casasoft-TextHelpers-TextHelper-HR-System-Char- 'Casasoft.TextHelpers.TextHelper.HR(System.Char)')
  - [HR()](#M-Casasoft-TextHelpers-TextHelper-HR 'Casasoft.TextHelpers.TextHelper.HR')
  - [LineAlign(text,width)](#M-Casasoft-TextHelpers-TextHelper-LineAlign-System-String,System-Int32- 'Casasoft.TextHelpers.TextHelper.LineAlign(System.String,System.Int32)')
  - [LineAlign(text,width,align)](#M-Casasoft-TextHelpers-TextHelper-LineAlign-System-String,System-Int32,Casasoft-TextHelpers-TextAlign- 'Casasoft.TextHelpers.TextHelper.LineAlign(System.String,System.Int32,Casasoft.TextHelpers.TextAlign)')
  - [Truncate(s,size)](#M-Casasoft-TextHelpers-TextHelper-Truncate-System-String,System-Int32- 'Casasoft.TextHelpers.TextHelper.Truncate(System.String,System.Int32)')
  - [WordWrap(text,width)](#M-Casasoft-TextHelpers-TextHelper-WordWrap-System-String,System-Int32- 'Casasoft.TextHelpers.TextHelper.WordWrap(System.String,System.Int32)')
  - [WordWrap(text,width,align)](#M-Casasoft-TextHelpers-TextHelper-WordWrap-System-String,System-Int32,Casasoft-TextHelpers-TextAlign- 'Casasoft.TextHelpers.TextHelper.WordWrap(System.String,System.Int32,Casasoft.TextHelpers.TextAlign)')

<a name='T-Casasoft-BBS-Parser-ANSICodes'></a>
## ANSICodes `type`

##### Namespace

Casasoft.BBS.Parser

##### Summary

ANSI Sequences helper

<a name='M-Casasoft-BBS-Parser-ANSICodes-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='F-Casasoft-BBS-Parser-ANSICodes-ColorTable'></a>
### ColorTable `constants`

##### Summary

Contains the string to enum table

<a name='F-Casasoft-BBS-Parser-ANSICodes-defaultBackColor'></a>
### defaultBackColor `constants`

##### Summary

Default background color

<a name='F-Casasoft-BBS-Parser-ANSICodes-defaultForeColor'></a>
### defaultForeColor `constants`

##### Summary

Default text color

<a name='P-Casasoft-BBS-Parser-ANSICodes-ClearCurrentLine'></a>
### ClearCurrentLine `property`

##### Summary

Sequence to clear current line

<a name='P-Casasoft-BBS-Parser-ANSICodes-RestoreCursorPosition'></a>
### RestoreCursorPosition `property`

##### Summary

Sequence to restore cursor position on terminal

<a name='P-Casasoft-BBS-Parser-ANSICodes-SaveCursorPosition'></a>
### SaveCursorPosition `property`

##### Summary

Sequence to save cursor position on terminal

<a name='M-Casasoft-BBS-Parser-ANSICodes-ClearMode'></a>
### ClearMode() `method`

##### Summary

Resets text modes stack

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Parser-ANSICodes-ClearScreen'></a>
### ClearScreen() `method`

##### Summary

Returns the sequente to clear the screen

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Parser-ANSICodes-GetColorByName-System-String,System-Boolean-'></a>
### GetColorByName(name,isBack) `method`

##### Summary

Gets enum value from case insensitive string

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| isBack | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (optional) set if color is requested for background |

<a name='M-Casasoft-BBS-Parser-ANSICodes-Home'></a>
### Home() `method`

##### Summary

Sequence to move cursor to home (0,0)

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Parser-ANSICodes-Move-System-Int32,System-Int32-'></a>
### Move(col,row) `method`

##### Summary

Sequence to move cursor to col /row

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| col | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| row | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Casasoft-BBS-Parser-ANSICodes-Move-System-String,System-String-'></a>
### Move(col,row) `method`

##### Summary

Sequence to move cursor to col /row

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| col | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| row | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-Parser-ANSICodes-ResetMode-Casasoft-BBS-Parser-ANSICodes-Modes-'></a>
### ResetMode(m) `method`

##### Summary

Disables the text mode

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| m | [Casasoft.BBS.Parser.ANSICodes.Modes](#T-Casasoft-BBS-Parser-ANSICodes-Modes 'Casasoft.BBS.Parser.ANSICodes.Modes') | Text modes enum |

<a name='M-Casasoft-BBS-Parser-ANSICodes-SetMode'></a>
### SetMode() `method`

##### Summary

Clears all text modes

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Parser-ANSICodes-SetMode-Casasoft-BBS-Parser-ANSICodes-Modes-'></a>
### SetMode(m) `method`

##### Summary

Enables the text mode

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| m | [Casasoft.BBS.Parser.ANSICodes.Modes](#T-Casasoft-BBS-Parser-ANSICodes-Modes 'Casasoft.BBS.Parser.ANSICodes.Modes') | Text modes enum |

<a name='M-Casasoft-BBS-Parser-ANSICodes-WriteBackColor'></a>
### WriteBackColor() `method`

##### Summary

Returns sequence for current backgroud color

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Parser-ANSICodes-WriteForeColor'></a>
### WriteForeColor() `method`

##### Summary

Returns sequence for current text color

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Parser-ANSICodes-WriteMode'></a>
### WriteMode() `method`

##### Summary

Returns sequence for current modes and colors

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Parser-ANSICodes-popBackColor'></a>
### popBackColor() `method`

##### Summary

Pops the color from the background color stack

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Parser-ANSICodes-popForeColor'></a>
### popForeColor() `method`

##### Summary

Pops the color from the text color stack

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Parser-ANSICodes-pushBackColor-Casasoft-BBS-Parser-ANSICodes-Colors-'></a>
### pushBackColor(c) `method`

##### Summary

Pushes the color in the background color stack

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Parser.ANSICodes.Colors](#T-Casasoft-BBS-Parser-ANSICodes-Colors 'Casasoft.BBS.Parser.ANSICodes.Colors') | color by enum value |

<a name='M-Casasoft-BBS-Parser-ANSICodes-pushBackColor-System-String-'></a>
### pushBackColor(name) `method`

##### Summary

Pushes the color in the background color stack

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | color by name |

<a name='M-Casasoft-BBS-Parser-ANSICodes-pushForeColor-Casasoft-BBS-Parser-ANSICodes-Colors-'></a>
### pushForeColor(c) `method`

##### Summary

Push the color in the text color stack

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Parser.ANSICodes.Colors](#T-Casasoft-BBS-Parser-ANSICodes-Colors 'Casasoft.BBS.Parser.ANSICodes.Colors') | color by enum value |

<a name='M-Casasoft-BBS-Parser-ANSICodes-pushForeColor-System-String-'></a>
### pushForeColor(name) `method`

##### Summary

Pushes the color in the text color stack

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | color by name |

<a name='M-Casasoft-BBS-Parser-ANSICodes-resetColorStack'></a>
### resetColorStack() `method`

##### Summary

Resets the internal colors stacks

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-Parser-ANSICodes-Colors'></a>
## Colors `type`

##### Namespace

Casasoft.BBS.Parser.ANSICodes

##### Summary

basic coloror

<a name='T-Casasoft-BBS-Parser-ANSICodes-Modes'></a>
## Modes `type`

##### Namespace

Casasoft.BBS.Parser.ANSICodes

##### Summary

Text modes

<a name='T-Casasoft-TextHelpers-TextAlign'></a>
## TextAlign `type`

##### Namespace

Casasoft.TextHelpers

##### Summary

Paragraphs text alignment

<a name='T-Casasoft-TextHelpers-TextHelper'></a>
## TextHelper `type`

##### Namespace

Casasoft.TextHelpers

##### Summary

Functions for text management

<a name='M-Casasoft-TextHelpers-TextHelper-HR-System-Char,System-Int32-'></a>
### HR(c,len) `method`

##### Summary

returns a string composed of c repeated len times

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') |  |
| len | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Casasoft-TextHelpers-TextHelper-HR-System-Char-'></a>
### HR(c) `method`

##### Summary

returns a string composed of c repeated 80 times

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') |  |

<a name='M-Casasoft-TextHelpers-TextHelper-HR'></a>
### HR() `method`

##### Summary

returns a string composed of '-' repeated 80 times

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Casasoft-TextHelpers-TextHelper-LineAlign-System-String,System-Int32-'></a>
### LineAlign(text,width) `method`

##### Summary

Left aligns the text in width columns

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| width | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Casasoft-TextHelpers-TextHelper-LineAlign-System-String,System-Int32,Casasoft-TextHelpers-TextAlign-'></a>
### LineAlign(text,width,align) `method`

##### Summary

Aligns the text in width columns

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| width | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| align | [Casasoft.TextHelpers.TextAlign](#T-Casasoft-TextHelpers-TextAlign 'Casasoft.TextHelpers.TextAlign') | alignment type |

<a name='M-Casasoft-TextHelpers-TextHelper-Truncate-System-String,System-Int32-'></a>
### Truncate(s,size) `method`

##### Summary

Returns the left part of a string without exception
if the string is shorter then requested size

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| size | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Casasoft-TextHelpers-TextHelper-WordWrap-System-String,System-Int32-'></a>
### WordWrap(text,width) `method`

##### Summary

Word wraps text in width columns 
text is left aligned

##### Returns

List of strings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| width | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Casasoft-TextHelpers-TextHelper-WordWrap-System-String,System-Int32,Casasoft-TextHelpers-TextAlign-'></a>
### WordWrap(text,width,align) `method`

##### Summary

Word wraps text in width columns

##### Returns

List of strings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| width | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| align | [Casasoft.TextHelpers.TextAlign](#T-Casasoft-TextHelpers-TextAlign 'Casasoft.TextHelpers.TextAlign') | alignment mode |
