using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //declara una lista de cadenas 
        List<string> aves = new List<string> { "Loro gris", "Paloma de diamante", "Coctel" };
        Console.WriteLine("Los valores de la lista antes de insertar:");
        //Itera sobre la lista para imprimir los valores 
        foreach (string ave in aves)
        {
            Console.Write(ave + " ");
        }
        Console.WriteLine();
        //Agrega tres valores al final de la lista utilizando el metodo Add()
        aves.Add("Mayna");
        aves.Add("Periquitos");
        aves.Add("Cacatua");
        Console.WriteLine("Los valores de la lista despues de insertar:");
        //Itera sobre la lista para imprimir los valores
        foreach (string ave in aves)
        {
            Console.Write(ave + "");
        }
        Console.WriteLine();

    }
}