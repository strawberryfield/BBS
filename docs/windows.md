# Configurare il servizio Windows

Queste note si riferiscono all'installazione in ambiente Windows,
se volete installare in ambiente Linux fate riferimento al [documento successivo](linux.md)
e ignorate questo.

## Runtime .net core

Prelevare ed installare l'ultima versione di [.net core 3.1 sdk dal sito di Microsoft](https://dotnet.microsoft.com/download/dotnet-core/3.1)

## Compilare il programma

Dalla directory principale del repository eseguire il comando:

```
Build
```

Gli eseguibili verranno creati nella cartella bin\Portable e possono essere eseguiti su qualsiasi macchina
(anche non Windows) che abbia il runtime .net core 3.1 installato.

## Installare il servizio

Copiare i files batch presenti nella cartella platforms/windows del repository nella cartella in cui sono stati salvati gli eseguibili della BBS  
E da qui eseguire il comando:

```
InstallService
```

Ora aprendo la gestione dei servizi di Windows con il comando

```
services.msc
```

troveremo il nuovo servizio 'CasasoftBBS' che potremo gestire con le consuete modalità.

Prima di avviarlo dovremo procedere alla sua configurazione come descritto [qui](config.md)

---

|[Indietro](database.md)|[Indice](index.md)|[Avanti](linux.md)|  
|---|---|---|
