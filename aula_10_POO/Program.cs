using System;
using aula_10_POO.Controllers;
using aula_10_POO.Models;

namespace aula_10_POO
{
    class Program
    {
        static void Main(string[] args)
        {
          CarrosControllers carro = new CarrosControllers();
//          CarroEletricoModel carroEletrico = new CarroEletricoModel();
          CarroEletricoController carroEletrico = new CarroEletricoController();
          CarroEletricoModel carroEletricoM = new CarroEletricoModel();

          Console.Clear();
        
          carroEletrico.Ligar();
          carroEletrico.CarregarBateria(100);
          carroEletrico.CarregarBateria(15);
          Console.WriteLine("Carga do carro: "+ carroEletrico.StatusBateria());

        }
    }
}
