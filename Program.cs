using System;
using System.Globalization;

namespace DesafioAlexGreen_Udemy004
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            Console.Write("Digite o nome do Aluno: ");
            aluno1.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Difite as três notas do aluno");

            aluno1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno1.SomaNota();
        }
    }
}
