# Il linguaggio di markup 

All'interno dei testi può essere utilizzato un linguaggio di markup, simile all'HTML,
che permette di arricchire la grafica della pagina e definire azioni realizzando menu di navigazione.

I tag sono racchiusi da parentesi graffe come **{**nometag**}**,
sono case insensitive (cioè **{**nometag**}** è equivalente a **{**NomeTag**}** )
e devono sempre essere terminati da **{**/nometag**}**  
Si può usare anche la forma contratta **{**nometag/**}** nel caso non serva indicare del testo
tra inizio e fine del tag (ad esempio per **{**cls**}** che cancella lo schermo)

I tag possono avere anche degli attributi da indicare come **{**nometag attributename="attibutevalue"**}**,
anche i nomi degli attributi sono case insensitive.

## Tags

Di seguito l'elenco dai tag utilizzabili

### CLS
  
### BLINK
  
### REVERSE
   
### BOLD
  
### UNDERLINE
 
### COLOR
  
### BACKCOLOR
  
### FIGGLE
  
### BEEP
  
### HR
  
### CONNECTED
 
### JOINED
  
### USER
  
### ACTION

## Entities

All'interno dei testi possono essere utilizzate abbreviazioni nella forma **&**entityname**;** per
inserire testi prestabiliti o caratteri speciali.

Quelle qui elencate sono codificate all'interno del programma, nel file di configurazione possono
essere definite altre abbreviazioni personalizzate
(vedi il [capitolo sulla configurazione](config.md) per maggiori dettagli)

- **AMP:** il carattere "e commerciale" '&'

- **LEFTCURLY:** la parentesi graffa aperta '{'

- **RIGHTCURLY:** la parentesi graffa chiusa '}'

- **USERNAME:** il nome dell'utente collegato, 'GUEST' se non è stato fatto il login

- **REMOTE:** indirizzo ip dal quale il client è collegato

- **CONNECTIONTIME:** timestamp dell'inizio del collegamento

---

|[Indietro](config.md)|[Indice](index.md)|
|---|---|
