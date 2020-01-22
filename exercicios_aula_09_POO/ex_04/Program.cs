using System;
using ex_04.Controller;

namespace ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraControllers calc01 = new CalculadoraControllers();
            CalculadoraCientificaControllers calc02 = new CalculadoraCientificaControllers();

            calc01.somar();
            calc01.subtrair();
            calc01.multiplicar();
            calc01.dividir();
            calc02.CalcularPotencia();
            calc02.somar();
        }
    }
}
