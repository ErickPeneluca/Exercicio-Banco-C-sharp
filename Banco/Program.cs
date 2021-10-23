using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            Console.Write("Entre o número da conta: ");
            conta.Numero = int.Parse(Console.ReadLine());


            Console.Write("Entre o titular da conta: ");
            conta.Nome = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n)?");
            string resposta = Console.ReadLine();

            if (resposta == "s" || resposta == "S")
            {

                Console.Write("Entre com o depósito inicial: ");
                conta.Saldo = double.Parse(Console.ReadLine());

                Console.WriteLine("Dados da conta: " + conta);


                Console.WriteLine("Entre um valor para depósito: ");
                conta.AdicionarDinheiro(double.Parse(Console.ReadLine()));

                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta);

                Console.WriteLine("Entre um valor para saque: ");
                conta.RetirarDinheiro(double.Parse(Console.ReadLine()));

                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta);
            }
            else if (resposta == "n" || resposta == "N")
            {

                Console.WriteLine("Dados da conta: " + conta);

                Console.WriteLine("Entre um valor para depósito: ");
                conta.AdicionarDinheiro(double.Parse(Console.ReadLine()));

                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta);

                Console.WriteLine("Entre um valor para saque: ");
                conta.RetirarDinheiro(double.Parse(Console.ReadLine()));

                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta);

            }
            else
            {
                Console.WriteLine("Escolha uma opção válida por favor!");
            }

        }
    }
}
