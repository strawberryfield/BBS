<a name='assembly'></a>
# BBS.DataTier

## Contents

- [CustomContextWriter](#T-Casasoft-BBS-DataTier-CustomContextWriter 'Casasoft.BBS.DataTier.CustomContextWriter')
  - [#ctor(providerConfigurationCodeGenerator,annotationCodeGenerator,cSharpHelper)](#M-Casasoft-BBS-DataTier-CustomContextWriter-#ctor-Microsoft-EntityFrameworkCore-Scaffolding-IProviderConfigurationCodeGenerator,Microsoft-EntityFrameworkCore-Design-IAnnotationCodeGenerator,Microsoft-EntityFrameworkCore-Design-ICSharpHelper- 'Casasoft.BBS.DataTier.CustomContextWriter.#ctor(Microsoft.EntityFrameworkCore.Scaffolding.IProviderConfigurationCodeGenerator,Microsoft.EntityFrameworkCore.Design.IAnnotationCodeGenerator,Microsoft.EntityFrameworkCore.Design.ICSharpHelper)')
  - [WriteCode(model,contextName,connectionString,contextNamespace,modelNamespace,useDataAnnotations,suppressConnectionStringWarning)](#M-Casasoft-BBS-DataTier-CustomContextWriter-WriteCode-Microsoft-EntityFrameworkCore-Metadata-IModel,System-String,System-String,System-String,System-String,System-Boolean,System-Boolean- 'Casasoft.BBS.DataTier.CustomContextWriter.WriteCode(Microsoft.EntityFrameworkCore.Metadata.IModel,System.String,System.String,System.String,System.String,System.Boolean,System.Boolean)')
- [CustomEntityWriter](#T-Casasoft-BBS-DataTier-CustomEntityWriter 'Casasoft.BBS.DataTier.CustomEntityWriter')
  - [#ctor(cSharpHelper)](#M-Casasoft-BBS-DataTier-CustomEntityWriter-#ctor-Microsoft-EntityFrameworkCore-Design-ICSharpHelper- 'Casasoft.BBS.DataTier.CustomEntityWriter.#ctor(Microsoft.EntityFrameworkCore.Design.ICSharpHelper)')
  - [WriteCode(type,namespace,useDataAnnotations)](#M-Casasoft-BBS-DataTier-CustomEntityWriter-WriteCode-Microsoft-EntityFrameworkCore-Metadata-IEntityType,System-String,System-Boolean- 'Casasoft.BBS.DataTier.CustomEntityWriter.WriteCode(Microsoft.EntityFrameworkCore.Metadata.IEntityType,System.String,System.Boolean)')
- [CustomHelpers](#T-Casasoft-BBS-DataTier-CustomHelpers 'Casasoft.BBS.DataTier.CustomHelpers')
  - [classSummary](#F-Casasoft-BBS-DataTier-CustomHelpers-classSummary 'Casasoft.BBS.DataTier.CustomHelpers.classSummary')
  - [copyrightNotice](#F-Casasoft-BBS-DataTier-CustomHelpers-copyrightNotice 'Casasoft.BBS.DataTier.CustomHelpers.copyrightNotice')
  - [generatedCodeAttribute](#F-Casasoft-BBS-DataTier-CustomHelpers-generatedCodeAttribute 'Casasoft.BBS.DataTier.CustomHelpers.generatedCodeAttribute')
  - [ppc](#F-Casasoft-BBS-DataTier-CustomHelpers-ppc 'Casasoft.BBS.DataTier.CustomHelpers.ppc')
  - [commentedClass(code,comment,note)](#M-Casasoft-BBS-DataTier-CustomHelpers-commentedClass-System-String,System-String,System-String- 'Casasoft.BBS.DataTier.CustomHelpers.commentedClass(System.String,System.String,System.String)')
- [DbHelpers](#T-Casasoft-BBS-DataTier-DbHelpers 'Casasoft.BBS.DataTier.DbHelpers')
  - [CreateMD5(input)](#M-Casasoft-BBS-DataTier-DbHelpers-CreateMD5-System-String- 'Casasoft.BBS.DataTier.DbHelpers.CreateMD5(System.String)')
- [FidoNetwork](#T-Casasoft-BBS-DataTier-DataModel-FidoNetwork 'Casasoft.BBS.DataTier.DataModel.FidoNetwork')
  - [#ctor()](#M-Casasoft-BBS-DataTier-DataModel-FidoNetwork-#ctor 'Casasoft.BBS.DataTier.DataModel.FidoNetwork.#ctor')
  - [Description](#P-Casasoft-BBS-DataTier-DataModel-FidoNetwork-Description 'Casasoft.BBS.DataTier.DataModel.FidoNetwork.Description')
  - [Host](#P-Casasoft-BBS-DataTier-DataModel-FidoNetwork-Host 'Casasoft.BBS.DataTier.DataModel.FidoNetwork.Host')
  - [Id](#P-Casasoft-BBS-DataTier-DataModel-FidoNetwork-Id 'Casasoft.BBS.DataTier.DataModel.FidoNetwork.Id')
  - [MessageAreasGroups](#P-Casasoft-BBS-DataTier-DataModel-FidoNetwork-MessageAreasGroups 'Casasoft.BBS.DataTier.DataModel.FidoNetwork.MessageAreasGroups')
  - [Net](#P-Casasoft-BBS-DataTier-DataModel-FidoNetwork-Net 'Casasoft.BBS.DataTier.DataModel.FidoNetwork.Net')
  - [Point](#P-Casasoft-BBS-DataTier-DataModel-FidoNetwork-Point 'Casasoft.BBS.DataTier.DataModel.FidoNetwork.Point')
  - [Zone](#P-Casasoft-BBS-DataTier-DataModel-FidoNetwork-Zone 'Casasoft.BBS.DataTier.DataModel.FidoNetwork.Zone')
- [Log](#T-Casasoft-BBS-DataTier-DataModel-Log 'Casasoft.BBS.DataTier.DataModel.Log')
  - [DateTime](#P-Casasoft-BBS-DataTier-DataModel-Log-DateTime 'Casasoft.BBS.DataTier.DataModel.Log.DateTime')
  - [Description](#P-Casasoft-BBS-DataTier-DataModel-Log-Description 'Casasoft.BBS.DataTier.DataModel.Log.Description')
  - [Id](#P-Casasoft-BBS-DataTier-DataModel-Log-Id 'Casasoft.BBS.DataTier.DataModel.Log.Id')
  - [Level](#P-Casasoft-BBS-DataTier-DataModel-Log-Level 'Casasoft.BBS.DataTier.DataModel.Log.Level')
  - [Remote](#P-Casasoft-BBS-DataTier-DataModel-Log-Remote 'Casasoft.BBS.DataTier.DataModel.Log.Remote')
- [Login](#T-Casasoft-BBS-DataTier-DataModel-Login 'Casasoft.BBS.DataTier.DataModel.Login')
  - [DateTime](#P-Casasoft-BBS-DataTier-DataModel-Login-DateTime 'Casasoft.BBS.DataTier.DataModel.Login.DateTime')
  - [From](#P-Casasoft-BBS-DataTier-DataModel-Login-From 'Casasoft.BBS.DataTier.DataModel.Login.From')
  - [Id](#P-Casasoft-BBS-DataTier-DataModel-Login-Id 'Casasoft.BBS.DataTier.DataModel.Login.Id')
  - [Success](#P-Casasoft-BBS-DataTier-DataModel-Login-Success 'Casasoft.BBS.DataTier.DataModel.Login.Success')
  - [User](#P-Casasoft-BBS-DataTier-DataModel-Login-User 'Casasoft.BBS.DataTier.DataModel.Login.User')
  - [UserId](#P-Casasoft-BBS-DataTier-DataModel-Login-UserId 'Casasoft.BBS.DataTier.DataModel.Login.UserId')
- [Message](#T-Casasoft-BBS-DataTier-DataModel-Message 'Casasoft.BBS.DataTier.DataModel.Message')
  - [#ctor()](#M-Casasoft-BBS-DataTier-DataModel-Message-#ctor 'Casasoft.BBS.DataTier.DataModel.Message.#ctor')
  - [Area](#P-Casasoft-BBS-DataTier-DataModel-Message-Area 'Casasoft.BBS.DataTier.DataModel.Message.Area')
  - [AreaNavigation](#P-Casasoft-BBS-DataTier-DataModel-Message-AreaNavigation 'Casasoft.BBS.DataTier.DataModel.Message.AreaNavigation')
  - [Body](#P-Casasoft-BBS-DataTier-DataModel-Message-Body 'Casasoft.BBS.DataTier.DataModel.Message.Body')
  - [DateTime](#P-Casasoft-BBS-DataTier-DataModel-Message-DateTime 'Casasoft.BBS.DataTier.DataModel.Message.DateTime')
  - [DestNet](#P-Casasoft-BBS-DataTier-DataModel-Message-DestNet 'Casasoft.BBS.DataTier.DataModel.Message.DestNet')
  - [DestNode](#P-Casasoft-BBS-DataTier-DataModel-Message-DestNode 'Casasoft.BBS.DataTier.DataModel.Message.DestNode')
  - [DestPoint](#P-Casasoft-BBS-DataTier-DataModel-Message-DestPoint 'Casasoft.BBS.DataTier.DataModel.Message.DestPoint')
  - [DestZone](#P-Casasoft-BBS-DataTier-DataModel-Message-DestZone 'Casasoft.BBS.DataTier.DataModel.Message.DestZone')
  - [FidoId](#P-Casasoft-BBS-DataTier-DataModel-Message-FidoId 'Casasoft.BBS.DataTier.DataModel.Message.FidoId')
  - [FidoReplyTo](#P-Casasoft-BBS-DataTier-DataModel-Message-FidoReplyTo 'Casasoft.BBS.DataTier.DataModel.Message.FidoReplyTo')
  - [Id](#P-Casasoft-BBS-DataTier-DataModel-Message-Id 'Casasoft.BBS.DataTier.DataModel.Message.Id')
  - [MessageFrom](#P-Casasoft-BBS-DataTier-DataModel-Message-MessageFrom 'Casasoft.BBS.DataTier.DataModel.Message.MessageFrom')
  - [MessageReads](#P-Casasoft-BBS-DataTier-DataModel-Message-MessageReads 'Casasoft.BBS.DataTier.DataModel.Message.MessageReads')
  - [MessageTo](#P-Casasoft-BBS-DataTier-DataModel-Message-MessageTo 'Casasoft.BBS.DataTier.DataModel.Message.MessageTo')
  - [OrigNet](#P-Casasoft-BBS-DataTier-DataModel-Message-OrigNet 'Casasoft.BBS.DataTier.DataModel.Message.OrigNet')
  - [OrigNode](#P-Casasoft-BBS-DataTier-DataModel-Message-OrigNode 'Casasoft.BBS.DataTier.DataModel.Message.OrigNode')
  - [OrigPoint](#P-Casasoft-BBS-DataTier-DataModel-Message-OrigPoint 'Casasoft.BBS.DataTier.DataModel.Message.OrigPoint')
  - [OrigZone](#P-Casasoft-BBS-DataTier-DataModel-Message-OrigZone 'Casasoft.BBS.DataTier.DataModel.Message.OrigZone')
  - [Subject](#P-Casasoft-BBS-DataTier-DataModel-Message-Subject 'Casasoft.BBS.DataTier.DataModel.Message.Subject')
  - [TimesRead](#P-Casasoft-BBS-DataTier-DataModel-Message-TimesRead 'Casasoft.BBS.DataTier.DataModel.Message.TimesRead')
  - [IsNew(since)](#M-Casasoft-BBS-DataTier-DataModel-Message-IsNew-System-DateTime- 'Casasoft.BBS.DataTier.DataModel.Message.IsNew(System.DateTime)')
  - [IsRead(username)](#M-Casasoft-BBS-DataTier-DataModel-Message-IsRead-System-String- 'Casasoft.BBS.DataTier.DataModel.Message.IsRead(System.String)')
- [MessageArea](#T-Casasoft-BBS-DataTier-DataModel-MessageArea 'Casasoft.BBS.DataTier.DataModel.MessageArea')
  - [#ctor()](#M-Casasoft-BBS-DataTier-DataModel-MessageArea-#ctor 'Casasoft.BBS.DataTier.DataModel.MessageArea.#ctor')
  - [AllowedGroupRead](#P-Casasoft-BBS-DataTier-DataModel-MessageArea-AllowedGroupRead 'Casasoft.BBS.DataTier.DataModel.MessageArea.AllowedGroupRead')
  - [AllowedGroupReadNavigation](#P-Casasoft-BBS-DataTier-DataModel-MessageArea-AllowedGroupReadNavigation 'Casasoft.BBS.DataTier.DataModel.MessageArea.AllowedGroupReadNavigation')
  - [AllowedGroupWrite](#P-Casasoft-BBS-DataTier-DataModel-MessageArea-AllowedGroupWrite 'Casasoft.BBS.DataTier.DataModel.MessageArea.AllowedGroupWrite')
  - [AllowedGroupWriteNavigation](#P-Casasoft-BBS-DataTier-DataModel-MessageArea-AllowedGroupWriteNavigation 'Casasoft.BBS.DataTier.DataModel.MessageArea.AllowedGroupWriteNavigation')
  - [Areagroup](#P-Casasoft-BBS-DataTier-DataModel-MessageArea-Areagroup 'Casasoft.BBS.DataTier.DataModel.MessageArea.Areagroup')
  - [AreagroupNavigation](#P-Casasoft-BBS-DataTier-DataModel-MessageArea-AreagroupNavigation 'Casasoft.BBS.DataTier.DataModel.MessageArea.AreagroupNavigation')
  - [Description](#P-Casasoft-BBS-DataTier-DataModel-MessageArea-Description 'Casasoft.BBS.DataTier.DataModel.MessageArea.Description')
  - [Fidoid](#P-Casasoft-BBS-DataTier-DataModel-MessageArea-Fidoid 'Casasoft.BBS.DataTier.DataModel.MessageArea.Fidoid')
  - [Id](#P-Casasoft-BBS-DataTier-DataModel-MessageArea-Id 'Casasoft.BBS.DataTier.DataModel.MessageArea.Id')
  - [Messages](#P-Casasoft-BBS-DataTier-DataModel-MessageArea-Messages 'Casasoft.BBS.DataTier.DataModel.MessageArea.Messages')
  - [MessagesCount](#P-Casasoft-BBS-DataTier-DataModel-MessageArea-MessagesCount 'Casasoft.BBS.DataTier.DataModel.MessageArea.MessagesCount')
  - [NewMessages(since)](#M-Casasoft-BBS-DataTier-DataModel-MessageArea-NewMessages-System-DateTime- 'Casasoft.BBS.DataTier.DataModel.MessageArea.NewMessages(System.DateTime)')
  - [NewMessagesCount(since)](#M-Casasoft-BBS-DataTier-DataModel-MessageArea-NewMessagesCount-System-DateTime- 'Casasoft.BBS.DataTier.DataModel.MessageArea.NewMessagesCount(System.DateTime)')
  - [Readable(user)](#M-Casasoft-BBS-DataTier-DataModel-MessageArea-Readable-Casasoft-BBS-DataTier-DataModel-User- 'Casasoft.BBS.DataTier.DataModel.MessageArea.Readable(Casasoft.BBS.DataTier.DataModel.User)')
  - [UnreadMessages(username)](#M-Casasoft-BBS-DataTier-DataModel-MessageArea-UnreadMessages-System-String- 'Casasoft.BBS.DataTier.DataModel.MessageArea.UnreadMessages(System.String)')
  - [UnreadMessagesCount(username)](#M-Casasoft-BBS-DataTier-DataModel-MessageArea-UnreadMessagesCount-System-String- 'Casasoft.BBS.DataTier.DataModel.MessageArea.UnreadMessagesCount(System.String)')
  - [Writable(user)](#M-Casasoft-BBS-DataTier-DataModel-MessageArea-Writable-Casasoft-BBS-DataTier-DataModel-User- 'Casasoft.BBS.DataTier.DataModel.MessageArea.Writable(Casasoft.BBS.DataTier.DataModel.User)')
- [MessageAreasGroup](#T-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup 'Casasoft.BBS.DataTier.DataModel.MessageAreasGroup')
  - [#ctor()](#M-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-#ctor 'Casasoft.BBS.DataTier.DataModel.MessageAreasGroup.#ctor')
  - [AllowedGroup](#P-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-AllowedGroup 'Casasoft.BBS.DataTier.DataModel.MessageAreasGroup.AllowedGroup')
  - [AllowedGroupId](#P-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-AllowedGroupId 'Casasoft.BBS.DataTier.DataModel.MessageAreasGroup.AllowedGroupId')
  - [Description](#P-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-Description 'Casasoft.BBS.DataTier.DataModel.MessageAreasGroup.Description')
  - [FidoNetwork](#P-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-FidoNetwork 'Casasoft.BBS.DataTier.DataModel.MessageAreasGroup.FidoNetwork')
  - [FidoNetworkNavigation](#P-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-FidoNetworkNavigation 'Casasoft.BBS.DataTier.DataModel.MessageAreasGroup.FidoNetworkNavigation')
  - [Id](#P-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-Id 'Casasoft.BBS.DataTier.DataModel.MessageAreasGroup.Id')
  - [MessageAreas](#P-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-MessageAreas 'Casasoft.BBS.DataTier.DataModel.MessageAreasGroup.MessageAreas')
- [MessageRead](#T-Casasoft-BBS-DataTier-DataModel-MessageRead 'Casasoft.BBS.DataTier.DataModel.MessageRead')
  - [Id](#P-Casasoft-BBS-DataTier-DataModel-MessageRead-Id 'Casasoft.BBS.DataTier.DataModel.MessageRead.Id')
  - [Messge](#P-Casasoft-BBS-DataTier-DataModel-MessageRead-Messge 'Casasoft.BBS.DataTier.DataModel.MessageRead.Messge')
  - [MessgeId](#P-Casasoft-BBS-DataTier-DataModel-MessageRead-MessgeId 'Casasoft.BBS.DataTier.DataModel.MessageRead.MessgeId')
  - [User](#P-Casasoft-BBS-DataTier-DataModel-MessageRead-User 'Casasoft.BBS.DataTier.DataModel.MessageRead.User')
  - [UserId](#P-Casasoft-BBS-DataTier-DataModel-MessageRead-UserId 'Casasoft.BBS.DataTier.DataModel.MessageRead.UserId')
- [MessageSeenBy](#T-Casasoft-BBS-DataTier-DataModel-MessageSeenBy 'Casasoft.BBS.DataTier.DataModel.MessageSeenBy')
  - [Id](#P-Casasoft-BBS-DataTier-DataModel-MessageSeenBy-Id 'Casasoft.BBS.DataTier.DataModel.MessageSeenBy.Id')
  - [Message](#P-Casasoft-BBS-DataTier-DataModel-MessageSeenBy-Message 'Casasoft.BBS.DataTier.DataModel.MessageSeenBy.Message')
  - [MessageId](#P-Casasoft-BBS-DataTier-DataModel-MessageSeenBy-MessageId 'Casasoft.BBS.DataTier.DataModel.MessageSeenBy.MessageId')
  - [SeenBy](#P-Casasoft-BBS-DataTier-DataModel-MessageSeenBy-SeenBy 'Casasoft.BBS.DataTier.DataModel.MessageSeenBy.SeenBy')
- [User](#T-Casasoft-BBS-DataTier-DataModel-User 'Casasoft.BBS.DataTier.DataModel.User')
  - [#ctor()](#M-Casasoft-BBS-DataTier-DataModel-User-#ctor 'Casasoft.BBS.DataTier.DataModel.User.#ctor')
  - [City](#P-Casasoft-BBS-DataTier-DataModel-User-City 'Casasoft.BBS.DataTier.DataModel.User.City')
  - [Email](#P-Casasoft-BBS-DataTier-DataModel-User-Email 'Casasoft.BBS.DataTier.DataModel.User.Email')
  - [LastLoginDate](#P-Casasoft-BBS-DataTier-DataModel-User-LastLoginDate 'Casasoft.BBS.DataTier.DataModel.User.LastLoginDate')
  - [LastLoginFrom](#P-Casasoft-BBS-DataTier-DataModel-User-LastLoginFrom 'Casasoft.BBS.DataTier.DataModel.User.LastLoginFrom')
  - [LastPasswordModify](#P-Casasoft-BBS-DataTier-DataModel-User-LastPasswordModify 'Casasoft.BBS.DataTier.DataModel.User.LastPasswordModify')
  - [Locked](#P-Casasoft-BBS-DataTier-DataModel-User-Locked 'Casasoft.BBS.DataTier.DataModel.User.Locked')
  - [Logins](#P-Casasoft-BBS-DataTier-DataModel-User-Logins 'Casasoft.BBS.DataTier.DataModel.User.Logins')
  - [MessageReads](#P-Casasoft-BBS-DataTier-DataModel-User-MessageReads 'Casasoft.BBS.DataTier.DataModel.User.MessageReads')
  - [Nation](#P-Casasoft-BBS-DataTier-DataModel-User-Nation 'Casasoft.BBS.DataTier.DataModel.User.Nation')
  - [Password](#P-Casasoft-BBS-DataTier-DataModel-User-Password 'Casasoft.BBS.DataTier.DataModel.User.Password')
  - [Realname](#P-Casasoft-BBS-DataTier-DataModel-User-Realname 'Casasoft.BBS.DataTier.DataModel.User.Realname')
  - [Registered](#P-Casasoft-BBS-DataTier-DataModel-User-Registered 'Casasoft.BBS.DataTier.DataModel.User.Registered')
  - [Signature](#P-Casasoft-BBS-DataTier-DataModel-User-Signature 'Casasoft.BBS.DataTier.DataModel.User.Signature')
  - [Status](#P-Casasoft-BBS-DataTier-DataModel-User-Status 'Casasoft.BBS.DataTier.DataModel.User.Status')
  - [Userid](#P-Casasoft-BBS-DataTier-DataModel-User-Userid 'Casasoft.BBS.DataTier.DataModel.User.Userid')
  - [UsersGroupsLinks](#P-Casasoft-BBS-DataTier-DataModel-User-UsersGroupsLinks 'Casasoft.BBS.DataTier.DataModel.User.UsersGroupsLinks')
  - [AcceptablePassword(pwd)](#M-Casasoft-BBS-DataTier-DataModel-User-AcceptablePassword-System-String- 'Casasoft.BBS.DataTier.DataModel.User.AcceptablePassword(System.String)')
  - [AcceptableUsername(name)](#M-Casasoft-BBS-DataTier-DataModel-User-AcceptableUsername-System-String- 'Casasoft.BBS.DataTier.DataModel.User.AcceptableUsername(System.String)')
  - [CheckPassword(pwd)](#M-Casasoft-BBS-DataTier-DataModel-User-CheckPassword-System-String- 'Casasoft.BBS.DataTier.DataModel.User.CheckPassword(System.String)')
  - [ExpiredPassword()](#M-Casasoft-BBS-DataTier-DataModel-User-ExpiredPassword 'Casasoft.BBS.DataTier.DataModel.User.ExpiredPassword')
  - [HasRights(required)](#M-Casasoft-BBS-DataTier-DataModel-User-HasRights-System-String- 'Casasoft.BBS.DataTier.DataModel.User.HasRights(System.String)')
  - [SetPassword(pwd)](#M-Casasoft-BBS-DataTier-DataModel-User-SetPassword-System-String- 'Casasoft.BBS.DataTier.DataModel.User.SetPassword(System.String)')
- [UsersGroup](#T-Casasoft-BBS-DataTier-DataModel-UsersGroup 'Casasoft.BBS.DataTier.DataModel.UsersGroup')
  - [#ctor()](#M-Casasoft-BBS-DataTier-DataModel-UsersGroup-#ctor 'Casasoft.BBS.DataTier.DataModel.UsersGroup.#ctor')
  - [Description](#P-Casasoft-BBS-DataTier-DataModel-UsersGroup-Description 'Casasoft.BBS.DataTier.DataModel.UsersGroup.Description')
  - [Groupid](#P-Casasoft-BBS-DataTier-DataModel-UsersGroup-Groupid 'Casasoft.BBS.DataTier.DataModel.UsersGroup.Groupid')
  - [MessageAreaAllowedGroupReadNavigations](#P-Casasoft-BBS-DataTier-DataModel-UsersGroup-MessageAreaAllowedGroupReadNavigations 'Casasoft.BBS.DataTier.DataModel.UsersGroup.MessageAreaAllowedGroupReadNavigations')
  - [MessageAreaAllowedGroupWriteNavigations](#P-Casasoft-BBS-DataTier-DataModel-UsersGroup-MessageAreaAllowedGroupWriteNavigations 'Casasoft.BBS.DataTier.DataModel.UsersGroup.MessageAreaAllowedGroupWriteNavigations')
  - [MessageAreasGroups](#P-Casasoft-BBS-DataTier-DataModel-UsersGroup-MessageAreasGroups 'Casasoft.BBS.DataTier.DataModel.UsersGroup.MessageAreasGroups')
  - [UsersGroupsLinks](#P-Casasoft-BBS-DataTier-DataModel-UsersGroup-UsersGroupsLinks 'Casasoft.BBS.DataTier.DataModel.UsersGroup.UsersGroupsLinks')
- [UsersGroupsLink](#T-Casasoft-BBS-DataTier-DataModel-UsersGroupsLink 'Casasoft.BBS.DataTier.DataModel.UsersGroupsLink')
  - [Group](#P-Casasoft-BBS-DataTier-DataModel-UsersGroupsLink-Group 'Casasoft.BBS.DataTier.DataModel.UsersGroupsLink.Group')
  - [Groupid](#P-Casasoft-BBS-DataTier-DataModel-UsersGroupsLink-Groupid 'Casasoft.BBS.DataTier.DataModel.UsersGroupsLink.Groupid')
  - [Id](#P-Casasoft-BBS-DataTier-DataModel-UsersGroupsLink-Id 'Casasoft.BBS.DataTier.DataModel.UsersGroupsLink.Id')
  - [User](#P-Casasoft-BBS-DataTier-DataModel-UsersGroupsLink-User 'Casasoft.BBS.DataTier.DataModel.UsersGroupsLink.User')
  - [Userid](#P-Casasoft-BBS-DataTier-DataModel-UsersGroupsLink-Userid 'Casasoft.BBS.DataTier.DataModel.UsersGroupsLink.Userid')
- [bbsContext](#T-Casasoft-BBS-DataTier-DBContext-bbsContext 'Casasoft.BBS.DataTier.DBContext.bbsContext')
- [bbsContext](#T-Casasoft-BBS-DataTier-bbsContext 'Casasoft.BBS.DataTier.bbsContext')
  - [#ctor()](#M-Casasoft-BBS-DataTier-bbsContext-#ctor 'Casasoft.BBS.DataTier.bbsContext.#ctor')
  - [#ctor(options)](#M-Casasoft-BBS-DataTier-bbsContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{Casasoft-BBS-DataTier-DBContext-bbsContext}- 'Casasoft.BBS.DataTier.bbsContext.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions{Casasoft.BBS.DataTier.DBContext.bbsContext})')
  - [FidoNetworks](#P-Casasoft-BBS-DataTier-DBContext-bbsContext-FidoNetworks 'Casasoft.BBS.DataTier.DBContext.bbsContext.FidoNetworks')
  - [Logins](#P-Casasoft-BBS-DataTier-DBContext-bbsContext-Logins 'Casasoft.BBS.DataTier.DBContext.bbsContext.Logins')
  - [Logs](#P-Casasoft-BBS-DataTier-DBContext-bbsContext-Logs 'Casasoft.BBS.DataTier.DBContext.bbsContext.Logs')
  - [MessageAreas](#P-Casasoft-BBS-DataTier-DBContext-bbsContext-MessageAreas 'Casasoft.BBS.DataTier.DBContext.bbsContext.MessageAreas')
  - [MessageAreasGroups](#P-Casasoft-BBS-DataTier-DBContext-bbsContext-MessageAreasGroups 'Casasoft.BBS.DataTier.DBContext.bbsContext.MessageAreasGroups')
  - [MessageReads](#P-Casasoft-BBS-DataTier-DBContext-bbsContext-MessageReads 'Casasoft.BBS.DataTier.DBContext.bbsContext.MessageReads')
  - [Messages](#P-Casasoft-BBS-DataTier-DBContext-bbsContext-Messages 'Casasoft.BBS.DataTier.DBContext.bbsContext.Messages')
  - [MessagesSeenBy](#P-Casasoft-BBS-DataTier-DBContext-bbsContext-MessagesSeenBy 'Casasoft.BBS.DataTier.DBContext.bbsContext.MessagesSeenBy')
  - [Users](#P-Casasoft-BBS-DataTier-DBContext-bbsContext-Users 'Casasoft.BBS.DataTier.DBContext.bbsContext.Users')
  - [UsersGroups](#P-Casasoft-BBS-DataTier-DBContext-bbsContext-UsersGroups 'Casasoft.BBS.DataTier.DBContext.bbsContext.UsersGroups')
  - [UsersGroupsLinks](#P-Casasoft-BBS-DataTier-DBContext-bbsContext-UsersGroupsLinks 'Casasoft.BBS.DataTier.DBContext.bbsContext.UsersGroupsLinks')
  - [GetAllMessagesInArea(area)](#M-Casasoft-BBS-DataTier-bbsContext-GetAllMessagesInArea-System-String- 'Casasoft.BBS.DataTier.bbsContext.GetAllMessagesInArea(System.String)')
  - [GetAllowedMessageAreasGroup(username)](#M-Casasoft-BBS-DataTier-bbsContext-GetAllowedMessageAreasGroup-System-String- 'Casasoft.BBS.DataTier.bbsContext.GetAllowedMessageAreasGroup(System.String)')
  - [GetMessageAllowedAreasByGroup(group,username)](#M-Casasoft-BBS-DataTier-bbsContext-GetMessageAllowedAreasByGroup-System-String,System-String- 'Casasoft.BBS.DataTier.bbsContext.GetMessageAllowedAreasByGroup(System.String,System.String)')
  - [GetMessageById(messageId)](#M-Casasoft-BBS-DataTier-bbsContext-GetMessageById-System-Int32- 'Casasoft.BBS.DataTier.bbsContext.GetMessageById(System.Int32)')
  - [GetMessageById(messageId)](#M-Casasoft-BBS-DataTier-bbsContext-GetMessageById-System-String- 'Casasoft.BBS.DataTier.bbsContext.GetMessageById(System.String)')
  - [GetUserByUsername(username)](#M-Casasoft-BBS-DataTier-bbsContext-GetUserByUsername-System-String- 'Casasoft.BBS.DataTier.bbsContext.GetUserByUsername(System.String)')
  - [OnConfiguring(optionsBuilder)](#M-Casasoft-BBS-DataTier-bbsContext-OnConfiguring-Microsoft-EntityFrameworkCore-DbContextOptionsBuilder- 'Casasoft.BBS.DataTier.bbsContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)')
  - [SetMessageRead(msgId,username)](#M-Casasoft-BBS-DataTier-bbsContext-SetMessageRead-System-Int32,System-String- 'Casasoft.BBS.DataTier.bbsContext.SetMessageRead(System.Int32,System.String)')

<a name='T-Casasoft-BBS-DataTier-CustomContextWriter'></a>
## CustomContextWriter `type`

##### Namespace

Casasoft.BBS.DataTier

##### Summary

Inherits and extends DbContext generator

<a name='M-Casasoft-BBS-DataTier-CustomContextWriter-#ctor-Microsoft-EntityFrameworkCore-Scaffolding-IProviderConfigurationCodeGenerator,Microsoft-EntityFrameworkCore-Design-IAnnotationCodeGenerator,Microsoft-EntityFrameworkCore-Design-ICSharpHelper-'></a>
### #ctor(providerConfigurationCodeGenerator,annotationCodeGenerator,cSharpHelper) `constructor`

##### Summary

Default constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| providerConfigurationCodeGenerator | [Microsoft.EntityFrameworkCore.Scaffolding.IProviderConfigurationCodeGenerator](#T-Microsoft-EntityFrameworkCore-Scaffolding-IProviderConfigurationCodeGenerator 'Microsoft.EntityFrameworkCore.Scaffolding.IProviderConfigurationCodeGenerator') |  |
| annotationCodeGenerator | [Microsoft.EntityFrameworkCore.Design.IAnnotationCodeGenerator](#T-Microsoft-EntityFrameworkCore-Design-IAnnotationCodeGenerator 'Microsoft.EntityFrameworkCore.Design.IAnnotationCodeGenerator') |  |
| cSharpHelper | [Microsoft.EntityFrameworkCore.Design.ICSharpHelper](#T-Microsoft-EntityFrameworkCore-Design-ICSharpHelper 'Microsoft.EntityFrameworkCore.Design.ICSharpHelper') |  |

<a name='M-Casasoft-BBS-DataTier-CustomContextWriter-WriteCode-Microsoft-EntityFrameworkCore-Metadata-IModel,System-String,System-String,System-String,System-String,System-Boolean,System-Boolean-'></a>
### WriteCode(model,contextName,connectionString,contextNamespace,modelNamespace,useDataAnnotations,suppressConnectionStringWarning) `method`

##### Summary

Code writer

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Microsoft.EntityFrameworkCore.Metadata.IModel](#T-Microsoft-EntityFrameworkCore-Metadata-IModel 'Microsoft.EntityFrameworkCore.Metadata.IModel') |  |
| contextName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| connectionString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| contextNamespace | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| modelNamespace | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| useDataAnnotations | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| suppressConnectionStringWarning | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Casasoft-BBS-DataTier-CustomEntityWriter'></a>
## CustomEntityWriter `type`

##### Namespace

Casasoft.BBS.DataTier

##### Summary

Inherits and extends Entity classes generator

<a name='M-Casasoft-BBS-DataTier-CustomEntityWriter-#ctor-Microsoft-EntityFrameworkCore-Design-ICSharpHelper-'></a>
### #ctor(cSharpHelper) `constructor`

##### Summary

Default constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cSharpHelper | [Microsoft.EntityFrameworkCore.Design.ICSharpHelper](#T-Microsoft-EntityFrameworkCore-Design-ICSharpHelper 'Microsoft.EntityFrameworkCore.Design.ICSharpHelper') |  |

<a name='M-Casasoft-BBS-DataTier-CustomEntityWriter-WriteCode-Microsoft-EntityFrameworkCore-Metadata-IEntityType,System-String,System-Boolean-'></a>
### WriteCode(type,namespace,useDataAnnotations) `method`

##### Summary

Code writer

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [Microsoft.EntityFrameworkCore.Metadata.IEntityType](#T-Microsoft-EntityFrameworkCore-Metadata-IEntityType 'Microsoft.EntityFrameworkCore.Metadata.IEntityType') |  |
| namespace | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| useDataAnnotations | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Casasoft-BBS-DataTier-CustomHelpers'></a>
## CustomHelpers `type`

##### Namespace

Casasoft.BBS.DataTier

##### Summary

Common strings for db scaffolding customization

<a name='F-Casasoft-BBS-DataTier-CustomHelpers-classSummary'></a>
### classSummary `constants`

##### Summary

Class summary comment

<a name='F-Casasoft-BBS-DataTier-CustomHelpers-copyrightNotice'></a>
### copyrightNotice `constants`

##### Summary

copyright notice to add at the top of the file

<a name='F-Casasoft-BBS-DataTier-CustomHelpers-generatedCodeAttribute'></a>
### generatedCodeAttribute `constants`

##### Summary

Generated code attribute

<a name='F-Casasoft-BBS-DataTier-CustomHelpers-ppc'></a>
### ppc `constants`

##### Summary

class declaration

<a name='M-Casasoft-BBS-DataTier-CustomHelpers-commentedClass-System-String,System-String,System-String-'></a>
### commentedClass(code,comment,note) `method`

##### Summary

Adds comment to class declaration

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | uncommented code |
| comment | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | comment to the class |
| note | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | additional comment |

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

<a name='T-Casasoft-BBS-DataTier-DataModel-FidoNetwork'></a>
## FidoNetwork `type`

##### Namespace

Casasoft.BBS.DataTier.DataModel

##### Summary

Elements of the table 'FidoNetworks':
List of fdo-style networks

<a name='M-Casasoft-BBS-DataTier-DataModel-FidoNetwork-#ctor'></a>
### #ctor() `constructor`

##### Summary

Entity constructor

##### Parameters

This constructor has no parameters.

<a name='P-Casasoft-BBS-DataTier-DataModel-FidoNetwork-Description'></a>
### Description `property`

##### Summary

Column 'description':
Network description

##### Remarks

Original field type: varchar(80)

<a name='P-Casasoft-BBS-DataTier-DataModel-FidoNetwork-Host'></a>
### Host `property`

##### Summary

Column 'host'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-FidoNetwork-Id'></a>
### Id `property`

##### Summary

Column 'ID':
Fido style network identifier

##### Remarks

Original field type: varchar(30)

<a name='P-Casasoft-BBS-DataTier-DataModel-FidoNetwork-MessageAreasGroups'></a>
### MessageAreasGroups `property`

##### Summary

ForeignKey: MessageAreasGroup {'FidoNetwork'} -> FidoNetwork {'Id'} ToDependent: MessageAreasGroups ToPrincipal: FidoNetworkNavigation

<a name='P-Casasoft-BBS-DataTier-DataModel-FidoNetwork-Net'></a>
### Net `property`

##### Summary

Column 'net'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-FidoNetwork-Point'></a>
### Point `property`

##### Summary

Column 'point'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-FidoNetwork-Zone'></a>
### Zone `property`

##### Summary

Column 'zone'

##### Remarks

Original field type: int(11)

<a name='T-Casasoft-BBS-DataTier-DataModel-Log'></a>
## Log `type`

##### Namespace

Casasoft.BBS.DataTier.DataModel

##### Summary

Elements of the table 'Log':
Events log

<a name='P-Casasoft-BBS-DataTier-DataModel-Log-DateTime'></a>
### DateTime `property`

##### Summary

Column 'DateTime':
Timestamp of the event, set to current timestamp by default

##### Remarks

Original field type: datetime

<a name='P-Casasoft-BBS-DataTier-DataModel-Log-Description'></a>
### Description `property`

##### Summary

Column 'Description'

##### Remarks

Original field type: varchar(250)

<a name='P-Casasoft-BBS-DataTier-DataModel-Log-Id'></a>
### Id `property`

##### Summary

Column 'id'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-Log-Level'></a>
### Level `property`

##### Summary

Column 'Level':
Severity level

##### Remarks

Original field type: tinyint(4)

<a name='P-Casasoft-BBS-DataTier-DataModel-Log-Remote'></a>
### Remote `property`

##### Summary

Column 'Remote':
Remote ip address and port of the client (if applicable)

##### Remarks

Original field type: varchar(24)

<a name='T-Casasoft-BBS-DataTier-DataModel-Login'></a>
## Login `type`

##### Namespace

Casasoft.BBS.DataTier.DataModel

##### Summary

Elements of the table 'Logins':
Users logins

<a name='P-Casasoft-BBS-DataTier-DataModel-Login-DateTime'></a>
### DateTime `property`

##### Summary

Column 'DateTime':
timestamp set to current timestamp by default

##### Remarks

Original field type: datetime

<a name='P-Casasoft-BBS-DataTier-DataModel-Login-From'></a>
### From `property`

##### Summary

Column 'From':
remote ip address and port of the client

##### Remarks

Original field type: varchar(24)

<a name='P-Casasoft-BBS-DataTier-DataModel-Login-Id'></a>
### Id `property`

##### Summary

Column 'ID'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-Login-Success'></a>
### Success `property`

##### Summary

Column 'Success':
true if login was successful

##### Remarks

Original field type:

<a name='P-Casasoft-BBS-DataTier-DataModel-Login-User'></a>
### User `property`

##### Summary

ForeignKey: Login {'UserId'} -> User {'Userid'} ToDependent: Logins ToPrincipal: User

<a name='P-Casasoft-BBS-DataTier-DataModel-Login-UserId'></a>
### UserId `property`

##### Summary

Column 'UserId':
username supplied for the login

##### Remarks

Original field type: varchar(30)

<a name='T-Casasoft-BBS-DataTier-DataModel-Message'></a>
## Message `type`

##### Namespace

Casasoft.BBS.DataTier.DataModel

##### Summary

Elements of the table 'Messages':
Messages

<a name='M-Casasoft-BBS-DataTier-DataModel-Message-#ctor'></a>
### #ctor() `constructor`

##### Summary

Entity constructor

##### Parameters

This constructor has no parameters.

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-Area'></a>
### Area `property`

##### Summary

Column 'Area'

##### Remarks

Original field type: varchar(20)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-AreaNavigation'></a>
### AreaNavigation `property`

##### Summary

ForeignKey: Message {'Area'} -> MessageArea {'Id'} ToDependent: Messages ToPrincipal: AreaNavigation

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-Body'></a>
### Body `property`

##### Summary

Column 'Body'

##### Remarks

Original field type: text

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-DateTime'></a>
### DateTime `property`

##### Summary

Column 'DateTime'

##### Remarks

Original field type: datetime

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-DestNet'></a>
### DestNet `property`

##### Summary

Column 'DestNet'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-DestNode'></a>
### DestNode `property`

##### Summary

Column 'DestNode'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-DestPoint'></a>
### DestPoint `property`

##### Summary

Column 'DestPoint'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-DestZone'></a>
### DestZone `property`

##### Summary

Column 'DestZone'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-FidoId'></a>
### FidoId `property`

##### Summary

Column 'FidoID'

##### Remarks

Original field type: varchar(50)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-FidoReplyTo'></a>
### FidoReplyTo `property`

##### Summary

Column 'FidoReplyTo'

##### Remarks

Original field type: varchar(50)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-Id'></a>
### Id `property`

##### Summary

Column 'ID'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-MessageFrom'></a>
### MessageFrom `property`

##### Summary

Column 'MessageFrom'

##### Remarks

Original field type: varchar(100)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-MessageReads'></a>
### MessageReads `property`

##### Summary

ForeignKey: MessageRead {'MessgeId'} -> Message {'Id'} ToDependent: MessageReads ToPrincipal: Messge

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-MessageTo'></a>
### MessageTo `property`

##### Summary

Column 'MessageTo'

##### Remarks

Original field type: varchar(100)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-OrigNet'></a>
### OrigNet `property`

##### Summary

Column 'OrigNet'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-OrigNode'></a>
### OrigNode `property`

##### Summary

Column 'OrigNode'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-OrigPoint'></a>
### OrigPoint `property`

##### Summary

Column 'OrigPoint'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-OrigZone'></a>
### OrigZone `property`

##### Summary

Column 'OrigZone'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-Subject'></a>
### Subject `property`

##### Summary

Column 'Subject'

##### Remarks

Original field type: varchar(72)

<a name='P-Casasoft-BBS-DataTier-DataModel-Message-TimesRead'></a>
### TimesRead `property`

##### Summary

Column 'TimesRead'

##### Remarks

Original field type: int(11)

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

Elements of the table 'MessageAreas':
Message Areas List

<a name='M-Casasoft-BBS-DataTier-DataModel-MessageArea-#ctor'></a>
### #ctor() `constructor`

##### Summary

Entity constructor

##### Parameters

This constructor has no parameters.

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageArea-AllowedGroupRead'></a>
### AllowedGroupRead `property`

##### Summary

Column 'AllowedGroupRead':
User group needed to access this area

##### Remarks

Original field type: varchar(30)

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageArea-AllowedGroupReadNavigation'></a>
### AllowedGroupReadNavigation `property`

##### Summary

ForeignKey: MessageArea {'AllowedGroupRead'} -> UsersGroup {'Groupid'} ToDependent: MessageAreaAllowedGroupReadNavigations ToPrincipal: AllowedGroupReadNavigation

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageArea-AllowedGroupWrite'></a>
### AllowedGroupWrite `property`

##### Summary

Column 'AllowedGroupWrite':
User group needed to write in this area

##### Remarks

Original field type: varchar(30)

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageArea-AllowedGroupWriteNavigation'></a>
### AllowedGroupWriteNavigation `property`

##### Summary

ForeignKey: MessageArea {'AllowedGroupWrite'} -> UsersGroup {'Groupid'} ToDependent: MessageAreaAllowedGroupWriteNavigations ToPrincipal: AllowedGroupWriteNavigation

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageArea-Areagroup'></a>
### Areagroup `property`

##### Summary

Column 'AREAGROUP':
Gruop that area belongs to

##### Remarks

Original field type: varchar(20)

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageArea-AreagroupNavigation'></a>
### AreagroupNavigation `property`

##### Summary

ForeignKey: MessageArea {'Areagroup'} -> MessageAreasGroup {'Id'} ToDependent: MessageAreas ToPrincipal: AreagroupNavigation

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageArea-Description'></a>
### Description `property`

##### Summary

Column 'Description'

##### Remarks

Original field type: varchar(200)

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageArea-Fidoid'></a>
### Fidoid `property`

##### Summary

Column 'FIDOID':
Message area identifier for fido network

##### Remarks

Original field type: varchar(30)

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageArea-Id'></a>
### Id `property`

##### Summary

Column 'ID':
Message area identifier

##### Remarks

Original field type: varchar(20)

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageArea-Messages'></a>
### Messages `property`

##### Summary

ForeignKey: Message {'Area'} -> MessageArea {'Id'} ToDependent: Messages ToPrincipal: AreaNavigation

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

<a name='T-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup'></a>
## MessageAreasGroup `type`

##### Namespace

Casasoft.BBS.DataTier.DataModel

##### Summary

Elements of the table 'MessageAreasGroups'

<a name='M-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-#ctor'></a>
### #ctor() `constructor`

##### Summary

Entity constructor

##### Parameters

This constructor has no parameters.

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-AllowedGroup'></a>
### AllowedGroup `property`

##### Summary

ForeignKey: MessageAreasGroup {'AllowedGroupId'} -> UsersGroup {'Groupid'} ToDependent: MessageAreasGroups ToPrincipal: AllowedGroup

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-AllowedGroupId'></a>
### AllowedGroupId `property`

##### Summary

Column 'AllowedGroupId':
User group needed for access this group

##### Remarks

Original field type: varchar(30)

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-Description'></a>
### Description `property`

##### Summary

Column 'Description'

##### Remarks

Original field type: varchar(200)

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-FidoNetwork'></a>
### FidoNetwork `property`

##### Summary

Column 'FidoNetwork':
Fido style network for exchange

##### Remarks

Original field type: varchar(30)

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-FidoNetworkNavigation'></a>
### FidoNetworkNavigation `property`

##### Summary

ForeignKey: MessageAreasGroup {'FidoNetwork'} -> FidoNetwork {'Id'} ToDependent: MessageAreasGroups ToPrincipal: FidoNetworkNavigation

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-Id'></a>
### Id `property`

##### Summary

Column 'ID':
Areas group id

##### Remarks

Original field type: varchar(20)

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageAreasGroup-MessageAreas'></a>
### MessageAreas `property`

##### Summary

ForeignKey: MessageArea {'Areagroup'} -> MessageAreasGroup {'Id'} ToDependent: MessageAreas ToPrincipal: AreagroupNavigation

<a name='T-Casasoft-BBS-DataTier-DataModel-MessageRead'></a>
## MessageRead `type`

##### Namespace

Casasoft.BBS.DataTier.DataModel

##### Summary

Elements of the table 'MessageRead':
Flags for messages read

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageRead-Id'></a>
### Id `property`

##### Summary

Column 'ID'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageRead-Messge'></a>
### Messge `property`

##### Summary

ForeignKey: MessageRead {'MessgeId'} -> Message {'Id'} ToDependent: MessageReads ToPrincipal: Messge

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageRead-MessgeId'></a>
### MessgeId `property`

##### Summary

Column 'MessgeId'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageRead-User'></a>
### User `property`

##### Summary

ForeignKey: MessageRead {'UserId'} -> User {'Userid'} ToDependent: MessageReads ToPrincipal: User

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageRead-UserId'></a>
### UserId `property`

##### Summary

Column 'UserId'

##### Remarks

Original field type: varchar(30)

<a name='T-Casasoft-BBS-DataTier-DataModel-MessageSeenBy'></a>
## MessageSeenBy `type`

##### Namespace

Casasoft.BBS.DataTier.DataModel

##### Summary

Elements of the table 'MessageSeenBy':
System that already received the message

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageSeenBy-Id'></a>
### Id `property`

##### Summary

Column 'ID'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageSeenBy-Message'></a>
### Message `property`

##### Summary

ForeignKey: MessageSeenBy {'MessageId'} -> Message {'Id'} ToDependent: MessageSeenBies ToPrincipal: Message

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageSeenBy-MessageId'></a>
### MessageId `property`

##### Summary

Column 'MessageId'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-MessageSeenBy-SeenBy'></a>
### SeenBy `property`

##### Summary

Column 'SeenBy'

##### Remarks

Original field type: varchar(50)

<a name='T-Casasoft-BBS-DataTier-DataModel-User'></a>
## User `type`

##### Namespace

Casasoft.BBS.DataTier.DataModel

##### Summary

Elements of the table 'Users':
BBS users

<a name='M-Casasoft-BBS-DataTier-DataModel-User-#ctor'></a>
### #ctor() `constructor`

##### Summary

Entity constructor

##### Parameters

This constructor has no parameters.

<a name='P-Casasoft-BBS-DataTier-DataModel-User-City'></a>
### City `property`

##### Summary

Column 'city'

##### Remarks

Original field type: varchar(50)

<a name='P-Casasoft-BBS-DataTier-DataModel-User-Email'></a>
### Email `property`

##### Summary

Column 'email'

##### Remarks

Original field type: varchar(100)

<a name='P-Casasoft-BBS-DataTier-DataModel-User-LastLoginDate'></a>
### LastLoginDate `property`

##### Summary

Column 'LastLoginDate'

##### Remarks

Original field type: datetime

<a name='P-Casasoft-BBS-DataTier-DataModel-User-LastLoginFrom'></a>
### LastLoginFrom `property`

##### Summary

Column 'LastLoginFrom'

##### Remarks

Original field type: varchar(24)

<a name='P-Casasoft-BBS-DataTier-DataModel-User-LastPasswordModify'></a>
### LastPasswordModify `property`

##### Summary

Column 'LastPasswordModify'

##### Remarks

Original field type: datetime

<a name='P-Casasoft-BBS-DataTier-DataModel-User-Locked'></a>
### Locked `property`

##### Summary

Column 'Locked'

##### Remarks

Original field type:

<a name='P-Casasoft-BBS-DataTier-DataModel-User-Logins'></a>
### Logins `property`

##### Summary

ForeignKey: Login {'UserId'} -> User {'Userid'} ToDependent: Logins ToPrincipal: User

<a name='P-Casasoft-BBS-DataTier-DataModel-User-MessageReads'></a>
### MessageReads `property`

##### Summary

ForeignKey: MessageRead {'UserId'} -> User {'Userid'} ToDependent: MessageReads ToPrincipal: User

<a name='P-Casasoft-BBS-DataTier-DataModel-User-Nation'></a>
### Nation `property`

##### Summary

Column 'nation'

##### Remarks

Original field type: varchar(50)

<a name='P-Casasoft-BBS-DataTier-DataModel-User-Password'></a>
### Password `property`

##### Summary

Column 'password':
MD5 Hash of the password

##### Remarks

Original field type: varchar(32)

<a name='P-Casasoft-BBS-DataTier-DataModel-User-Realname'></a>
### Realname `property`

##### Summary

Column 'realname'

##### Remarks

Original field type: varchar(50)

<a name='P-Casasoft-BBS-DataTier-DataModel-User-Registered'></a>
### Registered `property`

##### Summary

Column 'Registered'

##### Remarks

Original field type: datetime

<a name='P-Casasoft-BBS-DataTier-DataModel-User-Signature'></a>
### Signature `property`

##### Summary

Column 'signature'

##### Remarks

Original field type: text

<a name='P-Casasoft-BBS-DataTier-DataModel-User-Status'></a>
### Status `property`

##### Summary

Column 'status'

##### Remarks

Original field type: varchar(1)

<a name='P-Casasoft-BBS-DataTier-DataModel-User-Userid'></a>
### Userid `property`

##### Summary

Column 'userid'

##### Remarks

Original field type: varchar(30)

<a name='P-Casasoft-BBS-DataTier-DataModel-User-UsersGroupsLinks'></a>
### UsersGroupsLinks `property`

##### Summary

ForeignKey: UsersGroupsLink {'Userid'} -> User {'Userid'} ToDependent: UsersGroupsLinks ToPrincipal: User

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

<a name='T-Casasoft-BBS-DataTier-DataModel-UsersGroup'></a>
## UsersGroup `type`

##### Namespace

Casasoft.BBS.DataTier.DataModel

##### Summary

Elements of the table 'UsersGroups':
Users groups definition

<a name='M-Casasoft-BBS-DataTier-DataModel-UsersGroup-#ctor'></a>
### #ctor() `constructor`

##### Summary

Entity constructor

##### Parameters

This constructor has no parameters.

<a name='P-Casasoft-BBS-DataTier-DataModel-UsersGroup-Description'></a>
### Description `property`

##### Summary

Column 'Description'

##### Remarks

Original field type: varchar(200)

<a name='P-Casasoft-BBS-DataTier-DataModel-UsersGroup-Groupid'></a>
### Groupid `property`

##### Summary

Column 'Groupid'

##### Remarks

Original field type: varchar(30)

<a name='P-Casasoft-BBS-DataTier-DataModel-UsersGroup-MessageAreaAllowedGroupReadNavigations'></a>
### MessageAreaAllowedGroupReadNavigations `property`

##### Summary

ForeignKey: MessageArea {'AllowedGroupRead'} -> UsersGroup {'Groupid'} ToDependent: MessageAreaAllowedGroupReadNavigations ToPrincipal: AllowedGroupReadNavigation

<a name='P-Casasoft-BBS-DataTier-DataModel-UsersGroup-MessageAreaAllowedGroupWriteNavigations'></a>
### MessageAreaAllowedGroupWriteNavigations `property`

##### Summary

ForeignKey: MessageArea {'AllowedGroupWrite'} -> UsersGroup {'Groupid'} ToDependent: MessageAreaAllowedGroupWriteNavigations ToPrincipal: AllowedGroupWriteNavigation

<a name='P-Casasoft-BBS-DataTier-DataModel-UsersGroup-MessageAreasGroups'></a>
### MessageAreasGroups `property`

##### Summary

ForeignKey: MessageAreasGroup {'AllowedGroupId'} -> UsersGroup {'Groupid'} ToDependent: MessageAreasGroups ToPrincipal: AllowedGroup

<a name='P-Casasoft-BBS-DataTier-DataModel-UsersGroup-UsersGroupsLinks'></a>
### UsersGroupsLinks `property`

##### Summary

ForeignKey: UsersGroupsLink {'Groupid'} -> UsersGroup {'Groupid'} ToDependent: UsersGroupsLinks ToPrincipal: Group

<a name='T-Casasoft-BBS-DataTier-DataModel-UsersGroupsLink'></a>
## UsersGroupsLink `type`

##### Namespace

Casasoft.BBS.DataTier.DataModel

##### Summary

Elements of the table 'UsersGroupsLinks':
Users groups

<a name='P-Casasoft-BBS-DataTier-DataModel-UsersGroupsLink-Group'></a>
### Group `property`

##### Summary

ForeignKey: UsersGroupsLink {'Groupid'} -> UsersGroup {'Groupid'} ToDependent: UsersGroupsLinks ToPrincipal: Group

<a name='P-Casasoft-BBS-DataTier-DataModel-UsersGroupsLink-Groupid'></a>
### Groupid `property`

##### Summary

Column 'groupid'

##### Remarks

Original field type: varchar(30)

<a name='P-Casasoft-BBS-DataTier-DataModel-UsersGroupsLink-Id'></a>
### Id `property`

##### Summary

Column 'id'

##### Remarks

Original field type: int(11)

<a name='P-Casasoft-BBS-DataTier-DataModel-UsersGroupsLink-User'></a>
### User `property`

##### Summary

ForeignKey: UsersGroupsLink {'Userid'} -> User {'Userid'} ToDependent: UsersGroupsLinks ToPrincipal: User

<a name='P-Casasoft-BBS-DataTier-DataModel-UsersGroupsLink-Userid'></a>
### Userid `property`

##### Summary

Column 'userid'

##### Remarks

Original field type: varchar(30)

<a name='T-Casasoft-BBS-DataTier-DBContext-bbsContext'></a>
## bbsContext `type`

##### Namespace

Casasoft.BBS.DataTier.DBContext

##### Summary

Model for the database 'bbs'.

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

<a name='P-Casasoft-BBS-DataTier-DBContext-bbsContext-FidoNetworks'></a>
### FidoNetworks `property`

##### Summary

Table 'FidoNetworks':
List of fdo-style networks

<a name='P-Casasoft-BBS-DataTier-DBContext-bbsContext-Logins'></a>
### Logins `property`

##### Summary

Table 'Logins':
Users logins

<a name='P-Casasoft-BBS-DataTier-DBContext-bbsContext-Logs'></a>
### Logs `property`

##### Summary

Table 'Log':
Events log

<a name='P-Casasoft-BBS-DataTier-DBContext-bbsContext-MessageAreas'></a>
### MessageAreas `property`

##### Summary

Table 'MessageAreas':
Message Areas List

<a name='P-Casasoft-BBS-DataTier-DBContext-bbsContext-MessageAreasGroups'></a>
### MessageAreasGroups `property`

##### Summary

Table 'MessageAreasGroups'

<a name='P-Casasoft-BBS-DataTier-DBContext-bbsContext-MessageReads'></a>
### MessageReads `property`

##### Summary

Table 'MessageRead':
Flags for messages read

<a name='P-Casasoft-BBS-DataTier-DBContext-bbsContext-Messages'></a>
### Messages `property`

##### Summary

Table 'Messages':
Messages

<a name='P-Casasoft-BBS-DataTier-DBContext-bbsContext-MessagesSeenBy'></a>
### MessagesSeenBy `property`

##### Summary

Table 'MessageSeenBy':
System that already received the message

<a name='P-Casasoft-BBS-DataTier-DBContext-bbsContext-Users'></a>
### Users `property`

##### Summary

Table 'Users':
BBS users

<a name='P-Casasoft-BBS-DataTier-DBContext-bbsContext-UsersGroups'></a>
### UsersGroups `property`

##### Summary

Table 'UsersGroups':
Users groups definition

<a name='P-Casasoft-BBS-DataTier-DBContext-bbsContext-UsersGroupsLinks'></a>
### UsersGroupsLinks `property`

##### Summary

Table 'UsersGroupsLinks':
Users groups

<a name='M-Casasoft-BBS-DataTier-bbsContext-GetAllMessagesInArea-System-String-'></a>
### GetAllMessagesInArea(area) `method`

##### Summary

Gets the complete list of messages in an echomail area

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| area | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | area to query |

<a name='M-Casasoft-BBS-DataTier-bbsContext-GetAllowedMessageAreasGroup-System-String-'></a>
### GetAllowedMessageAreasGroup(username) `method`

##### Summary

Gets a list of accessible message areas groups for an user

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | user to check |

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

<a name='M-Casasoft-BBS-DataTier-bbsContext-GetMessageById-System-Int32-'></a>
### GetMessageById(messageId) `method`

##### Summary

Gets a message by its Id

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Id of message to retrieve |

<a name='M-Casasoft-BBS-DataTier-bbsContext-GetMessageById-System-String-'></a>
### GetMessageById(messageId) `method`

##### Summary

Gets a message by its Id

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Id of message to retrieve |

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

<a name='M-Casasoft-BBS-DataTier-bbsContext-SetMessageRead-System-Int32,System-String-'></a>
### SetMessageRead(msgId,username) `method`

##### Summary

Mark the message as read by the user

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| msgId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
