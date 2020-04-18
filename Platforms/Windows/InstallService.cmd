rem Casasoft BBS Windows service installer
set ServiceName=CasasoftBBS
sc create %ServiceName% BinPath= %~dp0\BBSd.exe
sc description %ServiceName% "Casasoft BBS server"