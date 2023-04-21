|<p>![](Aspose.Words.b1568a6b-1f3e-4f3b-a558-30c8db14b97d.001.png)</p><p>**          </p>|*CocHarts*||
| :- | -: | :- |
||*Template project  management*|**V 1.0**|



**COCHARTS**


**R<a name="_ref165943"></a>ESPONSABILITÀ**

|**Funzione**|**Nome**|**Data**|
| :- | :- | :- |
|Redatto da|Legato Lorenzo Antonio|10/04/2023|
|Controllato e Approvato da|Michelis Alessandro|15/04/2023|
|Emesso da|Legato Lorenzo Antonio|19/04/2023|

**STORIA DELLE VARIAZIONI**

|**Versione**|**Data emissione**|**Parte modificata**|**Descrizione della variazione**|
| :- | :- | :- | :- |
|Bozza|10/04/2023|Documento completo|Documento completo|
|Versione finale|19/04/2023|||

**SOMMARIO**

1\.  scopo e campo di applicazione	[3](#__refheading___toc28061790)

1\.1  Scopo	[3](#__refheading___toc28061791)

1\.2  Campo di applicazione	[3](#__refheading___toc280617911)

2\.  riferimenti	[3](#__refheading___toc28061792)

2\.1  Definizioni ed Acronimi	[3](#__refheading___toc28061793)

3\.  Analisi dei requisiti	[4](#__refheading___toc28061794)

4\.  FORNITURA	[5](#__refheading___toc28061795)

5\.  Work Break DOWN Structure	[5](#__refheading___toc28061799)

6\.  Stima delle risorse	[5](#__refheading___toc476_2645362287)

7\.  EARNED VALUE e BURN dOWN CHART	[5](#__refheading___toc28061805)

1. <a name="__refheading___toc28061790"></a>**SCOPO E CAMPO DI APPLICAZIONE**
   1. <a name="__refheading___toc28061791"></a>**SCOPO**

Creazione di un programma per la gestione di un processo produttivo tramite grafi.

1. <a name="__refheading___toc280617911"></a>**CAMPO DI APPLICAZIONE**

Questo progetto aiuterebbe le aziende ad una migliore ed efficiente gestione dei processi produttivi.

Questo documento permette tenere bene in mente cosa fare in questo progetto perché utilizzando vari componenti per la parte in backend e frontend è facile fare qualcosa di indesiderato.

1. <a name="__refheading___toc28061792"></a>**RIFERIMENTI**

<https://learn.microsoft.com/it-it/dotnet/core/introduction>

<https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-7.0&tabs=visual-studio>

<https://neo4j.com/>

1. <a name="__refheading___toc28061793"></a>**DEFINIZIONI ED ACRONIMI**

|**Grafo**|Struttura composta da nodi e archi per memorizzare e utilizzare dati e informazioni|
| :- | :- |
|**NET CORE**|Framework di casa Microsoft per lo sviluppo di programmi desktop o web app|
|**Razor**|Linguaggio di scripting lato server di Microsoft|
|**HTML**|Hyper Text Markup Language|
|**Web App**|Applicazione in rete accessibile da tutti i browser composte da una parte backend e frontend|
|**Scrum Cards**|Carte con dei numeri per prendere decisioni|
|**Pomodoro**|Unità di tempo pari a 25 minuti lavorativi + 5 minuti di pausa|
|||






1. <a name="__refheading___toc28061794"></a>**ANALISI DEI REQUISITI**

Dopo l’esposizione del problema da parte del professore, ci siamo riuniti per capire bene cosa volesse.

Abbiamo cercato un’epica che potesse andare bene e successivamente diviso il problema e analizzato le caratteristiche di queste parti. Quindi abbiamo diviso il progetto in stories e per ognuna di esse abbiamo trovato le feature necessarie per completarla. Successivamente tramite le scrum cards abbiamo ipotizzato le priorità delle stories e in pomodori il tempo necessario per effettuare le task

1. <a name="__refheading___toc28061795"></a>**FORNITURA**

Dal problema siamo arrivati alla conclusione di sviluppare una web app per renderlo accessibili a tutti i sistemi, escludendo una sua versione locale perché oggi giorno non è praticamente più usata.

Fin dall’inizio si punta sulla creazione delle strutture backend necessarie per il funzionamento del grafo e del personale e poi il suo sviluppo grafico.

Gli obiettivi minimi sono la conclusione della parte backend e arrivare vicino alla fine della parte di frontend. Si cerca di utilizzare a pieno il framework NET CORE per rendere il sito più robusto e semplice.

1. <a name="__refheading___toc28061799"></a>**WORK BREAK DOWN STRUCTURE**

**STORIES:** 

1. Creazione e gestione grafo →Priorità 1
1. ` `Login → Priorità 3
1. Navigazione del sito  → Priorità 5
1. Creazione e aggiunta documento → Priorità 7
1. Visualizzazione del grafo  → Priorità 8

**FEATURES:**

1\.**	Creazione e gestione grafo

1. Creazione 5 POM
1. Cancellazione 3 POM
1. Modifica 3 POM
1. Caricamento vecchio grafo 2 POM




1. Login
   1. Schermata grafica 3 POM
   1. Inserimento corretto dei dati 1,5 POM
   1. Database per salvare le informazioni 2 POM
   1. Aggiunta utente 1,7 POM




1. Navigazione del sito
   1. Header 2 POM
   1. Footer 2 POM
   1. Menù 4 POM
   1. Pulsante login e descrizione 2 POM
   1. Pulsanti crea, aggiunta, elimina grafo, aggiunta documenti 4.5 POM (DIRIGENTE)
   1. Creazione aggiunta tag, pulsante prossimo documento 4 POM (OPERAIO)
   1. Visualizzazione documenti a sinistra 5 POM
1. Creazione e aggiunta documento
   1. Creare tabella con i documenti vecchi 3,5 POM
   1. Pulsante invia grafo 2,5 POM




1. Visualizzazione del grafo
   1. Visualizzazione completa del grafo  5 POM
   1. Dettaglio dei nodi 4 POM
   1. Dinamicità del grafo 1 POM
   1. Visualizzazione documento 3 POM



1. <a name="__refheading___toc476_2645362287"></a>**STIMA DELLE RISORSE**

Come spiegato nel punto 3 abbiamo utilizzato il metodo delle scrum cards per stimare tempo e priorità.

Per le priorità a turno si sceglieva una carta, quello che ha scelto il numero minore spiega il perché e uguale per quello con la carta più grande, si sceglie nuovamente e si prende la carta con il numero più diffuso, più piccolo è il numero più sarà importante la stories. 

Per il tempo stessa cosa ma in questo caso più grande è il numero più tempo ci vorrà per finire questa feature. Il tempo è misurato in pomodori.

1. <a name="__refheading___toc28061805"></a>**EARNED VALUE E BURN DOWN CHART**

Preparare grafici e tabelle utili alla dirigenza, che saranno aggiornati durante le riunioni periodiche, per capire lo stato di salute del progetto.
**Uso interno ITIS Cuneo**                                             		Pagina 5/5
