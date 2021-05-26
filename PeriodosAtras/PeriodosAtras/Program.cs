using System;
using PeriodosAtras.Periodo;

namespace PeriodosAtras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Humunizar(DateTime.Now, DateTime.Parse("11/11/2011")).valor_saida);
        }
    }
}
