using _06_ByteBank;
using System;

namespace _06___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.DefinirSaldo(10);

            Console.WriteLine(conta.ObterSaldo());

            Console.ReadLine();
        }
    }
}
