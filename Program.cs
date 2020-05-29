using System;

namespace HerancaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
           CPF cpf = new CPF();
            cpf.nome = "Gabriel";
            System.Console.WriteLine( cpf.saudar() );
        }
    }
}
