using HerançaExercicio.Entidades;
using System;

namespace HerançaExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEmpresarial empresa = new ContaEmpresarial(1010, "Microsoft", 150.0, 1000);

            Console.WriteLine(empresa.Saldo);
        }
    }
}
