using System;
using System.Globalization;

namespace BancoUdemy
{
    class Program
    {

        static void Main(string[] args)
        {

            CadConta conta;
            Console.Write("Entre o numero da conta:");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta:");
            string nome = Console.ReadLine();

            Console.Write("Ehaverá depósito inicial? (s/n)");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                System.Console.Write("Entre o valor do depósito inicial:");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new CadConta(numero, nome, depositoInicial);
            }
            else
            {
                conta = new CadConta(numero, nome);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta:");
            System.Console.WriteLine(conta);

            System.Console.WriteLine();
            Console.Write("Entre um valor para depósito:");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            System.Console.WriteLine("Dados da conta atualizado:");
            System.Console.WriteLine(conta);

            System.Console.WriteLine();
            Console.Write("Entre um valor para saque:");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            System.Console.WriteLine("Dados da conta atualizado:");
            System.Console.WriteLine(conta);
        }
    }
}
