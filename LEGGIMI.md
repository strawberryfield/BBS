# Casasoft BBS
## Telnet BBS - «The Strawberry Field» ritorna dopo 30 anni?

![Project Logo](cover.jpg)

Questo progetto è ancora in versione alpha.

For documentation and informations in english language refer to [README.md](README.md)

## Breve storia di questo progetto

Nel lontano 1989 acquistai un modem da 2400 bps con il quale potevo collegarmi ad alcune BBS della mia città (Rimini).

Curioso come mio solito, mi procurai il software per installarne una e la misi in azione sul mio pc (un modesto 8086) 
per uso esclusivamente personale.
Ma questo mi diede modo di imparare tante cose sull'ambiente. 
Ne approfittai per configurare un point (ovvero avevo la possibilità di scaricare i messaggi nella mia bbs locale e leggerli offline).

Uno dei sysop si era ricreato il software da solo e la cosa mi intrigava molto. Armato del mio fido Turbo Pascal scrissi un packer (ObjectMatrix)
e alcune utility tra cui una backdoor che veniva utilizzata per l'amministrazione remota del sito.

L'"Italian Crackdown" spazzò via gran parte delle BBS italiane, contemporaneamente internet si diffondeva per l'utilizzo pubblico ed i miei interessi
si spostarono altrove.

Nel pieno della pandemia da CoViD19 mi ritrovo a girovagare su internet e scopro che in effetti esistono ancora bbs accessibili via internet
con un semplice client telnet, esistono ancora i protocolli FidoNet aggiornati per funzionare in internet.

Oggi ho conoscenze e mezzi ben superiori a quelli di 30 anni fa, dispongo di un "server" che possa ospitare la BBS (un RaspberryPi 2), 
tempo da impiegare in casa e quindi decido di iniziare questa avventura.

## Gli strumenti

Inizio con l'installare il database MariaDb (ex MySQL) sul RaspberryPI, poi è la volta di Apache HTTPD, PHP e PhpMyAdmin per poterlo gestire.

Sulla macchina Windows 10 servono Visual Studio 2019 e .NET Core 3.1  
Occorrono poi alcune estensioni come l'Entity Framework per l'accesso al database e Antlr 4 per poter gestire dei tag nei files di testo.

Non possono mancare un repository GIT e la sua condivione su GitHub.

Finalmente siamo pronti per partire.

## Ambiente software

Scritto in C# con .net core 3.1, Entity Framework Core 3.1.1, Antlr 4.8  
Database ospitato su MariaDB 10.3.22

Testato sotto Windows 10 1909 e RaspberryPi 2 (Raspbian buster)

## Documentazione

Qui trovate il [Manuale di installazione e configurazione](docs/index.md)
