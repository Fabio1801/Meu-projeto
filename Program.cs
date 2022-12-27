
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabio
{
    class Program
    {
      static void Main ()
      {
        string nome;
        int idade;

        Console.WriteLine("Você só pode entrar na festa se for de maior!");

        Console.WriteLine("Digite o seu nome !");

        nome = Console.ReadLine();

        Console.WriteLine("Digite a sua idade !");

        idade = int.Parse(Console.ReadLine());

        if(idade < 18 )
        {
          Console.WriteLine(" Você não pode entrar !");
        }
        else
        {
          Console.WriteLine(" Você  pode entrar !");
        }

        


      }
    

       
    }



}













    