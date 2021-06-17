using System;

namespace Exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioReajustado;

            Console.WriteLine("Entre com o valor do salario");
            string salario = Console.ReadLine();

            double valorSalario = Convert.ToDouble(salario);

            Console.WriteLine("Entre com o valor do reajuste");
            string reajuste = Console.ReadLine();

            double valReajuste = Convert.ToDouble(reajuste);

            salarioReajustado = valorSalario + ((valorSalario / 100) * valReajuste);
            Console.WriteLine(salarioReajustado);

        }
    }
}
