# Il file di configurazione 

La configurazione del programma avviene per mezzo del file **BBSd.dll.config** che si trova nella
directory principale.

Si tratta del consueto file XML di configurazione delle applicazioni .NET arricchito di sezioni
specializzate per i vari aspetti di questo programma.

Eventuali plugin aggiuntivi potranno aggiungere sezioni dedicate.

## Connection string

In questa sezione vanno specificati i parametri per la connessione al database che contiene
tutte le informazioni relative agli utenti, i messaggi e i log.

La stringa di connessione è composta dalle seguenti parti:

- **server:** qui va indicato l'indirizzo o il nome della macchina che ospita il database, 
se si tratta della stessa macchina che ospita anche il programma si può indicare 'localhost'

- **database:** fisso 'bbs'

- **user:** il nome dell'utente con cui il programma farà accesso al database, è quello che
dovreste aver configurato come descritto nel [capitolo sul Database](database.md)

- **password:** la password per l'utente di accesso descritto sopra

- **providerName:** la versione del database in uso ottenibile con il comando *mysql --version*

## App settings

Contiene una unica chiave **assets** il cui valore rappresenta il percorso base per
i files dei contenuti: tutti i contenuti verranno cercati con un percorso relativo a questa directory.

## Security

Contiene le impostazioni relative ai nomi utente e alle password

- **UnwantedUsers:** i nomi utente che iniziano con le stringhe elencate non vengono accettati

- **PasswordMinLength:** lunghezza minima delle password

- **PasswordWantUpperLower:** nelle password deve essere presente almeno un carattere minuscolo e uno maiuscolo

- **PasswordWantDigit:** nelle password deve essere presente almeno un carattere numerico

- **PasswordWantSpecial:** nelle password deve essere presente almeno un carattere speciale

- **PasswordExpires:** le password scadono dopo i giorni indicati, se 0 le password non hanno scadenza

- **MaxTries:** numero dei tentativi di login ammessi prima della disconnessione forzata

## Texts

Contiene le scorciatoie per i nomi dei files dei testi. Queste sono le scorciatoie inserite nel codice del programma,
ma potete aggiungere tutte quelle che possono servirvi nei vostri testi (vedi il [capitolo sul markup](markup.md)
per maggiori dettagli)

- **Banner:** viene mostrato alla connessione del client

- **Logout:** viene mostrato alla disconnessione del client

- **Login:** viene mostrato prima del prompt di login

- **GuestAccess:** viene mostrato se l'utente viene accettato come ospite

- **NewUser:** viene mostrato prima del form di registrazione dell'utente

- **LoggedIn:** viene mostrato dopo l'avvenuto login

- **Disclaimer:** regolamento e termini d'uso della BBSd

- **ChangePassword:** viene mostrato prima del form di cambio password

- **ChangePasswordSu:** viene mostrato prima del form di cambio password per superuser (cioè senza richiesta della vecchia password)

- **MessageAreaGroups:** viene mostrato prima dell'elenco dei gruppi delle aree messaggi

- **MessageAreas:** viene mostrato prima dell'elenco delle aree messaggi

## Networking

Contiene le impostazioni del server TCP/IP

- **port:** porta sulla quale il server rimane in ascolto

- **InactivityTimeout:** numero di secondi di inattività dopo i quali il client viene disconnesso

## Appearance

Contiene le impostazione di default per i colori che vengono utilzzate alla cancellazione dello schermo
(vedi il [capitolo sul markup](markup.md) per maggiori dettagli)

- **BackColor:** Colore dello sfondo

- **ForeColor:** Colore del testo

## Entities

Contiene abbreviazioni che vengono utilizzate nella forma **&**entityname**;** all'interno dei testi.

Quelle qui inserite sono utilizzate nei testi di esempio, ma possono essere eliminate o sostituite.

---

|[Indietro](linux.md)|[Indice](index.md)|[Avanti](markup.md)|
|---|---|---|