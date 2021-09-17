using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular o juros e o montante");

            Console.WriteLine();

            Console.Write("Digite o capital(R$): ");
            string capitalValor = Console.ReadLine();
            double capitalNumero = Double.Parse(capitalValor);

            Console.WriteLine();

            Console.Write("Digite o taxa(%): ");
            string taxaValor = Console.ReadLine();
            double taxaNumero = Double.Parse(taxaValor);

            Console.WriteLine();

            Console.Write("Digite o tempo(meses): ");
            string tempoValor = Console.ReadLine();
            double tempoNumero = Double.Parse(tempoValor);

            double jurosValor = capitalNumero*(taxaNumero/100)*tempoNumero;

            double montanteValor = jurosValor+capitalNumero;

            Console.WriteLine();

            Console.WriteLine("Juros(R$): " + jurosValor);
            Console.WriteLine("Montante(R$): " + montanteValor);
        }
    }
}
