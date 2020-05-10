<a name='assembly'></a>
# Casasoft.TCPServer

## Contents

- [Client](#T-Casasoft-TCPServer-Client 'Casasoft.TCPServer.Client')
  - [#ctor(clientId,remoteAddress)](#M-Casasoft-TCPServer-Client-#ctor-System-UInt32,System-Net-IPEndPoint- 'Casasoft.TCPServer.Client.#ctor(System.UInt32,System.Net.IPEndPoint)')
  - [Remote](#P-Casasoft-TCPServer-Client-Remote 'Casasoft.TCPServer.Client.Remote')
  - [connectedAt](#P-Casasoft-TCPServer-Client-connectedAt 'Casasoft.TCPServer.Client.connectedAt')
  - [id](#P-Casasoft-TCPServer-Client-id 'Casasoft.TCPServer.Client.id')
  - [lastActivity](#P-Casasoft-TCPServer-Client-lastActivity 'Casasoft.TCPServer.Client.lastActivity')
  - [receivedData](#P-Casasoft-TCPServer-Client-receivedData 'Casasoft.TCPServer.Client.receivedData')
  - [remoteAddr](#P-Casasoft-TCPServer-Client-remoteAddr 'Casasoft.TCPServer.Client.remoteAddr')
  - [screen](#P-Casasoft-TCPServer-Client-screen 'Casasoft.TCPServer.Client.screen')
  - [screenHeight](#P-Casasoft-TCPServer-Client-screenHeight 'Casasoft.TCPServer.Client.screenHeight')
  - [screenWidth](#P-Casasoft-TCPServer-Client-screenWidth 'Casasoft.TCPServer.Client.screenWidth')
  - [status](#P-Casasoft-TCPServer-Client-status 'Casasoft.TCPServer.Client.status')
  - [terminalType](#P-Casasoft-TCPServer-Client-terminalType 'Casasoft.TCPServer.Client.terminalType')
  - [terminalTypeCapable](#P-Casasoft-TCPServer-Client-terminalTypeCapable 'Casasoft.TCPServer.Client.terminalTypeCapable')
  - [username](#P-Casasoft-TCPServer-Client-username 'Casasoft.TCPServer.Client.username')
  - [TryAddTerminalType(tt)](#M-Casasoft-TCPServer-Client-TryAddTerminalType-System-String- 'Casasoft.TCPServer.Client.TryAddTerminalType(System.String)')
  - [appendReceivedData(dataToAppend)](#M-Casasoft-TCPServer-Client-appendReceivedData-System-String- 'Casasoft.TCPServer.Client.appendReceivedData(System.String)')
  - [removeLastCharacterReceived()](#M-Casasoft-TCPServer-Client-removeLastCharacterReceived 'Casasoft.TCPServer.Client.removeLastCharacterReceived')
  - [resetReceivedData()](#M-Casasoft-TCPServer-Client-resetReceivedData 'Casasoft.TCPServer.Client.resetReceivedData')
- [Negotiation](#T-Casasoft-TCPServer-Negotiation 'Casasoft.TCPServer.Negotiation')
  - [AskForTerminalType()](#M-Casasoft-TCPServer-Negotiation-AskForTerminalType 'Casasoft.TCPServer.Negotiation.AskForTerminalType')
  - [ClientWillTerminalType(data)](#M-Casasoft-TCPServer-Negotiation-ClientWillTerminalType-System-Byte[],System-Int32- 'Casasoft.TCPServer.Negotiation.ClientWillTerminalType(System.Byte[],System.Int32)')
  - [Do(op)](#M-Casasoft-TCPServer-Negotiation-Do-Casasoft-TCPServer-Negotiation-Operations- 'Casasoft.TCPServer.Negotiation.Do(Casasoft.TCPServer.Negotiation.Operations)')
  - [Dont(op)](#M-Casasoft-TCPServer-Negotiation-Dont-Casasoft-TCPServer-Negotiation-Operations- 'Casasoft.TCPServer.Negotiation.Dont(Casasoft.TCPServer.Negotiation.Operations)')
  - [HandleTerminalType(data,c)](#M-Casasoft-TCPServer-Negotiation-HandleTerminalType-System-Byte[],System-Int32,Casasoft-BBS-Interfaces-IBBSClient- 'Casasoft.TCPServer.Negotiation.HandleTerminalType(System.Byte[],System.Int32,Casasoft.BBS.Interfaces.IBBSClient)')
  - [Will(op)](#M-Casasoft-TCPServer-Negotiation-Will-Casasoft-TCPServer-Negotiation-Operations- 'Casasoft.TCPServer.Negotiation.Will(Casasoft.TCPServer.Negotiation.Operations)')
  - [Wont(op)](#M-Casasoft-TCPServer-Negotiation-Wont-Casasoft-TCPServer-Negotiation-Operations- 'Casasoft.TCPServer.Negotiation.Wont(Casasoft.TCPServer.Negotiation.Operations)')
- [Operations](#T-Casasoft-TCPServer-Negotiation-Operations 'Casasoft.TCPServer.Negotiation.Operations')
- [Server](#T-Casasoft-TCPServer-Server 'Casasoft.TCPServer.Server')
  - [#ctor(ip,dataSize)](#M-Casasoft-TCPServer-Server-#ctor-System-Net-IPAddress,System-Int32- 'Casasoft.TCPServer.Server.#ctor(System.Net.IPAddress,System.Int32)')
  - [END_LINE](#F-Casasoft-TCPServer-Server-END_LINE 'Casasoft.TCPServer.Server.END_LINE')
  - [acceptIncomingConnections](#F-Casasoft-TCPServer-Server-acceptIncomingConnections 'Casasoft.TCPServer.Server.acceptIncomingConnections')
  - [data](#F-Casasoft-TCPServer-Server-data 'Casasoft.TCPServer.Server.data')
  - [dataSize](#F-Casasoft-TCPServer-Server-dataSize 'Casasoft.TCPServer.Server.dataSize')
  - [ip](#F-Casasoft-TCPServer-Server-ip 'Casasoft.TCPServer.Server.ip')
  - [port](#F-Casasoft-TCPServer-Server-port 'Casasoft.TCPServer.Server.port')
  - [serverSocket](#F-Casasoft-TCPServer-Server-serverSocket 'Casasoft.TCPServer.Server.serverSocket')
  - [clients](#P-Casasoft-TCPServer-Server-clients 'Casasoft.TCPServer.Server.clients')
  - [ClearLastInput(c)](#M-Casasoft-TCPServer-Server-ClearLastInput-Casasoft-BBS-Interfaces-IClient- 'Casasoft.TCPServer.Server.ClearLastInput(Casasoft.BBS.Interfaces.IClient)')
  - [allowIncomingConnections()](#M-Casasoft-TCPServer-Server-allowIncomingConnections 'Casasoft.TCPServer.Server.allowIncomingConnections')
  - [clearClientScreen(c)](#M-Casasoft-TCPServer-Server-clearClientScreen-Casasoft-BBS-Interfaces-IClient- 'Casasoft.TCPServer.Server.clearClientScreen(Casasoft.BBS.Interfaces.IClient)')
  - [clearInactiveSockets()](#M-Casasoft-TCPServer-Server-clearInactiveSockets 'Casasoft.TCPServer.Server.clearInactiveSockets')
  - [closeSocket(clientSocket)](#M-Casasoft-TCPServer-Server-closeSocket-System-Net-Sockets-Socket- 'Casasoft.TCPServer.Server.closeSocket(System.Net.Sockets.Socket)')
  - [denyIncomingConnections()](#M-Casasoft-TCPServer-Server-denyIncomingConnections 'Casasoft.TCPServer.Server.denyIncomingConnections')
  - [getClientBySocket(clientSocket)](#M-Casasoft-TCPServer-Server-getClientBySocket-System-Net-Sockets-Socket- 'Casasoft.TCPServer.Server.getClientBySocket(System.Net.Sockets.Socket)')
  - [getSocketByClient(client)](#M-Casasoft-TCPServer-Server-getSocketByClient-Casasoft-BBS-Interfaces-IClient- 'Casasoft.TCPServer.Server.getSocketByClient(Casasoft.BBS.Interfaces.IClient)')
  - [handleIncomingConnection()](#M-Casasoft-TCPServer-Server-handleIncomingConnection-System-IAsyncResult- 'Casasoft.TCPServer.Server.handleIncomingConnection(System.IAsyncResult)')
  - [incomingConnectionsAllowed()](#M-Casasoft-TCPServer-Server-incomingConnectionsAllowed 'Casasoft.TCPServer.Server.incomingConnectionsAllowed')
  - [kickClient(client)](#M-Casasoft-TCPServer-Server-kickClient-Casasoft-BBS-Interfaces-IClient- 'Casasoft.TCPServer.Server.kickClient(Casasoft.BBS.Interfaces.IClient)')
  - [receiveData()](#M-Casasoft-TCPServer-Server-receiveData-System-IAsyncResult- 'Casasoft.TCPServer.Server.receiveData(System.IAsyncResult)')
  - [sendBytesToSocket(s,data)](#M-Casasoft-TCPServer-Server-sendBytesToSocket-System-Net-Sockets-Socket,System-Byte[]- 'Casasoft.TCPServer.Server.sendBytesToSocket(System.Net.Sockets.Socket,System.Byte[])')
  - [sendData()](#M-Casasoft-TCPServer-Server-sendData-System-IAsyncResult- 'Casasoft.TCPServer.Server.sendData(System.IAsyncResult)')
  - [sendMessageToAll(message)](#M-Casasoft-TCPServer-Server-sendMessageToAll-System-String- 'Casasoft.TCPServer.Server.sendMessageToAll(System.String)')
  - [sendMessageToClient(c,message)](#M-Casasoft-TCPServer-Server-sendMessageToClient-Casasoft-BBS-Interfaces-IClient,System-String- 'Casasoft.TCPServer.Server.sendMessageToClient(Casasoft.BBS.Interfaces.IClient,System.String)')
  - [sendMessageToSocket(s,message)](#M-Casasoft-TCPServer-Server-sendMessageToSocket-System-Net-Sockets-Socket,System-String- 'Casasoft.TCPServer.Server.sendMessageToSocket(System.Net.Sockets.Socket,System.String)')
  - [start()](#M-Casasoft-TCPServer-Server-start 'Casasoft.TCPServer.Server.start')
  - [stop()](#M-Casasoft-TCPServer-Server-stop 'Casasoft.TCPServer.Server.stop')
  - [testClientTimeout(c)](#M-Casasoft-TCPServer-Server-testClientTimeout-Casasoft-BBS-Interfaces-IClient- 'Casasoft.TCPServer.Server.testClientTimeout(Casasoft.BBS.Interfaces.IClient)')
- [Tokens](#T-Casasoft-TCPServer-Negotiation-Tokens 'Casasoft.TCPServer.Negotiation.Tokens')

<a name='T-Casasoft-TCPServer-Client'></a>
## Client `type`

##### Namespace

Casasoft.TCPServer

##### Summary

Client parameters storage

<a name='M-Casasoft-TCPServer-Client-#ctor-System-UInt32,System-Net-IPEndPoint-'></a>
### #ctor(clientId,remoteAddress) `constructor`

##### Summary

Initializes a new instance of the [Client](#T-Casasoft-TCPServer-Client 'Casasoft.TCPServer.Client') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientId | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The client's identifier. |
| remoteAddress | [System.Net.IPEndPoint](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.IPEndPoint 'System.Net.IPEndPoint') | The remote address. |

<a name='P-Casasoft-TCPServer-Client-Remote'></a>
### Remote `property`

##### Summary

Formatted remote ip and port

<a name='P-Casasoft-TCPServer-Client-connectedAt'></a>
### connectedAt `property`

##### Summary

The connection datetime.

<a name='P-Casasoft-TCPServer-Client-id'></a>
### id `property`

##### Summary

The client's identifier.

<a name='P-Casasoft-TCPServer-Client-lastActivity'></a>
### lastActivity `property`

##### Summary

last user activity timestamp

<a name='P-Casasoft-TCPServer-Client-receivedData'></a>
### receivedData `property`

##### Summary

The last received data from the client.

<a name='P-Casasoft-TCPServer-Client-remoteAddr'></a>
### remoteAddr `property`

##### Summary

The client's remote address.

<a name='P-Casasoft-TCPServer-Client-screen'></a>
### screen `property`

##### Summary

Active form

<a name='P-Casasoft-TCPServer-Client-screenHeight'></a>
### screenHeight `property`

##### Summary

Current screen rows

<a name='P-Casasoft-TCPServer-Client-screenWidth'></a>
### screenWidth `property`

##### Summary

Current screen columns

<a name='P-Casasoft-TCPServer-Client-status'></a>
### status `property`

##### Summary

The client's current status.

<a name='P-Casasoft-TCPServer-Client-terminalType'></a>
### terminalType `property`

##### Summary

Current terminal type

<a name='P-Casasoft-TCPServer-Client-terminalTypeCapable'></a>
### terminalTypeCapable `property`

##### Summary

List of terminal types avaliable on client

<a name='P-Casasoft-TCPServer-Client-username'></a>
### username `property`

##### Summary

User logged in

<a name='M-Casasoft-TCPServer-Client-TryAddTerminalType-System-String-'></a>
### TryAddTerminalType(tt) `method`

##### Summary

Tries to add unique values to the list

##### Returns

true if insert is successful

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | string to insert |

<a name='M-Casasoft-TCPServer-Client-appendReceivedData-System-String-'></a>
### appendReceivedData(dataToAppend) `method`

##### Summary

Appends a string to the client's last
received data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataToAppend | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The data to append. |

<a name='M-Casasoft-TCPServer-Client-removeLastCharacterReceived'></a>
### removeLastCharacterReceived() `method`

##### Summary

Removes the last character from the
client's last received data.

##### Parameters

This method has no parameters.

<a name='M-Casasoft-TCPServer-Client-resetReceivedData'></a>
### resetReceivedData() `method`

##### Summary

Resets the last received data.

##### Parameters

This method has no parameters.

<a name='T-Casasoft-TCPServer-Negotiation'></a>
## Negotiation `type`

##### Namespace

Casasoft.TCPServer

##### Summary

Handles Telnet negotiation

<a name='M-Casasoft-TCPServer-Negotiation-AskForTerminalType'></a>
### AskForTerminalType() `method`

##### Summary

Sequence to request terminal type to the client RFC884 - RFC1091
[](#!-https-//tools-ietf-org/html/rfc884 'https://tools.ietf.org/html/rfc884')[](#!-https-//tools-ietf-org/html/rfc1091 'https://tools.ietf.org/html/rfc1091')

##### Returns

IAC SB TERMINAL-TYPE SEND IAC SE

##### Parameters

This method has no parameters.

<a name='M-Casasoft-TCPServer-Negotiation-ClientWillTerminalType-System-Byte[],System-Int32-'></a>
### ClientWillTerminalType(data) `method`

##### Summary

Tests if client support Terminal Type Negotiation RFC884 - RFC1091
[](#!-https-//tools-ietf-org/html/rfc884 'https://tools.ietf.org/html/rfc884')[](#!-https-//tools-ietf-org/html/rfc1091 'https://tools.ietf.org/html/rfc1091')

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | received bytes |

<a name='M-Casasoft-TCPServer-Negotiation-Do-Casasoft-TCPServer-Negotiation-Operations-'></a>
### Do(op) `method`

##### Summary

Sends Do command

##### Returns

Negotiation sequence

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| op | [Casasoft.TCPServer.Negotiation.Operations](#T-Casasoft-TCPServer-Negotiation-Operations 'Casasoft.TCPServer.Negotiation.Operations') | Operation code |

<a name='M-Casasoft-TCPServer-Negotiation-Dont-Casasoft-TCPServer-Negotiation-Operations-'></a>
### Dont(op) `method`

##### Summary

Sends Don't command

##### Returns

Negotiation sequence

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| op | [Casasoft.TCPServer.Negotiation.Operations](#T-Casasoft-TCPServer-Negotiation-Operations 'Casasoft.TCPServer.Negotiation.Operations') | Operation code |

<a name='M-Casasoft-TCPServer-Negotiation-HandleTerminalType-System-Byte[],System-Int32,Casasoft-BBS-Interfaces-IBBSClient-'></a>
### HandleTerminalType(data,c) `method`

##### Summary

Receive terminal type from cliente RFC884 - RFC1091
[](#!-https-//tools-ietf-org/html/rfc884 'https://tools.ietf.org/html/rfc884')[](#!-https-//tools-ietf-org/html/rfc1091 'https://tools.ietf.org/html/rfc1091')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | received data |
| c | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | client to update |

##### Remarks

Client sends data in the form

```
IAC SB TERMINAL-TYPE IS ... IAC SE
```

The code for IS is 0.

<a name='M-Casasoft-TCPServer-Negotiation-Will-Casasoft-TCPServer-Negotiation-Operations-'></a>
### Will(op) `method`

##### Summary

Sends Will command

##### Returns

Negotiation sequence

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| op | [Casasoft.TCPServer.Negotiation.Operations](#T-Casasoft-TCPServer-Negotiation-Operations 'Casasoft.TCPServer.Negotiation.Operations') | Operation code |

<a name='M-Casasoft-TCPServer-Negotiation-Wont-Casasoft-TCPServer-Negotiation-Operations-'></a>
### Wont(op) `method`

##### Summary

Sends Won't command

##### Returns

Negotiation sequence

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| op | [Casasoft.TCPServer.Negotiation.Operations](#T-Casasoft-TCPServer-Negotiation-Operations 'Casasoft.TCPServer.Negotiation.Operations') | Operation code |

<a name='T-Casasoft-TCPServer-Negotiation-Operations'></a>
## Operations `type`

##### Namespace

Casasoft.TCPServer.Negotiation

##### Summary

Negotiable options from IANA

<a name='T-Casasoft-TCPServer-Server'></a>
## Server `type`

##### Namespace

Casasoft.TCPServer

<a name='M-Casasoft-TCPServer-Server-#ctor-System-Net-IPAddress,System-Int32-'></a>
### #ctor(ip,dataSize) `constructor`

##### Summary

Initializes a new instance of the [Server](#T-Casasoft-TCPServer-Server 'Casasoft.TCPServer.Server') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ip | [System.Net.IPAddress](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.IPAddress 'System.Net.IPAddress') | The IP on which to listen to. |
| dataSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Data size for received data. |

<a name='F-Casasoft-TCPServer-Server-END_LINE'></a>
### END_LINE `constants`

##### Summary

End of line constant.

<a name='F-Casasoft-TCPServer-Server-acceptIncomingConnections'></a>
### acceptIncomingConnections `constants`

##### Summary

True for allowing incoming connections;
false otherwise.

<a name='F-Casasoft-TCPServer-Server-data'></a>
### data `constants`

##### Summary

Contains the received data.

<a name='F-Casasoft-TCPServer-Server-dataSize'></a>
### dataSize `constants`

##### Summary

The default data size for received data.

<a name='F-Casasoft-TCPServer-Server-ip'></a>
### ip `constants`

##### Summary

The IP on which to listen.

<a name='F-Casasoft-TCPServer-Server-port'></a>
### port `constants`

##### Summary

Telnet's default port.

<a name='F-Casasoft-TCPServer-Server-serverSocket'></a>
### serverSocket `constants`

##### Summary

Server's main socket.

<a name='P-Casasoft-TCPServer-Server-clients'></a>
### clients `property`

##### Summary

Contains all connected clients indexed
by their socket.

<a name='M-Casasoft-TCPServer-Server-ClearLastInput-Casasoft-BBS-Interfaces-IClient-'></a>
### ClearLastInput(c) `method`

##### Summary

Clears the last input on terminal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient') |  |

<a name='M-Casasoft-TCPServer-Server-allowIncomingConnections'></a>
### allowIncomingConnections() `method`

##### Summary

Allows the incoming connections.

##### Parameters

This method has no parameters.

<a name='M-Casasoft-TCPServer-Server-clearClientScreen-Casasoft-BBS-Interfaces-IClient-'></a>
### clearClientScreen(c) `method`

##### Summary

Clears the screen for the specified
client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient') | The client on which
to clear the screen. |

<a name='M-Casasoft-TCPServer-Server-clearInactiveSockets'></a>
### clearInactiveSockets() `method`

##### Summary

Scans all clients and kills inactive ones

##### Parameters

This method has no parameters.

<a name='M-Casasoft-TCPServer-Server-closeSocket-System-Net-Sockets-Socket-'></a>
### closeSocket(clientSocket) `method`

##### Summary

Closes the socket and removes the client from
the clients list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientSocket | [System.Net.Sockets.Socket](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Sockets.Socket 'System.Net.Sockets.Socket') | The client socket. |

<a name='M-Casasoft-TCPServer-Server-denyIncomingConnections'></a>
### denyIncomingConnections() `method`

##### Summary

Denies the incoming connections.

##### Parameters

This method has no parameters.

<a name='M-Casasoft-TCPServer-Server-getClientBySocket-System-Net-Sockets-Socket-'></a>
### getClientBySocket(clientSocket) `method`

##### Summary

Gets the client by socket.

##### Returns

If the socket is found, the client instance
is returned; otherwise null is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientSocket | [System.Net.Sockets.Socket](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Sockets.Socket 'System.Net.Sockets.Socket') | The client's socket. |

<a name='M-Casasoft-TCPServer-Server-getSocketByClient-Casasoft-BBS-Interfaces-IClient-'></a>
### getSocketByClient(client) `method`

##### Summary

Gets the socket by client.

##### Returns

If the client is found, the socket is
returned; otherwise null is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [Casasoft.BBS.Interfaces.IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient') | The client instance. |

<a name='M-Casasoft-TCPServer-Server-handleIncomingConnection-System-IAsyncResult-'></a>
### handleIncomingConnection() `method`

##### Summary

Handles an incoming connection.
If incoming connections are allowed,
the client is added to the clients list
and triggers the client connected event.
Else, the connection blocked event is
triggered.

##### Parameters

This method has no parameters.

<a name='M-Casasoft-TCPServer-Server-incomingConnectionsAllowed'></a>
### incomingConnectionsAllowed() `method`

##### Summary

Returns whether incoming connections
are allowed.

##### Returns

True is connections are allowed;
false otherwise.

##### Parameters

This method has no parameters.

<a name='M-Casasoft-TCPServer-Server-kickClient-Casasoft-BBS-Interfaces-IClient-'></a>
### kickClient(client) `method`

##### Summary

Kicks the specified client from the server.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [Casasoft.BBS.Interfaces.IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient') | The client. |

<a name='M-Casasoft-TCPServer-Server-receiveData-System-IAsyncResult-'></a>
### receiveData() `method`

##### Summary

Receives and processes data from a socket.
It triggers the message received event in
case the client pressed the return key.

##### Parameters

This method has no parameters.

<a name='M-Casasoft-TCPServer-Server-sendBytesToSocket-System-Net-Sockets-Socket,System-Byte[]-'></a>
### sendBytesToSocket(s,data) `method`

##### Summary

Sends bytes to the specified socket.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.Net.Sockets.Socket](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Sockets.Socket 'System.Net.Sockets.Socket') | The socket. |
| data | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | The bytes. |

<a name='M-Casasoft-TCPServer-Server-sendData-System-IAsyncResult-'></a>
### sendData() `method`

##### Summary

Sends data to a socket.

##### Parameters

This method has no parameters.

<a name='M-Casasoft-TCPServer-Server-sendMessageToAll-System-String-'></a>
### sendMessageToAll(message) `method`

##### Summary

Sends a message to all connected clients.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message. |

<a name='M-Casasoft-TCPServer-Server-sendMessageToClient-Casasoft-BBS-Interfaces-IClient,System-String-'></a>
### sendMessageToClient(c,message) `method`

##### Summary

Sends a text message to the specified
client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient') | The client. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message. |

<a name='M-Casasoft-TCPServer-Server-sendMessageToSocket-System-Net-Sockets-Socket,System-String-'></a>
### sendMessageToSocket(s,message) `method`

##### Summary

Sends a text message to the specified
socket.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.Net.Sockets.Socket](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Sockets.Socket 'System.Net.Sockets.Socket') | The socket. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message. |

<a name='M-Casasoft-TCPServer-Server-start'></a>
### start() `method`

##### Summary

Starts the server.

##### Parameters

This method has no parameters.

<a name='M-Casasoft-TCPServer-Server-stop'></a>
### stop() `method`

##### Summary

Stops the server.

##### Parameters

This method has no parameters.

<a name='M-Casasoft-TCPServer-Server-testClientTimeout-Casasoft-BBS-Interfaces-IClient-'></a>
### testClientTimeout(c) `method`

##### Summary

Checks if is inactive for a time greater then configured

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [Casasoft.BBS.Interfaces.IClient](#T-Casasoft-BBS-Interfaces-IClient 'Casasoft.BBS.Interfaces.IClient') |  |

<a name='T-Casasoft-TCPServer-Negotiation-Tokens'></a>
## Tokens `type`

##### Namespace

Casasoft.TCPServer.Negotiation

##### Summary

Negotiation codes as described in RFC 854
