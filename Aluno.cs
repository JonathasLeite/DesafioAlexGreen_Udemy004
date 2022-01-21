using System;
using System.Globalization;

namespace DesafioAlexGreen_Udemy004
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

       public void SomaNota()
        {
            double NotaFim = Nota1 + Nota2 + Nota3;
            
            Console.WriteLine("Nota final: " + NotaFim.ToString("f2", CultureInfo.InvariantCulture));
            
            if(NotaFim < 60.00)
            {
                Console.WriteLine("REPROVADO");
                double diferenca = 60.00 - NotaFim;
                Console.WriteLine("Faltam: " + diferenca.ToString("f2",CultureInfo.InvariantCulture) +" pontos");
            }
            else
            {
                Console.WriteLine("APROVADO");
            }
            
        }
    }
}
