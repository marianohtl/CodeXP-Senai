using System;

namespace ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string pedido;
            Console.WriteLine("Digite o número do seu pedido:");
            num = int.Parse(Console.ReadLine());

        switch(num){
          case 1:
            pedido = "Hamburger";
          break;
          case 2:
            pedido = "Cheese Salada";
          break;
          case 3:
            pedido = "Cheese Burguer";
          break;
          case 4:
            pedido = "Cheese Bacon";
          break;
          default:
            pedido = "Opção inválida!";
          break;
            }
        Console.WriteLine($"Seu pedido é um {pedido}.");
        }
    }
}
