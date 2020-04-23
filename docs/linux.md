# Configurare il servizio Linux

Queste note si riferiscono all'installazione in ambiente Linux,
se volete installare in ambiente Windows fate riferimento al [documento precedente](windows.md)
e ignorate questo.

## Runtime .net core

Premetto che non ho mai compilato direttamente su una macchina Linux, le istruzioni che seguono si riferiscono
ad una cross-compilazione effettuata su macchina Windows con target diverso e ambiente .net core integrato
negli esguibili, che pertanto funzionano senza necessità di installare il runtime sulla macchina target.

Qualora voleste tentare l'operazione su una macchina diversa occorre
prelevare ed installare l'ultima versione di [.net core 3.1 sdk dal sito di Microsoft](https://dotnet.microsoft.com/download/dotnet-core/3.1)
e modificare gli script di compilazione.

## Compilare il programma

Dalla directory principale del repository eseguire il comando:

```
build-linux-arm
```

Qualora voleste compilare per una architettura diversa da quella arm (RaspberryPI) dovete cambiare il target
sostituendolo con uno di quelli [elencati qui](https://docs.microsoft.com/it-it/dotnet/core/rid-catalog)

Gli eseguibili verranno creati nella cartella bin\Linux-Arm e possono essere eseguiti su qualsiasi macchina
linux-arm anche senza il runtime .net core 3.1 installato.

## Installare il servizio

Copiamo la directory con gli eseguibili sulla macchina di destinazione e assegnamo i permessi di esecuzione
a BBSd

```
sudo chmod +x BBSd
```

quindi creiamo un link nella cartella /usr/sbin

```
sudo ln -s BBSd /usr/sbin/BBSd
```

infine copiamo il file BBSd che troviamo nella cartella /platforms/linux del repository
nella cartella /etc/init.d e diamogli permessi di esecuzione con il consueto

```
sudo chmod +x BBSd
```

avremo il nuovo servizio 'BBSd' che potremo gestire con le consuete modalità.

Prima di avviarlo dovremo procedere alla sua configurazione come descritto [qui](config.md)

---

|[Indietro](windows.md)|[Indice](index.md)|[Avanti](config.md)|  
|---|---|---|
