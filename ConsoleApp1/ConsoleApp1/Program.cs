using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    var cor = "verde";
        //    for (int i = 0; i < 5; i++) 
        //    {
        //        if (i == 2)
        //        {
        //            cor = "vermelho";
        //        }
        //        else 
        //        {
        //            cor = "verde";
        //        }
        //        Console.WriteLine(cor);
        //    }
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    Console.Write("Escreva seu nome: ");
        //    string nome = Console.ReadLine();
        //    Console.Write("O seu nome é: ");
        //    Console.WriteLine(nome);

        //}

        //static void Main(string[] args)
        //{
        //    Console.Write("Qual sua idade: ");
        //    int idade = int.Parse(Console.ReadLine());
        //    Console.Write("Sua idade: ");
        //    Console.WriteLine(idade);
        //    if (idade < 15 && idade>=0)
        //    {
        //        Console.WriteLine("voce é uma criança");
        //    }
        //    else if (idade >= 15 && idade <= 18)
        //    {
        //        Console.WriteLine("voce é um adolescente");
        //    }
        //    else if(idade > 18 && idade<60)
        //    {
        //        Console.WriteLine("voce é um adulto");
        //    }
        //    else
        //    {
        //        Console.WriteLine("voce é idoso");
        //    }
        //}

        static void Main(string[] args) 
        {
            exibir_msg();
            Console.ReadLine();
        }
        static void exibir_msg() 
        {
            Console.WriteLine("teste");
            Console.WriteLine("teste2");
        }
    }
}
