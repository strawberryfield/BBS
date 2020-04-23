# Installare il database 

## Installare il motore

Il motore di database può essere installato anche su un server differente da quello su cui installerete la BBS.  
Se già disponete di un server mysql o mariadb installato potete utilizzare quello e saltare alla prossima sezione

### Windows

L'installer per Windows può essere prelevato dal [sito di MariaDb](https://mariadb.com/downloads/#mariadb_platform)

Il wizard di installazione chiederà la password dell'utente "root": scegliete una password robusta e annotatevela.  
Non è consigliabile concedere a root la possibilità di effettuare il login remoto.  
Lasciate le altre opzioni come proposte.

### Linux

I repository delle distribuzioni Linux includono già i pacchetti per il server MariaDb, su quelle Debian-based
come Ubuntu o Raspbian è installabile con il comando:

```
sudo apt install mariadb-server
```

## Creare il database

Utilizzando il file bbs.sql presente nella cartella db del repository possiamo creare la struttura del database con il comando:

```
mysql -u root -p <bbs.sql
```

Vi verrà chiesta la password di "root" specificata durante l'installazione.

Nelle recenti distribuzioni Linux non viene impostata una password esplicita per "root" per cui occorre procedere in questo modo

```
sudo mysql <bbs.sql
```

Potrebbe esservi richiesta la password per eseguire il su

## Impostazioni di sicurezza

Iniziamo con il creare un utente per il nostro database

Accediamo al server con: 

```
mysql -u root -p <bbs.sql
```

oppure su utilizzate Linux:

```
sudo mysql
```

Quindi al prompt di mariadb creiamo l'utente "bbs"

```
 create user 'bbs'@'localhost' identified by 'your_secret_password';
```

Se avete intenzione di installare il server della BBS su una macchina diversa da quella del database occorre
sostituire "localhost" con l'indirizzo della macchina sui cui installerete la BBS.

Attribuiamo al nuovo utente i permessi per gestire il database

```
 GRANT USAGE ON bbs.* TO 'bbs'@'localhost' identified by 'your_secret_password';
 FLUSH PRIVILEGES;
```

Come sopra, se necessario, sostituite "localhost" con l'indirizzo del server della BBS.

---

|[Indietro](intro.md)|[Indice](index.md)|[Avanti](windows.md)|
|---|---|---|
