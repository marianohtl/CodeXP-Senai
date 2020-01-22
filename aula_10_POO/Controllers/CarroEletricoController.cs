using System;
using aula_10_POO.Models;

namespace aula_10_POO.Controllers
{
    public class CarroEletricoController : CarrosControllers
    {
        //Declarando carroElétricoModel
        CarroEletricoModel carroEletrico = new CarroEletricoModel();
        //Declarando objeto motorModel
        MotorModel motor = new MotorModel();
        
        public void CarregarBateria(float carga){
            if(carroEletrico.bateria < 100){
                carroEletrico.bateria += carga;
            //é o mesmo que ...
            //carroEletrico.Bateria = carroEletrico.Bateria = carga;
            }else{
                Console.WriteLine("A bateria do carro já está completa! Pode viajar!");
            }

        }

        public float StatusBateria(){
            return carroEletrico.bateria;
        }
    }
}