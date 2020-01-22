using System;

namespace ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso; 
            float resultado = 0;
            int planeta;
            bool c = false;
            string excecao = "";
            Console.WriteLine("Digite seu peso:");
            peso = float.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite em qual planeta quer estar.");
            Console.WriteLine("====================\n=   1 . Mercúrio   =\n=   2 . Vênus      =\n=   3 . Marte      =\n=   4 . Júpter     =\n=   5 . Saturno    =\n=   6 . Urano      =\n====================");
            planeta = int.Parse(Console.ReadLine());
          
        switch(planeta){
          case 1:
            resultado = (peso/10f)*0.37f;
          break;
          case 2:
            resultado = (peso/10f)*0.88f;
          break;
          case 3:
            resultado = (peso/10f)*0.38f;
          break;
        case 4:
            resultado = (peso/10f)*2.64f;
          break;
          case 5:
            resultado = (peso/10f)*1.15f;            
          break;
          case 6:
            resultado = (peso/10f)*1.17f;        
          break;
          default:
            c = true;
            excecao = "Opção inválida.";
          break;
        }

        if(c == true){
            Console.WriteLine($"{excecao}");
        }else{
            Console.WriteLine($"O seu peso é {resultado}.");
        }
        
        }
    }
}
