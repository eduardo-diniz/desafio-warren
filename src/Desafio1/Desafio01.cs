
// Alguns números inteiros positivos n possuem uma propriedade na qual a soma de n + reverso(n) 
// resultam em números ímpares. Por exemplo, 36 + 63 = 99 e 409 + 904 = 1313. 
// Considere que n ou reverso(n) não podem começar com 0.

// Existem 120 números reversíveis abaixo de 1000.

// Construa um algoritmo que mostre na tela todos os números n onde a soma de n + reverso(n)
//  resultem em números ímpares que estão abaixo de 1 milhão.
class Desafio01
{


    static int qtdNumeroRevertidos = 0;
    static List<int> numerosDeEntrada = new List<int>();
    static List<int> numerosInvertidos = new List<int>();
    static List<int> numerosSomados = new List<int>();


    static bool verificadorDeNumerosImpares(int somaDosNumeros)
    {

        while (somaDosNumeros > 0)
        {

            if ((somaDosNumeros % 10) % 2 == 0)
            {

                return false;
            }
            somaDosNumeros = somaDosNumeros / 10;
        }
        return true;

    }

    static string inverterNumero(int numeroDeEntrada)
    {

        char[] numeros = numeroDeEntrada.ToString().ToCharArray();
        Array.Reverse(numeros);
        var numeroRevertido = new string(numeros);
        return numeroRevertido;
    }

    static void numerosReversiveis(int entrada)
    {

        if (entrada < 10)
        {
            return;
        }

        var entradaRevertida = inverterNumero(entrada);

        if (Char.IsDigit(entradaRevertida[0]) && entradaRevertida[0].Equals('0'))
        {
            return;
        }
        else
        {
            var somaDosNumeros = entrada + int.Parse(entradaRevertida);

            if (verificadorDeNumerosImpares(somaDosNumeros) && somaDosNumeros < 10000000)
            {
                numerosDeEntrada.Add(entrada);
                numerosInvertidos.Add(int.Parse(entradaRevertida));
                numerosSomados.Add(somaDosNumeros);
                qtdNumeroRevertidos += 1;
            }
            return;
        }
    }


    static void numerosDeZeroaMilhao()
    {
        for (int i = 0; i < 1000000; i++)
        {
            numerosReversiveis(i);
        }
        Console.WriteLine(qtdNumeroRevertidos);
    }

    static void imprimirLista()
    {

        Console.WriteLine("**Lista de números n onde a soma de n + reverso(n) resultem em números ímpares:**");
        for (int i = 0; i < numerosSomados.Count(); i++)
        {

            Console.WriteLine("Numero de Entrada :" + numerosDeEntrada[i] + " + " + " Numero Invertido :"
             + numerosInvertidos[i] + " = " + numerosSomados[i]);

        }

        Console.WriteLine("Existem " + qtdNumeroRevertidos + " números reversíveis abaixo de 1 milhão.");

    }

    public static void executarDesafio1()
    {
        Console.WriteLine("Desafio 1: ");
        numerosDeZeroaMilhao();
        imprimirLista();
        Console.WriteLine("************************************************");

    }


}


