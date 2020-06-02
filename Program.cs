using System;

namespace Aula8Abstraçao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito cielo = new CartaoCredito();

            System.Console.WriteLine("Digite a data do pagamento:");
            cielo.data = DateTime.Parse( Console.ReadLine() );
            System.Console.WriteLine("Data digitada:" +cielo.data);

        }
    }
}
