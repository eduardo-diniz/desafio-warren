// Um professor de programação, frustrado com a falta de disciplina de seus alunos, 
//decidi cancelar a aula se menos de x alunos estiverem presentes quando a aula for iniciada. 
//O tempo de chegada varia entre:

// Normal: tempoChegada <= 0
// Atraso: tempoChegada > 0
// Construa um algoritmo que dado o tempo de chegada de cada aluno e o 
//limite x de alunos presentes, determina se a classe vai ser cancelada ou não 
//("Aula cancelada” ou “Aula normal”).

class Desafio02
{

    static List<int> tempoChegada = new List<int>();

    static int alunosAtrasado = 0;
    static int alunosNoHorario = 0;
    static int qtdMinimadeAlunos()
    {
        int numeroMinAlunos;
        Console.WriteLine("Digita as quantidade minima de alunos para a aula ser realizada?");
        numeroMinAlunos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("A quantidade minima de alunos para a aula ser realizada é: " + numeroMinAlunos);
        return numeroMinAlunos;
    }


    static void definirTempoChegada()
    {

        Console.WriteLine("Digita a quantidade de alunos matriculado na disciplina: ");

        int qtdAlunosMatriculados = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < qtdAlunosMatriculados; i++)
        {

            Console.WriteLine("Digita o tempo de chegada do " + (i + 1) + "º aluno");
            int tempoChegar = Convert.ToInt32(Console.ReadLine());
            tempoChegada.Add(tempoChegar);
        }

    }

    static void imprimirLista()
    {

        for (int i = 0; i < tempoChegada.Count(); i++)
        {
            Console.WriteLine("Tempo de chegada do " + (i + 1) + "º" + " aluno: " + tempoChegada[i]);

        }

    }

    static void verificadorDeAula()
    {

        foreach (var item in tempoChegada)
        {
            if (item < 0)
            {
                alunosAtrasado++;
            }
            else
            {

                alunosNoHorario++;

            }

        }

        if (alunosNoHorario >= qtdMinimadeAlunos())
        {
            Console.WriteLine("A aula possui " + alunosNoHorario + " alunos presentes no horario");
            Console.WriteLine("Aula normal!");
        }
        else
        {
            Console.WriteLine("A aula possui apenas " + alunosNoHorario + " alunos no horario");
            Console.WriteLine("Aula cancelada!");

        }

    }

    public static void executarDesafio2()
    {
        Console.WriteLine("Desafio 2: ");
        definirTempoChegada();
        verificadorDeAula();
        Console.WriteLine("************************************************");


    }




}