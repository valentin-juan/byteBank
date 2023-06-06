Console.WriteLine("Boas vindas ao ByteBank, Atendimento.");

// TestaArrayInt();

/*void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 00;
    idades[1] = 10;
    idades[2] = 20;
    idades[3] = 30;
    idades[4] = 40;

    Console.WriteLine($"Tamanho do array: {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Indice [{i}] = {idades[i]}");
        acumulador += idade;
    }
    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades: {media}");
}*/

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i+1}ª palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach(var palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}.");
            break;
        }
    }
}

TestaBuscarPalavra();