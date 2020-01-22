using System;
using ex_04.Model;

namespace ex_04.Controller
{
    public class CalculadoraControllers
    {
        CalculadoraModel calc = new CalculadoraModel();
        public void somar(){
        try{
            Console.WriteLine("Digite um número:");
            calc.n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            calc.n2 = double.Parse(Console.ReadLine());
            calc.result = calc.n1 + calc.n2;
            Console.WriteLine("O resultado da soma é "+calc.result);
         }catch(Exception ex){
              Console.WriteLine("Desculpe, houve uma falha no sistema :/  "+ex);
            }
        }
        public void subtrair(){
        try{
            Console.WriteLine("Digite um número:");
            calc.n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            calc.n2 = double.Parse(Console.ReadLine());
            calc.result = calc.n1 - calc.n2;
            Console.WriteLine("O resultado da subtração é "+calc.result);

         }catch(Exception ex){
              Console.WriteLine("Desculpe, houve uma falha no sistema :/  "+ex);
            }
        }

           public void multiplicar(){
        try{
            Console.WriteLine("Digite um número:");
            calc.n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            calc.n2 = double.Parse(Console.ReadLine());
            calc.result = calc.n1 * calc.n2;
            Console.WriteLine("O resultado da multiplicação é "+calc.result);

         }catch(Exception ex){
              Console.WriteLine("Desculpe, houve uma falha no sistema :/  "+ex);
            }
        }
           public void dividir(){
                try{
                    bool verificador = true;
                while(verificador == true){
                    Console.WriteLine("Digite um número:");
                    calc.n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite outro número:");
                    calc.n2 = double.Parse(Console.ReadLine());
                    if(calc.n1 != 0 && calc.n2 != 0){
                    calc.result = calc.n1 / calc.n2;
                    Console.WriteLine("O resultado da divisão é "+calc.result);
                    verificador = false;
                    }else{
                        Console.WriteLine("Valor inválido. Tente novamente.");                
                    }
                }
                }catch(Exception ex){
                    Console.WriteLine("Desculpe, houve uma falha no sistema :/  "+ex);
                    }
                }
    }
}