using System;
using aula_10_POO.Model;
using aula_10_POO.Models;

namespace aula_10_POO.Controllers
{
    public class CarrosControllers
    {
     CarroModel carro = new CarroModel();
    MotorModel motor = new MotorModel();

     public void Ligar(){

         carro.Ligado = true;
         Console.WriteLine("Carro ligado!");
     }   
     
     public void DesligarCarro(){
         carro.Ligado = false;
         Console.WriteLine("Desligando carro...");
     } 

     public void Acelerar(){
         if(carro.Ligado == true){
             Console.WriteLine("Carro acelerando!");
         }else{
             Console.WriteLine("O carro não está ligado, impossível acelerar.");
         }
     }

     
     public void Frear(){
         if(carro.Ligado == true){
             Console.WriteLine("Carro freando!");
         }else{
             Console.WriteLine("O carro não está está ligado! Impossível frear.");
         }
     }

     public void CasdastrarMotor(){
         Console.WriteLine("Insira quantos cavalos tem o motor:");
         motor.Cavalos = int.Parse(Console.ReadLine());
         Console.WriteLine("Insira quantos cilindros tem o carro:");
         motor.Cilindros = int.Parse(Console.ReadLine());
         Console.WriteLine("Insira o modelo do pistão do carro:");
         motor.Pistao = Console.ReadLine();
     }


    }
}