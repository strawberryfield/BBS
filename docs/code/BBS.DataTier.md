<a name='assembly'></a>
# BBS.DataTier

## Contents

- [DbHelpers](#T-Casasoft-BBS-DataTier-DbHelpers 'Casasoft.BBS.DataTier.DbHelpers')
  - [CreateMD5(input)](#M-Casasoft-BBS-DataTier-DbHelpers-CreateMD5-System-String- 'Casasoft.BBS.DataTier.DbHelpers.CreateMD5(System.String)')
- [Message](#T-Casasoft-BBS-DataTier-DataModel-Message 'Casasoft.BBS.DataTier.DataModel.Message')
  - [IsNew(since)](#M-Casasoft-BBS-DataTier-DataModel-Message-IsNew-System-DateTime- 'Casasoft.BBS.DataTier.DataModel.Message.IsNew(System.DateTime)')
  - [IsRead(username)](#M-Casasoft-BBS-DataTier-DataModel-Message-IsRead-System-String- 'Casasoft.BBS.DataTier.DataModel.Message.IsRead(System.String)')
- [MessageArea](#T-Casasoft-BBS-DataTier-DataModel-MessageArea 'Casasoft.BBS.DataTier.DataModel.MessageArea')
  - [MessagesCount](#P-Casasoft-BBS-DataTier-DataModel-MessageArea-MessagesCount 'Casasoft.BBS.DataTier.DataModel.MessageArea.MessagesCount')
  - [NewMessages(since)](#M-Casasoft-BBS-DataTier-DataModel-MessageArea-NewMessages-System-DateTime- 'Casasoft.BBS.DataTier.DataModel.MessageArea.NewMessages(System.DateTime)')
  - [NewMessagesCount(since)](#M-Casasoft-BBS-DataTier-DataModel-MessageArea-NewMessagesCount-System-DateTime- 'Casasoft.BBS.DataTier.DataModel.MessageArea.NewMessagesCount(System.DateTime)')
  - [Readable(user)](#M-Casasoft-BBS-DataTier-DataModel-MessageArea-Readable-Casasoft-BBS-DataTier-DataModel-User- 'Casasoft.BBS.DataTier.DataModel.MessageArea.Readable(Casasoft.BBS.DataTier.DataModel.User)')
  - [UnreadMessages(username)](#M-Casasoft-BBS-DataTier-DataModel-MessageArea-UnreadMessages-System-String- 'Casasoft.BBS.DataTier.DataModel.MessageArea.UnreadMessages(System.String)')
  - [UnreadMessagesCount(username)](#M-Casasoft-BBS-DataTier-DataModel-MessageArea-UnreadMessagesCount-System-String- 'Casasoft.BBS.DataTier.DataModel.MessageArea.UnreadMessagesCount(System.String)')
  - [Writable(user)](#M-Casasoft-BBS-DataTier-DataModel-MessageArea-Writable-Casasoft-BBS-DataTier-DataModel-User- 'Casasoft.BBS.DataTier.DataModel.MessageArea.Writable(Casasoft.BBS.DataTier.DataModel.User)')
- [User](#T-Casasoft-BBS-DataTier-DataModel-User 'Casasoft.BBS.DataTier.DataModel.User')
  - [AcceptablePassword(pwd)](#M-Casasoft-BBS-DataTier-DataModel-User-AcceptablePassword-System-String- 'Casasoft.BBS.DataTier.DataModel.User.AcceptablePassword(System.String)')
  - [AcceptableUsername(name)](#M-Casasoft-BBS-DataTier-DataModel-User-AcceptableUsername-System-String- 'Casasoft.BBS.DataTier.DataModel.User.AcceptableUsername(System.String)')
  - [CheckPassword(pwd)](#M-Casasoft-BBS-DataTier-DataModel-User-CheckPassword-System-String- 'Casasoft.BBS.DataTier.DataModel.User.CheckPassword(System.String)')
  - [ExpiredPassword()](#M-Casasoft-BBS-DataTier-DataModel-User-ExpiredPassword 'Casasoft.BBS.DataTier.DataModel.User.ExpiredPassword')
  - [HasRights(required)](#M-Casasoft-BBS-DataTier-DataModel-User-HasRights-System-String- 'Casasoft.BBS.DataTier.DataModel.User.HasRights(System.String)')
  - [SetPassword(pwd)](#M-Casasoft-BBS-DataTier-DataModel-User-SetPassword-System-String- 'Casasoft.BBS.DataTier.DataModel.User.SetPassword(System.String)')
- [bbsContext](#T-Casasoft-BBS-DataTier-bbsContext 'Casasoft.BBS.DataTier.bbsContext')
  - [#ctor()](#M-Casasoft-BBS-DataTier-bbsContext-#ctor 'Casasoft.BBS.DataTier.bbsContext.#ctor')
  - [#ctor(options)](#M-Casasoft-BBS-DataTier-bbsContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{Casasoft-BBS-DataTier-DBContext-bbsContext}- 'Casasoft.BBS.DataTier.bbsContext.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions{Casasoft.BBS.DataTier.DBContext.bbsContext})')
  - [GetAllowedMessageAreasGroup(username)](#M-Casasoft-BBS-DataTier-bbsContext-GetAllowedMessageAreasGroup-System-String- 'Casasoft.BBS.DataTier.bbsContext.GetAllowedMessageAreasGroup(System.String)')
  - [GetMessageAllowedAreasByGroup(group,username)](#M-Casasoft-BBS-DataTier-bbsContext-GetMessageAllowedAreasByGroup-System-String,System-String- 'Casasoft.BBS.DataTier.bbsContext.GetMessageAllowedAreasByGroup(System.String,System.String)')
  - [GetUserByUsername(username)](#M-Casasoft-BBS-DataTier-bbsContext-GetUserByUsername-System-String- 'Casasoft.BBS.DataTier.bbsContext.GetUserByUsername(System.String)')
  - [OnConfiguring(optionsBuilder)](#M-Casasoft-BBS-DataTier-bbsContext-OnConfiguring-Microsoft-EntityFrameworkCore-DbContextOptionsBuilder- 'Casasoft.BBS.DataTier.bbsContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)')

<a name='T-Casasoft-BBS-DataTier-DbHelpers'></a>
## DbHelpers `type`

##### Namespace

Casasoft.BBS.DataTier

##### Summary

Collection of database utilities

<a name='M-Casasoft-BBS-DataTier-DbHelpers-CreateMD5-System-String-'></a>
### CreateMD5(input) `method`

##### Summary

Computes MD5 hash of a string

##### Returns

hex hash

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Casasoft-BBS-DataTier-DataModel-Message'></a>
## Message `type`

##### Namespace

Casasoft.BBS.DataTier.DataModel

##### Summary

mail message entity

<a name='M-Casasoft-BBS-DataTier-DataModel-Message-IsNew-System-DateTime-'></a>
### IsNew(since) `method`

##### Summary

Test if a message is posted after the datetime

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| since | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | reference timestamp |

<a name='M-Casasoft-BBS-DataTier-DataModel-Message-IsRead-System-String-'></a>
### IsRead(username) `method`

##### Summary

Test if the user has already read the message

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Casasoft-BBS-DataTier-DataModel-MessageArea'></a>
## MessageArea `type`

##### Namespace

Casasoft.BBS.DataTier.DataModel

##### Summary

Message area entity

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageArea-MessagesCount'></a>
### MessagesCount `property`

##### Summary

Total number of messages in the area

<a name='M-Casasoft-BBS-DataTier-DataModel-MessageArea-NewMessages-System-DateTime-'></a>
### NewMessages(since) `method`

##### Summary

List of messages posted after the timestamp

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| since | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | reference timestamp |

<a name='M-Casasoft-BBS-DataTier-DataModel-MessageArea-NewMessagesCount-System-DateTime-'></a>
### NewMessagesCount(since) `method`

##### Summary

Number of messages posted after the timestamp

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| since | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | reference timestamp |

<a name='M-Casasoft-BBS-DataTier-DataModel-MessageArea-Readable-Casasoft-BBS-DataTier-DataModel-User-'></a>
### Readable(user) `method`

##### Summary

Tests if the user can read this message area

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [Casasoft.BBS.DataTier.DataModel.User](#T-Casasoft-BBS-DataTier-DataModel-User 'Casasoft.BBS.DataTier.DataModel.User') |  |

<a name='M-Casasoft-BBS-DataTier-DataModel-MessageArea-UnreadMessages-System-String-'></a>
### UnreadMessages(username) `method`

##### Summary

List of messages not already read by the user

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-DataTier-DataModel-MessageArea-UnreadMessagesCount-System-String-'></a>
### UnreadMessagesCount(username) `method`

##### Summary

Number of message not already read by the user

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-DataTier-DataModel-MessageArea-Writable-Casasoft-BBS-DataTier-DataModel-User-'></a>
### Writable(user) `method`

##### Summary

Tests if the user can write into this message area

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [Casasoft.BBS.DataTier.DataModel.User](#T-Casasoft-BBS-DataTier-DataModel-User 'Casasoft.BBS.DataTier.DataModel.User') |  |

<a name='T-Casasoft-BBS-DataTier-DataModel-User'></a>
## User `type`

##### Namespace

Casasoft.BBS.DataTier.DataModel

##### Summary

User entity

<a name='M-Casasoft-BBS-DataTier-DataModel-User-AcceptablePassword-System-String-'></a>
### AcceptablePassword(pwd) `method`

##### Summary

Checks if a paasword meets security rules

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pwd | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-DataTier-DataModel-User-AcceptableUsername-System-String-'></a>
### AcceptableUsername(name) `method`

##### Summary

Checks if the username meets bbs rules

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-DataTier-DataModel-User-CheckPassword-System-String-'></a>
### CheckPassword(pwd) `method`

##### Summary

Checks a password against its saved hash

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pwd | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-DataTier-DataModel-User-ExpiredPassword'></a>
### ExpiredPassword() `method`

##### Summary

Checks if a password is expired

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-DataTier-DataModel-User-HasRights-System-String-'></a>
### HasRights(required) `method`

##### Summary

Checks if user meets access restrictions

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| required | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-DataTier-DataModel-User-SetPassword-System-String-'></a>
### SetPassword(pwd) `method`

##### Summary

Saves the hash of a password

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pwd | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Casasoft-BBS-DataTier-bbsContext'></a>
## bbsContext `type`

##### Namespace

Casasoft.BBS.DataTier

##### Summary

Database abstraction class

<a name='M-Casasoft-BBS-DataTier-bbsContext-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='M-Casasoft-BBS-DataTier-bbsContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{Casasoft-BBS-DataTier-DBContext-bbsContext}-'></a>
### #ctor(options) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.EntityFrameworkCore.DbContextOptions{Casasoft.BBS.DataTier.DBContext.bbsContext}](#T-Microsoft-EntityFrameworkCore-DbContextOptions{Casasoft-BBS-DataTier-DBContext-bbsContext} 'Microsoft.EntityFrameworkCore.DbContextOptions{Casasoft.BBS.DataTier.DBContext.bbsContext}') |  |

<a name='M-Casasoft-BBS-DataTier-bbsContext-GetAllowedMessageAreasGroup-System-String-'></a>
### GetAllowedMessageAreasGroup(username) `method`

##### Summary

Gets a list of accessible message areas groups for an user

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-DataTier-bbsContext-GetMessageAllowedAreasByGroup-System-String,System-String-'></a>
### GetMessageAllowedAreasByGroup(group,username) `method`

##### Summary

Gets a list of accessible message areas for an user

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| group | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-DataTier-bbsContext-GetUserByUsername-System-String-'></a>
### GetUserByUsername(username) `method`

##### Summary

Gets an [User](#T-Casasoft-BBS-DataTier-DataModel-User 'Casasoft.BBS.DataTier.DataModel.User') instance from the username string

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-DataTier-bbsContext-OnConfiguring-Microsoft-EntityFrameworkCore-DbContextOptionsBuilder-'></a>
### OnConfiguring(optionsBuilder) `method`

##### Summary

Gets connection string from app.config

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| optionsBuilder | [Microsoft.EntityFrameworkCore.DbContextOptionsBuilder](#T-Microsoft-EntityFrameworkCore-DbContextOptionsBuilder 'Microsoft.EntityFrameworkCore.DbContextOptionsBuilder') |  |
