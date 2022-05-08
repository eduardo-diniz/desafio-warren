// Dado um vetor de números e um número n.
//  Determine a soma com o menor número de elementos
//  entre os números do vetor mais próxima de n e também 
// mostre os elementos que compõem a soma. Para criar a soma, 
// utilize qualquer elemento do vetor uma ou mais vezes.

class Desafio03
{
    static int[] numeros = { 2, 3, 4 };
    static int qtdElementos = 3;
    static int n = 10;
    static int[] arrayDeElementos = new int[qtdElementos];

    static void arraysPossiveis(int indice, int inicio)
    {


        for (int i = inicio; i < numeros.Length; i++)
        {

            arrayDeElementos[indice] = numeros[i];

            if (indice + 1 < qtdElementos)
            {
                arraysPossiveis(indice + 1, i);

            }

            else if (indice + 1 >= qtdElementos && arrayDeElementos.Sum() == n)
            {
                imprimirLista();
            }

        }
    }

    static void imprimirLista()
    {
        Console.WriteLine("[" + string.Join(",", arrayDeElementos ) + "]");

    }

    public static void executarDesafio3()
    {
        Console.WriteLine("Desafio 3: ");
        Console.WriteLine("Numero base para alcançar: " + n);
        arraysPossiveis(0, 0);
        Console.WriteLine("************************************************");

    }
}
