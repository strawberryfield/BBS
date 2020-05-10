<a name='assembly'></a>
# BBS.Interfaces

## Contents

- [EClientStatus](#T-Casasoft-BBS-Interfaces-EClientStatus 'Casasoft.BBS.Interfaces.EClientStatus')
  - [Authenticating](#F-Casasoft-BBS-Interfaces-EClientStatus-Authenticating 'Casasoft.BBS.Interfaces.EClientStatus.Authenticating')
  - [Guest](#F-Casasoft-BBS-Interfaces-EClientStatus-Guest 'Casasoft.BBS.Interfaces.EClientStatus.Guest')
  - [LoggedIn](#F-Casasoft-BBS-Interfaces-EClientStatus-LoggedIn 'Casasoft.BBS.Interfaces.EClientStatus.LoggedIn')
- [IBBSClient](#T-Casasoft-BBS-Interfaces-IBBSClient 'Casasoft.BBS.Interfaces.IBBSClient')
  - [screen](#P-Casasoft-BBS-Interfaces-IBBSClient-screen 'Casasoft.BBS.Interfaces.IBBSClient.screen')
  - [screenHeight](#P-Casasoft-BBS-Interfaces-IBBSClient-screenHeight 'Casasoft.BBS.Interfaces.IBBSClient.screenHeight')
  - [screenWidth](#P-Casasoft-BBS-Interfaces-IBBSClient-screenWidth 'Casasoft.BBS.Interfaces.IBBSClient.screenWidth')
  - [terminalType](#P-Casasoft-BBS-Interfaces-IBBSClient-terminalType 'Casasoft.BBS.Interfaces.IBBSClient.terminalType')
  - [terminalTypeCapable](#P-Casasoft-BBS-Interfaces-IBBSClient-terminalTypeCapable 'Casasoft.BBS.Interfaces.IBBSClient.terminalTypeCapable')
  - [TryAddTerminalType(tt)](#M-Casasoft-BBS-Interfaces-IBBSClient-TryAddTerminalType-System-String- 'Casasoft.BBS.Interfaces.IBBSClient.TryAddTerminalType(System.String)')
- [IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient')
  - [Remote](#P-Casasoft-BBS-Interfaces-IClient-Remote 'Casasoft.BBS.Interfaces.IClient.Remote')
  - [connectedAt](#P-Casasoft-BBS-Interfaces-IClient-connectedAt 'Casasoft.BBS.Interfaces.IClient.connectedAt')
  - [id](#P-Casasoft-BBS-Interfaces-IClient-id 'Casasoft.BBS.Interfaces.IClient.id')
  - [lastActivity](#P-Casasoft-BBS-Interfaces-IClient-lastActivity 'Casasoft.BBS.Interfaces.IClient.lastActivity')
  - [receivedData](#P-Casasoft-BBS-Interfaces-IClient-receivedData 'Casasoft.BBS.Interfaces.IClient.receivedData')
  - [remoteAddr](#P-Casasoft-BBS-Interfaces-IClient-remoteAddr 'Casasoft.BBS.Interfaces.IClient.remoteAddr')
  - [status](#P-Casasoft-BBS-Interfaces-IClient-status 'Casasoft.BBS.Interfaces.IClient.status')
  - [username](#P-Casasoft-BBS-Interfaces-IClient-username 'Casasoft.BBS.Interfaces.IClient.username')
  - [appendReceivedData(dataToAppend)](#M-Casasoft-BBS-Interfaces-IClient-appendReceivedData-System-String- 'Casasoft.BBS.Interfaces.IClient.appendReceivedData(System.String)')
  - [removeLastCharacterReceived()](#M-Casasoft-BBS-Interfaces-IClient-removeLastCharacterReceived 'Casasoft.BBS.Interfaces.IClient.removeLastCharacterReceived')
  - [resetReceivedData()](#M-Casasoft-BBS-Interfaces-IClient-resetReceivedData 'Casasoft.BBS.Interfaces.IClient.resetReceivedData')
- [IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen')
  - [Previous](#P-Casasoft-BBS-Interfaces-IScreen-Previous 'Casasoft.BBS.Interfaces.IScreen.Previous')
  - [HandleChar(data,bytesReceived)](#M-Casasoft-BBS-Interfaces-IScreen-HandleChar-System-Byte[],System-Int32- 'Casasoft.BBS.Interfaces.IScreen.HandleChar(System.Byte[],System.Int32)')
  - [HandleMessage(msg)](#M-Casasoft-BBS-Interfaces-IScreen-HandleMessage-System-String- 'Casasoft.BBS.Interfaces.IScreen.HandleMessage(System.String)')
  - [Show()](#M-Casasoft-BBS-Interfaces-IScreen-Show 'Casasoft.BBS.Interfaces.IScreen.Show')
  - [ShowNext()](#M-Casasoft-BBS-Interfaces-IScreen-ShowNext 'Casasoft.BBS.Interfaces.IScreen.ShowNext')
- [IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer')
  - [clients](#P-Casasoft-BBS-Interfaces-IServer-clients 'Casasoft.BBS.Interfaces.IServer.clients')
  - [ClearLastInput(c)](#M-Casasoft-BBS-Interfaces-IServer-ClearLastInput-Casasoft-BBS-Interfaces-IClient- 'Casasoft.BBS.Interfaces.IServer.ClearLastInput(Casasoft.BBS.Interfaces.IClient)')
  - [allowIncomingConnections()](#M-Casasoft-BBS-Interfaces-IServer-allowIncomingConnections 'Casasoft.BBS.Interfaces.IServer.allowIncomingConnections')
  - [clearClientScreen(c)](#M-Casasoft-BBS-Interfaces-IServer-clearClientScreen-Casasoft-BBS-Interfaces-IClient- 'Casasoft.BBS.Interfaces.IServer.clearClientScreen(Casasoft.BBS.Interfaces.IClient)')
  - [denyIncomingConnections()](#M-Casasoft-BBS-Interfaces-IServer-denyIncomingConnections 'Casasoft.BBS.Interfaces.IServer.denyIncomingConnections')
  - [incomingConnectionsAllowed()](#M-Casasoft-BBS-Interfaces-IServer-incomingConnectionsAllowed 'Casasoft.BBS.Interfaces.IServer.incomingConnectionsAllowed')
  - [kickClient(client)](#M-Casasoft-BBS-Interfaces-IServer-kickClient-Casasoft-BBS-Interfaces-IClient- 'Casasoft.BBS.Interfaces.IServer.kickClient(Casasoft.BBS.Interfaces.IClient)')
  - [sendMessageToAll(message)](#M-Casasoft-BBS-Interfaces-IServer-sendMessageToAll-System-String- 'Casasoft.BBS.Interfaces.IServer.sendMessageToAll(System.String)')
  - [sendMessageToClient(c,message)](#M-Casasoft-BBS-Interfaces-IServer-sendMessageToClient-Casasoft-BBS-Interfaces-IClient,System-String- 'Casasoft.BBS.Interfaces.IServer.sendMessageToClient(Casasoft.BBS.Interfaces.IClient,System.String)')
  - [start()](#M-Casasoft-BBS-Interfaces-IServer-start 'Casasoft.BBS.Interfaces.IServer.start')
  - [stop()](#M-Casasoft-BBS-Interfaces-IServer-stop 'Casasoft.BBS.Interfaces.IServer.stop')
- [ScreenFactory](#T-Casasoft-BBS-Interfaces-ScreenFactory 'Casasoft.BBS.Interfaces.ScreenFactory')
  - [Create(c,s,module,param,prev)](#M-Casasoft-BBS-Interfaces-ScreenFactory-Create-Casasoft-BBS-Interfaces-IClient,Casasoft-BBS-Interfaces-IServer,System-String,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.Interfaces.ScreenFactory.Create(Casasoft.BBS.Interfaces.IClient,Casasoft.BBS.Interfaces.IServer,System.String,System.String,Casasoft.BBS.Interfaces.IScreen)')
  - [Create(c,s,module)](#M-Casasoft-BBS-Interfaces-ScreenFactory-Create-Casasoft-BBS-Interfaces-IClient,Casasoft-BBS-Interfaces-IServer,System-String- 'Casasoft.BBS.Interfaces.ScreenFactory.Create(Casasoft.BBS.Interfaces.IClient,Casasoft.BBS.Interfaces.IServer,System.String)')
  - [Create(c,s,module,param)](#M-Casasoft-BBS-Interfaces-ScreenFactory-Create-Casasoft-BBS-Interfaces-IClient,Casasoft-BBS-Interfaces-IServer,System-String,System-String- 'Casasoft.BBS.Interfaces.ScreenFactory.Create(Casasoft.BBS.Interfaces.IClient,Casasoft.BBS.Interfaces.IServer,System.String,System.String)')
  - [Create(c,s,module,prev)](#M-Casasoft-BBS-Interfaces-ScreenFactory-Create-Casasoft-BBS-Interfaces-IClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen- 'Casasoft.BBS.Interfaces.ScreenFactory.Create(Casasoft.BBS.Interfaces.IClient,Casasoft.BBS.Interfaces.IServer,System.String,Casasoft.BBS.Interfaces.IScreen)')

<a name='T-Casasoft-BBS-Interfaces-EClientStatus'></a>
## EClientStatus `type`

##### Namespace

Casasoft.BBS.Interfaces

<a name='F-Casasoft-BBS-Interfaces-EClientStatus-Authenticating'></a>
### Authenticating `constants`

##### Summary

The client is authenticating.

<a name='F-Casasoft-BBS-Interfaces-EClientStatus-Guest'></a>
### Guest `constants`

##### Summary

The client has not been
authenticated yet.

<a name='F-Casasoft-BBS-Interfaces-EClientStatus-LoggedIn'></a>
### LoggedIn `constants`

##### Summary

The client is logged in.

<a name='T-Casasoft-BBS-Interfaces-IBBSClient'></a>
## IBBSClient `type`

##### Namespace

Casasoft.BBS.Interfaces

<a name='P-Casasoft-BBS-Interfaces-IBBSClient-screen'></a>
### screen `property`

##### Summary

Active form

<a name='P-Casasoft-BBS-Interfaces-IBBSClient-screenHeight'></a>
### screenHeight `property`

##### Summary

Current screen rows

<a name='P-Casasoft-BBS-Interfaces-IBBSClient-screenWidth'></a>
### screenWidth `property`

##### Summary

Current screen columns

<a name='P-Casasoft-BBS-Interfaces-IBBSClient-terminalType'></a>
### terminalType `property`

##### Summary

Current terminal type

<a name='P-Casasoft-BBS-Interfaces-IBBSClient-terminalTypeCapable'></a>
### terminalTypeCapable `property`

##### Summary

List of terminal types avaliable on client

<a name='M-Casasoft-BBS-Interfaces-IBBSClient-TryAddTerminalType-System-String-'></a>
### TryAddTerminalType(tt) `method`

##### Summary

Tries to add unique values to the list

##### Returns

true if insert is successful

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | string to insert |

<a name='T-Casasoft-BBS-Interfaces-IClient'></a>
## IClient `type`

##### Namespace

Casasoft.BBS.Interfaces

<a name='P-Casasoft-BBS-Interfaces-IClient-Remote'></a>
### Remote `property`

##### Summary

Formatted remote ip and port

<a name='P-Casasoft-BBS-Interfaces-IClient-connectedAt'></a>
### connectedAt `property`

##### Summary

Connection timestamp

<a name='P-Casasoft-BBS-Interfaces-IClient-id'></a>
### id `property`

##### Summary

The client's identifier.

<a name='P-Casasoft-BBS-Interfaces-IClient-lastActivity'></a>
### lastActivity `property`

##### Summary

last user activity timestamp

<a name='P-Casasoft-BBS-Interfaces-IClient-receivedData'></a>
### receivedData `property`

##### Summary

The last received data from the client.

<a name='P-Casasoft-BBS-Interfaces-IClient-remoteAddr'></a>
### remoteAddr `property`

##### Summary

The client's remote address.

<a name='P-Casasoft-BBS-Interfaces-IClient-status'></a>
### status `property`

##### Summary

The client's current status.

<a name='P-Casasoft-BBS-Interfaces-IClient-username'></a>
### username `property`

##### Summary

User logged in

<a name='M-Casasoft-BBS-Interfaces-IClient-appendReceivedData-System-String-'></a>
### appendReceivedData(dataToAppend) `method`

##### Summary

Appends a string to the client's last
received data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataToAppend | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The data to append. |

<a name='M-Casasoft-BBS-Interfaces-IClient-removeLastCharacterReceived'></a>
### removeLastCharacterReceived() `method`

##### Summary

Removes the last character from the
client's last received data.

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Interfaces-IClient-resetReceivedData'></a>
### resetReceivedData() `method`

##### Summary

Resets the last received data.

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-Interfaces-IScreen'></a>
## IScreen `type`

##### Namespace

Casasoft.BBS.Interfaces

<a name='P-Casasoft-BBS-Interfaces-IScreen-Previous'></a>
### Previous `property`

##### Summary

Pointer to the caller screen for backtracing

<a name='M-Casasoft-BBS-Interfaces-IScreen-HandleChar-System-Byte[],System-Int32-'></a>
### HandleChar(data,bytesReceived) `method`

##### Summary

Handles special chars sequences received from the client

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') |  |
| bytesReceived | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Casasoft-BBS-Interfaces-IScreen-HandleMessage-System-String-'></a>
### HandleMessage(msg) `method`

##### Summary

Handles the messages received from the client

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| msg | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Casasoft-BBS-Interfaces-IScreen-Show'></a>
### Show() `method`

##### Summary

Show screen content

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Interfaces-IScreen-ShowNext'></a>
### ShowNext() `method`

##### Summary

Pass the control to another screen

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-Interfaces-IServer'></a>
## IServer `type`

##### Namespace

Casasoft.BBS.Interfaces

<a name='P-Casasoft-BBS-Interfaces-IServer-clients'></a>
### clients `property`

##### Summary

Contains all connected clients indexed
by their socket.

<a name='M-Casasoft-BBS-Interfaces-IServer-ClearLastInput-Casasoft-BBS-Interfaces-IClient-'></a>
### ClearLastInput(c) `method`

##### Summary

Clears the last input on terminal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient') |  |

<a name='M-Casasoft-BBS-Interfaces-IServer-allowIncomingConnections'></a>
### allowIncomingConnections() `method`

##### Summary

Allows the incoming connections.

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Interfaces-IServer-clearClientScreen-Casasoft-BBS-Interfaces-IClient-'></a>
### clearClientScreen(c) `method`

##### Summary

Clears the screen for the specified
client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient') | The client on which
to clear the screen. |

<a name='M-Casasoft-BBS-Interfaces-IServer-denyIncomingConnections'></a>
### denyIncomingConnections() `method`

##### Summary

Denies the incoming connections.

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Interfaces-IServer-incomingConnectionsAllowed'></a>
### incomingConnectionsAllowed() `method`

##### Summary

Returns whether incoming connections
are allowed.

##### Returns

True is connections are allowed;
false otherwise.

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Interfaces-IServer-kickClient-Casasoft-BBS-Interfaces-IClient-'></a>
### kickClient(client) `method`

##### Summary

Kicks the specified client from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [Casasoft.BBS.Interfaces.IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient') | The client. |

<a name='M-Casasoft-BBS-Interfaces-IServer-sendMessageToAll-System-String-'></a>
### sendMessageToAll(message) `method`

##### Summary

Sends a message to all connected clients.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message. |

<a name='M-Casasoft-BBS-Interfaces-IServer-sendMessageToClient-Casasoft-BBS-Interfaces-IClient,System-String-'></a>
### sendMessageToClient(c,message) `method`

##### Summary

Sends a text message to the specified
client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient') | The client. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message. |

<a name='M-Casasoft-BBS-Interfaces-IServer-start'></a>
### start() `method`

##### Summary

Starts the server.

##### Parameters

This method has no parameters.

<a name='M-Casasoft-BBS-Interfaces-IServer-stop'></a>
### stop() `method`

##### Summary

Stops the server.

##### Parameters

This method has no parameters.

<a name='T-Casasoft-BBS-Interfaces-ScreenFactory'></a>
## ScreenFactory `type`

##### Namespace

Casasoft.BBS.Interfaces

##### Summary

Screens factory

<a name='M-Casasoft-BBS-Interfaces-ScreenFactory-Create-Casasoft-BBS-Interfaces-IClient,Casasoft-BBS-Interfaces-IServer,System-String,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### Create(c,s,module,param,prev) `method`

##### Summary

Screen factory

##### Returns

Istance of the module

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient') | Client object pointer |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server object pointer |
| module | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Module to create |
| param | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | parameters for the module |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Pointer to caller screen |

<a name='M-Casasoft-BBS-Interfaces-ScreenFactory-Create-Casasoft-BBS-Interfaces-IClient,Casasoft-BBS-Interfaces-IServer,System-String-'></a>
### Create(c,s,module) `method`

##### Summary

Screen factory

##### Returns

Istance of the module

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient') | Client object pointer |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server object pointer |
| module | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Module to create |

<a name='M-Casasoft-BBS-Interfaces-ScreenFactory-Create-Casasoft-BBS-Interfaces-IClient,Casasoft-BBS-Interfaces-IServer,System-String,System-String-'></a>
### Create(c,s,module,param) `method`

##### Summary

Screen factory

##### Returns

Istance of the module

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient') | Client object pointer |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server object pointer |
| module | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Module to create |
| param | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | parameters for the module |

<a name='M-Casasoft-BBS-Interfaces-ScreenFactory-Create-Casasoft-BBS-Interfaces-IClient,Casasoft-BBS-Interfaces-IServer,System-String,Casasoft-BBS-Interfaces-IScreen-'></a>
### Create(c,s,module,prev) `method`

##### Summary

Screen factory

##### Returns

Istance of the module

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient') | Client object pointer |
| s | [Casasoft.BBS.Interfaces.IServer](#T-Casasoft-BBS-Interfaces-IServer 'Casasoft.BBS.Interfaces.IServer') | Server object pointer |
| module | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Module to create |
| prev | [Casasoft.BBS.Interfaces.IScreen](#T-Casasoft-BBS-Interfaces-IScreen 'Casasoft.BBS.Interfaces.IScreen') | Pointer to caller screen |
