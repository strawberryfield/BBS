<a name='assembly'></a>
# BBS.UI

## Contents

- [Banner](#T-Casasoft-BBS-UI-Banner 'Casasoft.BBS.UI.Banner')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-Banner-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.Banner.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-Banner-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.Banner.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,txt)](#M-Casasoft-BBS-UI-Banner-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.Banner.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,txt,prev)](#M-Casasoft-BBS-UI-Banner-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.Banner.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [ShowNext()](#M-Casasoft-BBS-UI-Banner-ShowNext 'Casasoft.BBS.UI.Banner.ShowNext')
- [ChangePassword](#T-Casasoft-BBS-UI-ChangePassword 'Casasoft.BBS.UI.ChangePassword')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-ChangePassword-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.ChangePassword.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-ChangePassword-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.ChangePassword.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,text)](#M-Casasoft-BBS-UI-ChangePassword-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.ChangePassword.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,text,prev)](#M-Casasoft-BBS-UI-ChangePassword-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.ChangePassword.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [password](#F-Casasoft-BBS-UI-ChangePassword-password 'Casasoft.BBS.UI.ChangePassword.password')
  - [status](#F-Casasoft-BBS-UI-ChangePassword-status 'Casasoft.BBS.UI.ChangePassword.status')
  - [user](#F-Casasoft-BBS-UI-ChangePassword-user 'Casasoft.BBS.UI.ChangePassword.user')
  - [HandleMessage(msg)](#M-Casasoft-BBS-UI-ChangePassword-HandleMessage-System-String- 'Casasoft.BBS.UI.ChangePassword.HandleMessage(System.String)')
  - [Show()](#M-Casasoft-BBS-UI-ChangePassword-Show 'Casasoft.BBS.UI.ChangePassword.Show')
  - [Show(CalledFromChild)](#M-Casasoft-BBS-UI-ChangePassword-Show-System-Boolean- 'Casasoft.BBS.UI.ChangePassword.Show(System.Boolean)')
  - [handleWaitForConfirm(msg)](#M-Casasoft-BBS-UI-ChangePassword-handleWaitForConfirm-System-String- 'Casasoft.BBS.UI.ChangePassword.handleWaitForConfirm(System.String)')
  - [handleWaitForNewPassword(msg)](#M-Casasoft-BBS-UI-ChangePassword-handleWaitForNewPassword-System-String- 'Casasoft.BBS.UI.ChangePassword.handleWaitForNewPassword(System.String)')
- [ChangePasswordSu](#T-Casasoft-BBS-UI-ChangePasswordSu 'Casasoft.BBS.UI.ChangePasswordSu')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-ChangePasswordSu-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.ChangePasswordSu.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-ChangePasswordSu-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.ChangePasswordSu.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,text)](#M-Casasoft-BBS-UI-ChangePasswordSu-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.ChangePasswordSu.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,text,prev)](#M-Casasoft-BBS-UI-ChangePasswordSu-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.ChangePasswordSu.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [HandleMessage(msg)](#M-Casasoft-BBS-UI-ChangePasswordSu-HandleMessage-System-String- 'Casasoft.BBS.UI.ChangePasswordSu.HandleMessage(System.String)')
  - [Show()](#M-Casasoft-BBS-UI-ChangePasswordSu-Show 'Casasoft.BBS.UI.ChangePasswordSu.Show')
- [Help](#T-Casasoft-BBS-UI-Help 'Casasoft.BBS.UI.Help')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-Help-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.Help.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-Help-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.Help.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,text)](#M-Casasoft-BBS-UI-Help-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.Help.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,text,prev)](#M-Casasoft-BBS-UI-Help-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.Help.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [ShowHelp()](#M-Casasoft-BBS-UI-Help-ShowHelp 'Casasoft.BBS.UI.Help.ShowHelp')
- [ListConnected](#T-Casasoft-BBS-UI-ListConnected 'Casasoft.BBS.UI.ListConnected')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-ListConnected-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.ListConnected.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-ListConnected-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.ListConnected.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,txt)](#M-Casasoft-BBS-UI-ListConnected-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.ListConnected.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,txt,prev)](#M-Casasoft-BBS-UI-ListConnected-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.ListConnected.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [AddList()](#M-Casasoft-BBS-UI-ListConnected-AddList 'Casasoft.BBS.UI.ListConnected.AddList')
- [ListLogins](#T-Casasoft-BBS-UI-ListLogins 'Casasoft.BBS.UI.ListLogins')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-ListLogins-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.ListLogins.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-ListLogins-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.ListLogins.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,txt)](#M-Casasoft-BBS-UI-ListLogins-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.ListLogins.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,txt,prev)](#M-Casasoft-BBS-UI-ListLogins-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.ListLogins.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [AddList()](#M-Casasoft-BBS-UI-ListLogins-AddList 'Casasoft.BBS.UI.ListLogins.AddList')
- [ListScreenBase](#T-Casasoft-BBS-UI-ListScreenBase 'Casasoft.BBS.UI.ListScreenBase')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-ListScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.ListScreenBase.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-ListScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.ListScreenBase.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,txt)](#M-Casasoft-BBS-UI-ListScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.ListScreenBase.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,txt,prev)](#M-Casasoft-BBS-UI-ListScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.ListScreenBase.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [AddList()](#M-Casasoft-BBS-UI-ListScreenBase-AddList 'Casasoft.BBS.UI.ListScreenBase.AddList')
- [ListUsers](#T-Casasoft-BBS-UI-ListUsers 'Casasoft.BBS.UI.ListUsers')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-ListUsers-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.ListUsers.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-ListUsers-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.ListUsers.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,txt)](#M-Casasoft-BBS-UI-ListUsers-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.ListUsers.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,txt,prev)](#M-Casasoft-BBS-UI-ListUsers-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.ListUsers.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [AddList()](#M-Casasoft-BBS-UI-ListUsers-AddList 'Casasoft.BBS.UI.ListUsers.AddList')
- [LoginScreen](#T-Casasoft-BBS-UI-LoginScreen 'Casasoft.BBS.UI.LoginScreen')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-LoginScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.LoginScreen.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-LoginScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.LoginScreen.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,text)](#M-Casasoft-BBS-UI-LoginScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.LoginScreen.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,text,prev)](#M-Casasoft-BBS-UI-LoginScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.LoginScreen.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [HandleMessage(msg)](#M-Casasoft-BBS-UI-LoginScreen-HandleMessage-System-String- 'Casasoft.BBS.UI.LoginScreen.HandleMessage(System.String)')
  - [Show()](#M-Casasoft-BBS-UI-LoginScreen-Show 'Casasoft.BBS.UI.LoginScreen.Show')
- [Logout](#T-Casasoft-BBS-UI-Logout 'Casasoft.BBS.UI.Logout')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-Logout-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.Logout.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,txt)](#M-Casasoft-BBS-UI-Logout-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.Logout.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-Logout-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.Logout.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,txt,prev)](#M-Casasoft-BBS-UI-Logout-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.Logout.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [Show()](#M-Casasoft-BBS-UI-Logout-Show 'Casasoft.BBS.UI.Logout.Show')
- [MessageAreaGroups](#T-Casasoft-BBS-UI-MessageAreaGroups 'Casasoft.BBS.UI.MessageAreaGroups')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-MessageAreaGroups-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.MessageAreaGroups.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-MessageAreaGroups-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.MessageAreaGroups.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,txt)](#M-Casasoft-BBS-UI-MessageAreaGroups-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.MessageAreaGroups.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,txt,prev)](#M-Casasoft-BBS-UI-MessageAreaGroups-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.MessageAreaGroups.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [AddList()](#M-Casasoft-BBS-UI-MessageAreaGroups-AddList 'Casasoft.BBS.UI.MessageAreaGroups.AddList')
- [MessageAreas](#T-Casasoft-BBS-UI-MessageAreas 'Casasoft.BBS.UI.MessageAreas')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-MessageAreas-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.MessageAreas.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-MessageAreas-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.MessageAreas.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,txt)](#M-Casasoft-BBS-UI-MessageAreas-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.MessageAreas.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,txt,prev)](#M-Casasoft-BBS-UI-MessageAreas-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.MessageAreas.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [AddList()](#M-Casasoft-BBS-UI-MessageAreas-AddList 'Casasoft.BBS.UI.MessageAreas.AddList')
- [NewUser](#T-Casasoft-BBS-UI-NewUser 'Casasoft.BBS.UI.NewUser')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-NewUser-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.NewUser.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-NewUser-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.NewUser.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,txt)](#M-Casasoft-BBS-UI-NewUser-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.NewUser.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,txt,prev)](#M-Casasoft-BBS-UI-NewUser-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.NewUser.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [HandleMessage(msg)](#M-Casasoft-BBS-UI-NewUser-HandleMessage-System-String- 'Casasoft.BBS.UI.NewUser.HandleMessage(System.String)')
  - [Show()](#M-Casasoft-BBS-UI-NewUser-Show 'Casasoft.BBS.UI.NewUser.Show')
- [RawTextScreen](#T-Casasoft-BBS-UI-RawTextScreen 'Casasoft.BBS.UI.RawTextScreen')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-RawTextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.RawTextScreen.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-RawTextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.RawTextScreen.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,txt)](#M-Casasoft-BBS-UI-RawTextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.RawTextScreen.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,txt,prev)](#M-Casasoft-BBS-UI-RawTextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.RawTextScreen.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [ReadText(name)](#M-Casasoft-BBS-UI-RawTextScreen-ReadText-System-String- 'Casasoft.BBS.UI.RawTextScreen.ReadText(System.String)')
- [ScreenBase](#T-Casasoft-BBS-UI-ScreenBase 'Casasoft.BBS.UI.ScreenBase')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-ScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.ScreenBase.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-ScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.ScreenBase.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [ANSI](#F-Casasoft-BBS-UI-ScreenBase-ANSI 'Casasoft.BBS.UI.ScreenBase.ANSI')
  - [client](#F-Casasoft-BBS-UI-ScreenBase-client 'Casasoft.BBS.UI.ScreenBase.client')
  - [server](#F-Casasoft-BBS-UI-ScreenBase-server 'Casasoft.BBS.UI.ScreenBase.server')
  - [Previous](#P-Casasoft-BBS-UI-ScreenBase-Previous 'Casasoft.BBS.UI.ScreenBase.Previous')
  - [ClearLine(row)](#M-Casasoft-BBS-UI-ScreenBase-ClearLine-System-Int32- 'Casasoft.BBS.UI.ScreenBase.ClearLine(System.Int32)')
  - [HandleChar()](#M-Casasoft-BBS-UI-ScreenBase-HandleChar-System-Byte[],System-Int32- 'Casasoft.BBS.UI.ScreenBase.HandleChar(System.Byte[],System.Int32)')
  - [HandleControlC()](#M-Casasoft-BBS-UI-ScreenBase-HandleControlC 'Casasoft.BBS.UI.ScreenBase.HandleControlC')
  - [HandleCursorDown()](#M-Casasoft-BBS-UI-ScreenBase-HandleCursorDown 'Casasoft.BBS.UI.ScreenBase.HandleCursorDown')
  - [HandleCursorLeft()](#M-Casasoft-BBS-UI-ScreenBase-HandleCursorLeft 'Casasoft.BBS.UI.ScreenBase.HandleCursorLeft')
  - [HandleCursorRight()](#M-Casasoft-BBS-UI-ScreenBase-HandleCursorRight 'Casasoft.BBS.UI.ScreenBase.HandleCursorRight')
  - [HandleCursorUp()](#M-Casasoft-BBS-UI-ScreenBase-HandleCursorUp 'Casasoft.BBS.UI.ScreenBase.HandleCursorUp')
  - [HandleESC()](#M-Casasoft-BBS-UI-ScreenBase-HandleESC 'Casasoft.BBS.UI.ScreenBase.HandleESC')
  - [HandleEnd()](#M-Casasoft-BBS-UI-ScreenBase-HandleEnd 'Casasoft.BBS.UI.ScreenBase.HandleEnd')
  - [HandleF1()](#M-Casasoft-BBS-UI-ScreenBase-HandleF1 'Casasoft.BBS.UI.ScreenBase.HandleF1')
  - [HandleF2()](#M-Casasoft-BBS-UI-ScreenBase-HandleF2 'Casasoft.BBS.UI.ScreenBase.HandleF2')
  - [HandleF3()](#M-Casasoft-BBS-UI-ScreenBase-HandleF3 'Casasoft.BBS.UI.ScreenBase.HandleF3')
  - [HandleF4()](#M-Casasoft-BBS-UI-ScreenBase-HandleF4 'Casasoft.BBS.UI.ScreenBase.HandleF4')
  - [HandleHome()](#M-Casasoft-BBS-UI-ScreenBase-HandleHome 'Casasoft.BBS.UI.ScreenBase.HandleHome')
  - [HandleMessage()](#M-Casasoft-BBS-UI-ScreenBase-HandleMessage-System-String- 'Casasoft.BBS.UI.ScreenBase.HandleMessage(System.String)')
  - [HandlePageDown()](#M-Casasoft-BBS-UI-ScreenBase-HandlePageDown 'Casasoft.BBS.UI.ScreenBase.HandlePageDown')
  - [HandlePageUp()](#M-Casasoft-BBS-UI-ScreenBase-HandlePageUp 'Casasoft.BBS.UI.ScreenBase.HandlePageUp')
  - [HandleTab()](#M-Casasoft-BBS-UI-ScreenBase-HandleTab 'Casasoft.BBS.UI.ScreenBase.HandleTab')
  - [LnWrite(s)](#M-Casasoft-BBS-UI-ScreenBase-LnWrite-System-String- 'Casasoft.BBS.UI.ScreenBase.LnWrite(System.String)')
  - [MoveTo(row,col)](#M-Casasoft-BBS-UI-ScreenBase-MoveTo-System-Int32,System-Int32- 'Casasoft.BBS.UI.ScreenBase.MoveTo(System.Int32,System.Int32)')
  - [Show()](#M-Casasoft-BBS-UI-ScreenBase-Show 'Casasoft.BBS.UI.ScreenBase.Show')
  - [ShowNext()](#M-Casasoft-BBS-UI-ScreenBase-ShowNext 'Casasoft.BBS.UI.ScreenBase.ShowNext')
  - [Write(s)](#M-Casasoft-BBS-UI-ScreenBase-Write-System-String- 'Casasoft.BBS.UI.ScreenBase.Write(System.String)')
  - [Writeln(s)](#M-Casasoft-BBS-UI-ScreenBase-Writeln-System-String- 'Casasoft.BBS.UI.ScreenBase.Writeln(System.String)')
  - [Writeln()](#M-Casasoft-BBS-UI-ScreenBase-Writeln 'Casasoft.BBS.UI.ScreenBase.Writeln')
- [TextScreen](#T-Casasoft-BBS-UI-TextScreen 'Casasoft.BBS.UI.TextScreen')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-TextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.TextScreen.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-TextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.TextScreen.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,txt)](#M-Casasoft-BBS-UI-TextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.TextScreen.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,txt,prev)](#M-Casasoft-BBS-UI-TextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.TextScreen.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
- [TextScreenBase](#T-Casasoft-BBS-UI-TextScreenBase 'Casasoft.BBS.UI.TextScreenBase')
  - [#ctor(c,s)](#M-Casasoft-BBS-UI-TextScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer- 'Casasoft.BBS.UI.TextScreenBase.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer)')
  - [#ctor(c,s,prev)](#M-Casasoft-BBS-UI-TextScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.TextScreenBase.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,Casasoft.BBS.Interfaces.IScreen)')
  - [#ctor(c,s,txt)](#M-Casasoft-BBS-UI-TextScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.UI.TextScreenBase.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [#ctor(c,s,txt,prev)](#M-Casasoft-BBS-UI-TextScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.UI.TextScreenBase.#ctor(Casasoft.BBS.Interfaces.IBBSClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [Data](#F-Casasoft-BBS-UI-TextScreenBase-Data 'Casasoft.BBS.UI.TextScreenBase.Data')
  - [Footer](#F-Casasoft-BBS-UI-TextScreenBase-Footer 'Casasoft.BBS.UI.TextScreenBase.Footer')
  - [Header](#F-Casasoft-BBS-UI-TextScreenBase-Header 'Casasoft.BBS.UI.TextScreenBase.Header')
  - [Params](#F-Casasoft-BBS-UI-TextScreenBase-Params 'Casasoft.BBS.UI.TextScreenBase.Params')
  - [Text](#F-Casasoft-BBS-UI-TextScreenBase-Text 'Casasoft.BBS.UI.TextScreenBase.Text')
  - [currentLine](#F-Casasoft-BBS-UI-TextScreenBase-currentLine 'Casasoft.BBS.UI.TextScreenBase.currentLine')
  - [dataAreaSize](#F-Casasoft-BBS-UI-TextScreenBase-dataAreaSize 'Casasoft.BBS.UI.TextScreenBase.dataAreaSize')
  - [dataAreaStart](#F-Casasoft-BBS-UI-TextScreenBase-dataAreaStart 'Casasoft.BBS.UI.TextScreenBase.dataAreaStart')
  - [firstDisplayedLine](#F-Casasoft-BBS-UI-TextScreenBase-firstDisplayedLine 'Casasoft.BBS.UI.TextScreenBase.firstDisplayedLine')
  - [ClearBody()](#M-Casasoft-BBS-UI-TextScreenBase-ClearBody 'Casasoft.BBS.UI.TextScreenBase.ClearBody')
  - [GetFile(data)](#M-Casasoft-BBS-UI-TextScreenBase-GetFile-System-String- 'Casasoft.BBS.UI.TextScreenBase.GetFile(System.String)')
  - [HandleChar(data,bytesReceived)](#M-Casasoft-BBS-UI-TextScreenBase-HandleChar-System-Byte[],System-Int32- 'Casasoft.BBS.UI.TextScreenBase.HandleChar(System.Byte[],System.Int32)')
  - [HandleControlC()](#M-Casasoft-BBS-UI-TextScreenBase-HandleControlC 'Casasoft.BBS.UI.TextScreenBase.HandleControlC')
  - [HandleEnd()](#M-Casasoft-BBS-UI-TextScreenBase-HandleEnd 'Casasoft.BBS.UI.TextScreenBase.HandleEnd')
  - [HandleF1()](#M-Casasoft-BBS-UI-TextScreenBase-HandleF1 'Casasoft.BBS.UI.TextScreenBase.HandleF1')
  - [HandleHalfPageDown()](#M-Casasoft-BBS-UI-TextScreenBase-HandleHalfPageDown 'Casasoft.BBS.UI.TextScreenBase.HandleHalfPageDown')
  - [HandleHalfPageUp()](#M-Casasoft-BBS-UI-TextScreenBase-HandleHalfPageUp 'Casasoft.BBS.UI.TextScreenBase.HandleHalfPageUp')
  - [HandleHome()](#M-Casasoft-BBS-UI-TextScreenBase-HandleHome 'Casasoft.BBS.UI.TextScreenBase.HandleHome')
  - [HandleMessage(msg)](#M-Casasoft-BBS-UI-TextScreenBase-HandleMessage-System-String- 'Casasoft.BBS.UI.TextScreenBase.HandleMessage(System.String)')
  - [HandlePageDown()](#M-Casasoft-BBS-UI-TextScreenBase-HandlePageDown 'Casasoft.BBS.UI.TextScreenBase.HandlePageDown')
  - [HandlePageUp()](#M-Casasoft-BBS-UI-TextScreenBase-HandlePageUp 'Casasoft.BBS.UI.TextScreenBase.HandlePageUp')
  - [HandleRedraw()](#M-Casasoft-BBS-UI-TextScreenBase-HandleRedraw 'Casasoft.BBS.UI.TextScreenBase.HandleRedraw')
  - [ReadText(name)](#M-Casasoft-BBS-UI-TextScreenBase-ReadText-System-String- 'Casasoft.BBS.UI.TextScreenBase.ReadText(System.String)')
  - [Redraw()](#M-Casasoft-BBS-UI-TextScreenBase-Redraw 'Casasoft.BBS.UI.TextScreenBase.Redraw')
  - [Show()](#M-Casasoft-BBS-UI-TextScreenBase-Show 'Casasoft.BBS.UI.TextScreenBase.Show')
  - [ShowHelp()](#M-Casasoft-BBS-UI-TextScreenBase-ShowHelp 'Casasoft.BBS.UI.TextScreenBase.ShowHelp')
  - [ShowLines(lines,start,len,offset)](#M-Casasoft-BBS-UI-TextScreenBase-ShowLines-System-Collections-Generic-List{System-String},System-Int32,System-Int32,System-Int32- 'Casasoft.BBS.UI.TextScreenBase.ShowLines(System.Collections.Generic.List{System.String},System.Int32,System.Int32,System.Int32)')
  - [ShowLines(start,len)](#M-Casasoft-BBS-UI-TextScreenBase-ShowLines-System-Int32,System-Int32- 'Casasoft.BBS.UI.TextScreenBase.ShowLines(System.Int32,System.Int32)')
  - [ShowLines(start)](#M-Casasoft-BBS-UI-TextScreenBase-ShowLines-System-Int32- 'Casasoft.BBS.UI.TextScreenBase.ShowLines(System.Int32)')
  - [ShowLines()](#M-Casasoft-BBS-UI-TextScreenBase-ShowLines 'Casasoft.BBS.UI.TextScreenBase.ShowLines')
  - [ShowNext()](#M-Casasoft-BBS-UI-TextScreenBase-ShowNext 'Casasoft.BBS.UI.TextScreenBase.ShowNext')
  - [execAction(act)](#M-Casasoft-BBS-UI-TextScreenBase-execAction-System-String- 'Casasoft.BBS.UI.TextScreenBase.execAction(System.String)')
- [states](#T-Casasoft-BBS-UI-ChangePassword-states 'Casasoft.BBS.UI.ChangePassword.states')

<a name='T-Casasoft-BBS-UI-Banner'></a>
## Banner `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Implements the screen shown at cliente connection

<a name='M-Casasoft-BBS-UI-Banner-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-Banner-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-Banner-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,txt) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-Banner-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,txt,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-Banner-ShowNext'></a>
### ShowNext() `method`

##### Summary

Sets default action to [LoginScreen](#T-Casasoft-BBS-UI-LoginScreen 'Casasoft.BBS.UI.LoginScreen')

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-UI-ChangePassword'></a>
## ChangePassword `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Change password dialog

<a name='M-Casasoft-BBS-UI-ChangePassword-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-ChangePassword-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-ChangePassword-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,text) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-ChangePassword-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,text,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='F-Casasoft-BBS-UI-ChangePassword-password'></a>
### password `constants`

##### Summary

password temporary storage

<a name='F-Casasoft-BBS-UI-ChangePassword-status'></a>
### status `constants`

##### Summary

current loop status

<a name='F-Casasoft-BBS-UI-ChangePassword-user'></a>
### user `constants`

##### Summary

user temporary storage

<a name='M-Casasoft-BBS-UI-ChangePassword-HandleMessage-System-String-'></a>
### HandleMessage(msg) `method`

##### Summary

Dialog event loop

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| msg | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-UI-ChangePassword-Show'></a>
### Show() `method`

##### Summary

Starts dialog

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ChangePassword-Show-System-Boolean-'></a>
### Show(CalledFromChild) `method`

##### Summary

Starts dialog

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| CalledFromChild | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | dummy parameter to create an override |

<a name='M-Casasoft-BBS-UI-ChangePassword-handleWaitForConfirm-System-String-'></a>
### handleWaitForConfirm(msg) `method`

##### Summary

check if retyped password match the first inserted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| msg | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-UI-ChangePassword-handleWaitForNewPassword-System-String-'></a>
### handleWaitForNewPassword(msg) `method`

##### Summary

checks if password meets security criteria

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| msg | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | candidate password |

<a name='T-Casasoft-BBS-UI-ChangePasswordSu'></a>
## ChangePasswordSu `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Change password in superuser mode

<a name='M-Casasoft-BBS-UI-ChangePasswordSu-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-ChangePasswordSu-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-ChangePasswordSu-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,text) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-ChangePasswordSu-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,text,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-ChangePasswordSu-HandleMessage-System-String-'></a>
### HandleMessage(msg) `method`

##### Summary

Dialog event loop

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| msg | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-UI-ChangePasswordSu-Show'></a>
### Show() `method`

##### Summary

Starts dialog

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-UI-Help'></a>
## Help `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Help screen

<a name='M-Casasoft-BBS-UI-Help-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-Help-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-Help-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,text) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-Help-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,text,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-Help-ShowHelp'></a>
### ShowHelp() `method`

##### Summary

Prevents recursive launch of the help

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-UI-ListConnected'></a>
## ListConnected `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Implements list of connected users

<a name='M-Casasoft-BBS-UI-ListConnected-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-ListConnected-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-ListConnected-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,txt) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-ListConnected-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,txt,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-ListConnected-AddList'></a>
### AddList() `method`

##### Summary

Fills the connected users list

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-UI-ListLogins'></a>
## ListLogins `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Implements list of user's logins

<a name='M-Casasoft-BBS-UI-ListLogins-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-ListLogins-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-ListLogins-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,txt) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-ListLogins-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,txt,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-ListLogins-AddList'></a>
### AddList() `method`

##### Summary

Fills the user's logins list

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-UI-ListScreenBase'></a>
## ListScreenBase `type`

##### Namespace

Casasoft.BBS.UI

<a name='M-Casasoft-BBS-UI-ListScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-ListScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-ListScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,txt) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-ListScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,txt,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-ListScreenBase-AddList'></a>
### AddList() `method`

##### Summary

Empty virtual function where data lines will be added

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-UI-ListUsers'></a>
## ListUsers `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Implements the registered users list

<a name='M-Casasoft-BBS-UI-ListUsers-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-ListUsers-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-ListUsers-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,txt) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-ListUsers-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,txt,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-ListUsers-AddList'></a>
### AddList() `method`

##### Summary

Fills the registered users list

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-UI-LoginScreen'></a>
## LoginScreen `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Handles user login

<a name='M-Casasoft-BBS-UI-LoginScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-LoginScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-LoginScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,text) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-LoginScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,text,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-LoginScreen-HandleMessage-System-String-'></a>
### HandleMessage(msg) `method`

##### Summary

Dialog events loop

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| msg | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-UI-LoginScreen-Show'></a>
### Show() `method`

##### Summary

Starts the login form

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-UI-Logout'></a>
## Logout `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Message before disconnection

<a name='M-Casasoft-BBS-UI-Logout-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-Logout-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,txt) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-Logout-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-Logout-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,txt,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-Logout-Show'></a>
### Show() `method`

##### Summary

Shows the message and force disconnection

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-UI-MessageAreaGroups'></a>
## MessageAreaGroups `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Implements the list of message areas groups

<a name='M-Casasoft-BBS-UI-MessageAreaGroups-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-MessageAreaGroups-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-MessageAreaGroups-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,txt) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-MessageAreaGroups-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,txt,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-MessageAreaGroups-AddList'></a>
### AddList() `method`

##### Summary

Fills area groups list

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-UI-MessageAreas'></a>
## MessageAreas `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Implements the list of message areas

<a name='M-Casasoft-BBS-UI-MessageAreas-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-MessageAreas-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-MessageAreas-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,txt) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-MessageAreas-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,txt,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-MessageAreas-AddList'></a>
### AddList() `method`

##### Summary

Fills the messages area list

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-UI-NewUser'></a>
## NewUser `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Form to register as a new user

<a name='M-Casasoft-BBS-UI-NewUser-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-NewUser-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-NewUser-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,txt) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-NewUser-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,txt,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-NewUser-HandleMessage-System-String-'></a>
### HandleMessage(msg) `method`

##### Summary

Dialog events loop

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| msg | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-UI-NewUser-Show'></a>
### Show() `method`

##### Summary

Starts new user dialog

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-UI-RawTextScreen'></a>
## RawTextScreen `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Shows a raw text file

<a name='M-Casasoft-BBS-UI-RawTextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-RawTextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-RawTextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,txt) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-RawTextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,txt,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-RawTextScreen-ReadText-System-String-'></a>
### ReadText(name) `method`

##### Summary

Reads the text and stores it in lists of lines

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File to load |

<a name='T-Casasoft-BBS-UI-ScreenBase'></a>
## ScreenBase `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Implements an empty base screen

<a name='M-Casasoft-BBS-UI-ScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor without link to caller

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Reference to client |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Reference to server |

<a name='M-Casasoft-BBS-UI-ScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Reference to client |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Reference to server |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='F-Casasoft-BBS-UI-ScreenBase-ANSI'></a>
### ANSI `constants`

##### Summary

Instance of ANSI utilities

<a name='F-Casasoft-BBS-UI-ScreenBase-client'></a>
### client `constants`

##### Summary

Reference to Telnet client

<a name='F-Casasoft-BBS-UI-ScreenBase-server'></a>
### server `constants`

##### Summary

Reference to Telnet server

<a name='P-Casasoft-BBS-UI-ScreenBase-Previous'></a>
### Previous `property`

##### Summary

Pointer to caller screen (if any)

<a name='M-Casasoft-BBS-UI-ScreenBase-ClearLine-System-Int32-'></a>
### ClearLine(row) `method`

##### Summary

Clears a row in the terminal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| row | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleChar-System-Byte[],System-Int32-'></a>
### HandleChar() `method`

##### Summary

Launch of empty implementations of keys received handles

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleControlC'></a>
### HandleControlC() `method`

##### Summary

Empty implementation of Ctrl-C handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleCursorDown'></a>
### HandleCursorDown() `method`

##### Summary

Empty implementation of Cursor-Down handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleCursorLeft'></a>
### HandleCursorLeft() `method`

##### Summary

Empty implementation of Cursor-Left handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleCursorRight'></a>
### HandleCursorRight() `method`

##### Summary

Empty implementation of Cursor-Right handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleCursorUp'></a>
### HandleCursorUp() `method`

##### Summary

Empty implementation of Cursor-Up handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleESC'></a>
### HandleESC() `method`

##### Summary

Empty implementation of ESC handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleEnd'></a>
### HandleEnd() `method`

##### Summary

Empty implementation of End handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleF1'></a>
### HandleF1() `method`

##### Summary

Empty implementation of F1 handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleF2'></a>
### HandleF2() `method`

##### Summary

Empty implementation of F2 handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleF3'></a>
### HandleF3() `method`

##### Summary

Empty implementation of F3 handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleF4'></a>
### HandleF4() `method`

##### Summary

Empty implementation of F4 handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleHome'></a>
### HandleHome() `method`

##### Summary

Empty implementation of Home handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleMessage-System-String-'></a>
### HandleMessage() `method`

##### Summary

Empty implementation to ovverride in derived classes

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandlePageDown'></a>
### HandlePageDown() `method`

##### Summary

Empty implementation of Cursor-Down handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandlePageUp'></a>
### HandlePageUp() `method`

##### Summary

Empty implementation of Page-Up handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-HandleTab'></a>
### HandleTab() `method`

##### Summary

Empty implementation of Tab handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-LnWrite-System-String-'></a>
### LnWrite(s) `method`

##### Summary

Writes a string to the terminal with a preceding newline

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-UI-ScreenBase-MoveTo-System-Int32,System-Int32-'></a>
### MoveTo(row,col) `method`

##### Summary

Moves the cursor in the terminal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| row | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| col | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Casasoft-BBS-UI-ScreenBase-Show'></a>
### Show() `method`

##### Summary

Empty implementation to ovverride in derived classes

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-ShowNext'></a>
### ShowNext() `method`

##### Summary

Empty implementation to ovverride in derived classes

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-ScreenBase-Write-System-String-'></a>
### Write(s) `method`

##### Summary

Writes a string to the terminal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-UI-ScreenBase-Writeln-System-String-'></a>
### Writeln(s) `method`

##### Summary

Writes a string to the terminal follewed by a newline

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-UI-ScreenBase-Writeln'></a>
### Writeln() `method`

##### Summary

Writes a newline to the terminal

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-UI-TextScreen'></a>
## TextScreen `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Generic Text Screen module

<a name='M-Casasoft-BBS-UI-TextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-TextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-TextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,txt) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-TextScreen-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,txt,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='T-Casasoft-BBS-UI-TextScreenBase'></a>
## TextScreenBase `type`

##### Namespace

Casasoft.BBS.UI

##### Summary

Implements a text based screen

<a name='M-Casasoft-BBS-UI-TextScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer-'></a>
### #ctor(c,s) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |

<a name='M-Casasoft-BBS-UI-TextScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,prev) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='M-Casasoft-BBS-UI-TextScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### #ctor(c,s,txt) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |

<a name='M-Casasoft-BBS-UI-TextScreenBase-#ctor-Casasoft-BBS-Interfaces-IBBSClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### #ctor(c,s,txt,prev) `constructor`

##### Summary

Complete constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient') | Client reference |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server reference |
| txt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to parse and optional parameters separated by semicolon |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Link to caller screen |

<a name='F-Casasoft-BBS-UI-TextScreenBase-Data'></a>
### Data `constants`

##### Summary

Result of text parsing

<a name='F-Casasoft-BBS-UI-TextScreenBase-Footer'></a>
### Footer `constants`

##### Summary

Lines of text Footer

<a name='F-Casasoft-BBS-UI-TextScreenBase-Header'></a>
### Header `constants`

##### Summary

Lines of text header

<a name='F-Casasoft-BBS-UI-TextScreenBase-Params'></a>
### Params `constants`

##### Summary

List of supplied arguments

<a name='F-Casasoft-BBS-UI-TextScreenBase-Text'></a>
### Text `constants`

##### Summary

Lines of text body

<a name='F-Casasoft-BBS-UI-TextScreenBase-currentLine'></a>
### currentLine `constants`

##### Summary

Current line of text body

<a name='F-Casasoft-BBS-UI-TextScreenBase-dataAreaSize'></a>
### dataAreaSize `constants`

##### Summary

Rows available for text body

<a name='F-Casasoft-BBS-UI-TextScreenBase-dataAreaStart'></a>
### dataAreaStart `constants`

##### Summary

First row for text body

<a name='F-Casasoft-BBS-UI-TextScreenBase-firstDisplayedLine'></a>
### firstDisplayedLine `constants`

##### Summary

First line of text body shown

<a name='M-Casasoft-BBS-UI-TextScreenBase-ClearBody'></a>
### ClearBody() `method`

##### Summary

Clears all lines of the text body

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-TextScreenBase-GetFile-System-String-'></a>
### GetFile(data) `method`

##### Summary

Returns complete pathname of the file

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-UI-TextScreenBase-HandleChar-System-Byte[],System-Int32-'></a>
### HandleChar(data,bytesReceived) `method`

##### Summary

Processes special chars sequences received from the terminal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | Buffer with data received |
| bytesReceived | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of bytes in the buffer |

<a name='M-Casasoft-BBS-UI-TextScreenBase-HandleControlC'></a>
### HandleControlC() `method`

##### Summary

Implements Ctrl-C handler

##### Parameters

This method has no parameters.

##### Remarks

Return to previous screen if exists or logout

<a name='M-Casasoft-BBS-UI-TextScreenBase-HandleEnd'></a>
### HandleEnd() `method`

##### Summary

Implements End Handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-TextScreenBase-HandleF1'></a>
### HandleF1() `method`

##### Summary

Implements F1 Handler

##### Parameters

This method has no parameters.

##### Remarks

Shows help screen

<a name='M-Casasoft-BBS-UI-TextScreenBase-HandleHalfPageDown'></a>
### HandleHalfPageDown() `method`

##### Summary

Implements Half-Page-Down Handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-TextScreenBase-HandleHalfPageUp'></a>
### HandleHalfPageUp() `method`

##### Summary

Implements Half-Page-Up Handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-TextScreenBase-HandleHome'></a>
### HandleHome() `method`

##### Summary

Implements Home Handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-TextScreenBase-HandleMessage-System-String-'></a>
### HandleMessage(msg) `method`

##### Summary

Processes message received from the client

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| msg | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-UI-TextScreenBase-HandlePageDown'></a>
### HandlePageDown() `method`

##### Summary

Implements Page-Down Handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-TextScreenBase-HandlePageUp'></a>
### HandlePageUp() `method`

##### Summary

Implements Page-Up Handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-TextScreenBase-HandleRedraw'></a>
### HandleRedraw() `method`

##### Summary

Implements Screen Redraw Handler

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-TextScreenBase-ReadText-System-String-'></a>
### ReadText(name) `method`

##### Summary

Reads the text and stores it in lists of lines

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File to load |

<a name='M-Casasoft-BBS-UI-TextScreenBase-Redraw'></a>
### Redraw() `method`

##### Summary

Redraws the screen

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-TextScreenBase-Show'></a>
### Show() `method`

##### Summary

Displays the text

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-TextScreenBase-ShowHelp'></a>
### ShowHelp() `method`

##### Summary

Shows help screen

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-TextScreenBase-ShowLines-System-Collections-Generic-List{System-String},System-Int32,System-Int32,System-Int32-'></a>
### ShowLines(lines,start,len,offset) `method`

##### Summary

Draws lines of text

##### Returns

last line of text written

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lines | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | Section to draw |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | first line of text to draw |
| len | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number of text lines to draw |
| offset | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | first line of screen to use |

<a name='M-Casasoft-BBS-UI-TextScreenBase-ShowLines-System-Int32,System-Int32-'></a>
### ShowLines(start,len) `method`

##### Summary

Draws lines of the text body

##### Returns

last line of text written

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | first line of text to draw |
| len | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number of text lines to draw |

##### Remarks

first screen line used is [dataAreaStart](#F-Casasoft-BBS-UI-TextScreenBase-dataAreaStart 'Casasoft.BBS.UI.TextScreenBase.dataAreaStart')

<a name='M-Casasoft-BBS-UI-TextScreenBase-ShowLines-System-Int32-'></a>
### ShowLines(start) `method`

##### Summary

Draws lines of the text body

##### Returns

last line of text written

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | first line of text to draw |

##### Remarks

first screen line used is [dataAreaStart](#F-Casasoft-BBS-UI-TextScreenBase-dataAreaStart 'Casasoft.BBS.UI.TextScreenBase.dataAreaStart')
maximum number of lines written is [dataAreaSize](#F-Casasoft-BBS-UI-TextScreenBase-dataAreaSize 'Casasoft.BBS.UI.TextScreenBase.dataAreaSize')

<a name='M-Casasoft-BBS-UI-TextScreenBase-ShowLines'></a>
### ShowLines() `method`

##### Summary

Draws lines of the text body

##### Returns

last line of text written

##### Parameters

This method has no parameters.

##### Remarks

first drawed line is stored in [firstDisplayedLine](#F-Casasoft-BBS-UI-TextScreenBase-firstDisplayedLine 'Casasoft.BBS.UI.TextScreenBase.firstDisplayedLine')
first screen line used is [dataAreaStart](#F-Casasoft-BBS-UI-TextScreenBase-dataAreaStart 'Casasoft.BBS.UI.TextScreenBase.dataAreaStart')
maximum number of lines written is [dataAreaSize](#F-Casasoft-BBS-UI-TextScreenBase-dataAreaSize 'Casasoft.BBS.UI.TextScreenBase.dataAreaSize')

<a name='M-Casasoft-BBS-UI-TextScreenBase-ShowNext'></a>
### ShowNext() `method`

##### Summary

Launches default action

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-UI-TextScreenBase-execAction-System-String-'></a>
### execAction(act) `method`

##### Summary

Exec action by name

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| act | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text entered to trigger the action |

<a name='T-Casasoft-BBS-UI-ChangePassword-states'></a>
## states `type`

##### Namespace

Casasoft.BBS.UI.ChangePassword

##### Summary

list of states
