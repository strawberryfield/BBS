<a name='assembly'></a>
# BBS.Logger

## Contents

- [EventLogger](#T-Casasoft-BBS-Logger-EventLogger 'Casasoft.BBS.Logger.EventLogger')
  - [Write(message,level,remote)](#M-Casasoft-BBS-Logger-EventLogger-Write-System-String,System-SByte,System-String- 'Casasoft.BBS.Logger.EventLogger.Write(System.String,System.SByte,System.String)')
  - [Write(message,level)](#M-Casasoft-BBS-Logger-EventLogger-Write-System-String,System-SByte- 'Casasoft.BBS.Logger.EventLogger.Write(System.String,System.SByte)')
  - [Write(message,remote)](#M-Casasoft-BBS-Logger-EventLogger-Write-System-String,System-String- 'Casasoft.BBS.Logger.EventLogger.Write(System.String,System.String)')
  - [Write(message)](#M-Casasoft-BBS-Logger-EventLogger-Write-System-String- 'Casasoft.BBS.Logger.EventLogger.Write(System.String)')

<a name='T-Casasoft-BBS-Logger-EventLogger'></a>
## EventLogger `type`

##### Namespace

Casasoft.BBS.Logger

##### Summary

Methods to write messages to error output and log table in database

<a name='M-Casasoft-BBS-Logger-EventLogger-Write-System-String,System-SByte,System-String-'></a>
### Write(message,level,remote) `method`

##### Summary

Writes message to error output and log table in database

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| level | [System.SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte') | severity level |
| remote | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | client remote address |

<a name='M-Casasoft-BBS-Logger-EventLogger-Write-System-String,System-SByte-'></a>
### Write(message,level) `method`

##### Summary

Writes message to error output and log table in database

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| level | [System.SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte') | severity level |

<a name='M-Casasoft-BBS-Logger-EventLogger-Write-System-String,System-String-'></a>
### Write(message,remote) `method`

##### Summary

Writes message to error output and log table in database
severity =1

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| remote | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | client remote address |

<a name='M-Casasoft-BBS-Logger-EventLogger-Write-System-String-'></a>
### Write(message) `method`

##### Summary

Writes message to error output and log table in database
severity =1

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
