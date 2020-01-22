using System;

namespace exercicios_aula_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            
            if(idade < 3){
                Console.WriteLine("Na sua idade, você não deveria jogar games");
            }else if (idade >= 3 && idade < 6){
                Console.WriteLine("Você está apto as consumir seguintes categorias de games: EC - Early Childhood");
            }else if (idade >= 6 && idade < 10){
                Console.WriteLine("Você está apto as seguintes categorias: EC - Early Childhood, E - Everyone ");
            }else if (idade >= 10 && idade < 13){
                Console.WriteLine("Você está apto as seguintes categorias: EC - Early Childhood, E - Everyone, E10+ - Everyone 10+");
            }else if (idade >= 13 && idade < 17){
                Console.WriteLine("Você está apto as seguintes categorias: EC - Early Childhood, E - Everyone, E10+ - Everyone 10+ , T - Teen");
            }else if (idade >= 18 ){
                Console.WriteLine("Você está apto as seguintes categorias: EC - Early Childhood, E - Everyone, E10+ - Everyone 10+ , T - Teen, M - Mature.");
            }
        }
    }
}
