using System;

class Program
{
    static void Main ()
    {
        //Lê a linha digitada pelo usuario
        string entrada = Console.ReadLine();

        //Remove os espaços do início e do fim
        string textoSemEspaços = entrada.Trim();

        // Pega o primeiro caractere da string limpa
        char primeiroCaractere = textoSemEspacos[0];

        //exibe o resultado esperado
        Console.WriteLine(primeiroCaractere);

    }

}