using System;
using exercicios_aula_08.Models;

namespace exercicios_aula_08.Controllers
{
    public class PessoaController
    {
        PessoaModel pessoa = new PessoaModel();
        public void CadastrarPessoa(){
            try{
                Console.WriteLine("Digite seu nome:");
                pessoa.NomePessoa = Console.ReadLine();

                Console.WriteLine("Digite sua idade:");
                pessoa.IdadePessoa = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu peso:");
                pessoa.PesoPessoa = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite sua altura:");
                pessoa.AlturaPessoa = double.Parse(Console.ReadLine());
            }catch(Exception ex){
               Console.WriteLine("Desculpe! :( Houve um erro na aplicação. " + ex);
             }
        }

        public void CalcularIMC(){
            double imc = pessoa.PesoPessoa / (pessoa.AlturaPessoa*pessoa.AlturaPessoa);
            Console.WriteLine($"Seu IMC é de {imc}.");
            if(imc < 18.5){
                Console.WriteLine("Você está abaixo do peso.");
            }else if(imc >= 18.5 && imc < 25){
                Console.WriteLine("Você está com o peso normal.");
            }else if(imc >= 26 && imc < 30){
                Console.WriteLine("Você está com Sobrepeso.");
            }else if(imc >= 31 && imc < 35){
                Console.WriteLine("Você está com Obesidade Grau I.");
            }else if(imc >= 36 && imc < 39){
                   Console.WriteLine("Você está com Obesidade Grau II.");
            }else if(imc >= 40){
                Console.WriteLine("Você está com Obesidade Grau III.");
            }
        }
        
    }
}