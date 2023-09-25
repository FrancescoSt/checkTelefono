# checkTelefono

## Descrizione 
Ricevuto come parametro un vettore di string, ritornare al chiamante la prima stringa che assomiglia molto ad un numero di telefono cellulare italiano (Se il numero non viene trovato, ritornare stringa vuota ""

## Codice (senza commenti)
``` c#
using System;
using System.Collections.Generic;

public static class Telefono
{
    public static string Check(string[] input)
    {
        string numeroTrovato = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Contains("+39"))
            {
                if (input[i].Length == 13)
                {
                    numeroTrovato = input[i];
                    break;
                }
            }
            else if (input[i].Contains("0039"))
            {
                if (input[i].Length == 14)
                {
                    numeroTrovato = input[i];
                    break;
                }
            }
            else if (input[i].Contains("3"))
            {
                if (input[i].Length == 10)
                {
                    if (!input[i].Contains(" "))
                    {
                        numeroTrovato = input[i];
                        break;
                    }
                }
            }
        }

        return numeroTrovato;
    }
}

``` 

## Codice (con commenti)
 ``` c#
 
using System;
using System.Collections.Generic;

public static class Telefono
{

    public static string Check(string[] input)
    {
        string numeroTrovato = "";

        // Iteriamo su tutti i numeri
        for (int i = 0; i < input.Length; i++)
        {
            // Controlliamo se il numero contiene il prefisso +39
            if (input[i].Contains("+39"))
            {
                // Controlliamo se il numero ha la lunghezza corretta
                if (input[i].Length == 13)
                {
                    numeroTrovato = input[i];
                    break;
                }
            }

            // Controlliamo se il numero contiene il prefisso 0039
            else if (input[i].Contains("0039"))
            {
                // Controlliamo se il numero ha la lunghezza corretta
                if (input[i].Length == 14)
                {
                    numeroTrovato = input[i];
                    break;
                }
            }

            // Controlliamo se il numero inizia con 3
            else if (input[i].Contains("3"))
            {
                // Controlliamo se il numero ha la lunghezza corretta
                if (input[i].Length == 10)
                {
                    // Controlliamo la presenza di spazi
                    if (!input[i].Contains(" "))
                    {
                        numeroTrovato = input[i];
                        break;
                    }
                }
            }
        }

        return numeroTrovato;
    }
}
 ``` 
## Divisione in pezzi + spiegazione
* Inizializzazione della variabile e inizio del ciclo for
``` c#
string numeroTrovato = "";

  for (int i = 0; i < input.Length; i++)
```
## In questa parte, viene dichiarata una variabile di stringa chiamata numeroTrovato e inizializzata con una stringa vuota. Successivamente, inizia un ciclo for che itererà attraverso tutti gli elementi nell'array di stringhe input. 

*  Controllo del prefisso +39 e della lunghezza del numero
``` c#
if (input[i].Contains("+39"))
{
    // Controlliamo se il numero ha la lunghezza corretta
    if (input[i].Length == 13)
    {
        numeroTrovato = input[i];
        break;
    }
}
```
## In questa parte, all'interno del ciclo for, vengono eseguite due condizioni di controllo annidate. La prima condizione verifica se la stringa input[i] contiene il prefisso "+39". Se questa condizione è vera, viene eseguita una seconda condizione per verificare se la lunghezza del numero è esattamente 13 caratteri. Se entrambe le condizioni sono soddisfatte, la variabile numeroTrovato viene assegnata con il valore corrente di input[i], e il ciclo viene interrotto con break.

* Controllo del prefisso 0039 e della lunghezza del numero
``` c#
else if (input[i].Contains("0039"))
{
    // Controlliamo se il numero ha la lunghezza corretta
    if (input[i].Length == 14)
    {
        numeroTrovato = input[i];
        break;
    }
}
```
## In questa parte, vengono eseguite condizioni di controllo simili alla parte precedente, ma stavolta si verifica la presenza del prefisso "0039" e la lunghezza del numero deve essere di 14 caratteri. Se queste condizioni sono soddisfatte, la variabile numeroTrovato viene assegnata con il valore corrente di input[i], e il ciclo viene interrotto con break.

* Controllo del numero che inizia con 3 e della lunghezza del numero
``` c#
else if (input[i].Contains("3"))
{
    if (input[i].Length == 10)
    {
        if (!input[i].Contains(" "))
        {
            numeroTrovato = input[i];
            break;
        }
    }
}
``` 
## In questa parte, vengono eseguite ulteriori condizioni di controllo. Qui verifichiamo se il numero inizia con il carattere "3" e se la lunghezza è di 10 caratteri. Se queste due condizioni sono soddisfatte, viene eseguito un controllo aggiuntivo per verificare che non ci siano spazi nella stringa. Se anche questa condizione è soddisfatta, la variabile numeroTrovato viene assegnata con il valore corrente di input[i], e il ciclo viene interrotto con break

*  Restituzione del numero trovato
``` c#
}

return numeroTrovato;
``` 
## Questa è la parte finale del codice. Qui viene chiuso il ciclo for e la funzione restituisce il valore contenuto nella variabile numeroTrovato, che rappresenta il primo numero che soddisfa una delle condizioni specificate all'interno del ciclo. Se nessuna di queste condizioni è soddisfatta, il valore di numeroTrovato rimarrà una stringa vuota.

  
