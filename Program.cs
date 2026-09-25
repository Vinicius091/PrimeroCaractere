using System;

class Program
{
    static void Main ()
    {
        Console.WriteLine("Digite um texto:");

        //Lê a linha digitada pelo usuario
        string entrada = Console.ReadLine() ?? string.Empty;

        //Remove os espaços do início e do fim
        string textoSemEspacos = entrada.Trim();

        if (textoSemEspacos.Length > 0)
        {
            Console.WriteLine(textoSemEspacos[0]);
        }

    }

}