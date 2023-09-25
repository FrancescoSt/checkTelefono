
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