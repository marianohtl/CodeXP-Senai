using System;
using ex_04.Model;

namespace ex_04.Controller
{
    public class CalculadoraCientificaControllers : CalculadoraControllers
    {
        CalculadoraModel calc = new CalculadoraModel();
         public void CalcularPotencia(){
            Console.WriteLine("Deseja calcular a potência de que número?");
            calc.n1 = double.Parse(Console.ReadLine());
            calc.result = calc.n1 * calc.n1;
            Console.WriteLine($"O resultado da potência é {calc.result}");
         } 
    }
}