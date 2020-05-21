# Il linguaggio di markup 

All'interno dei testi può essere utilizzato un linguaggio di markup, simile all'HTML,
che permette di arricchire la grafica della pagina e definire azioni realizzando menu di navigazione.

## Tags

I tag sono racchiusi da parentesi graffe come **{**nometag**}**,
sono case insensitive (cioè **{**nometag**}** è equivalente a **{**NomeTag**}** )
e devono sempre essere terminati da **{**/nometag**}**  
Si può usare anche la forma contratta **{**nometag/**}** nel caso non serva indicare del testo
tra inizio e fine del tag (ad esempio per **{**cls**}** che cancella lo schermo)

I tag possono avere anche degli attributi da indicare come **{**nometag attributename="attibutevalue"**}**,
anche i nomi degli attributi sono case insensitive.

I tags utilizzabili sono descritti in un [capitolo dedicato](tags.md)

## Entities

All'interno dei testi possono essere utilizzate abbreviazioni nella forma **&**entityname**;** per
inserire testi prestabiliti o caratteri speciali.

Alcune sono codificate all'interno del programma, ma nel file di configurazione possono
essere definite altre abbreviazioni personalizzate
(vedi il [capitolo sulla configurazione](config.md) per maggiori dettagli)

Le entities utilizzabili sono descritte in un [capitolo dedicato](entities.md)

---

|[Indietro](config.md)|[Indice](index.md)|[Avanti](tags.md) |
|---|---|---|
