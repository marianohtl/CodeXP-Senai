using System;
using ex_02.Model;

namespace ex_02.Controller
{
    public class CelularControllers
    {
        CelularModel celular = new CelularModel();
 
        public void CadastrarCelular(){
              try{
            Console.WriteLine("Digite o modelo do seu celular:");
            celular.Modelo = Console.ReadLine();

            Console.WriteLine("Digite a cor do seu celular:");
            celular.Cor = Console.ReadLine();

            Console.WriteLine("Digite o tamanho do seu celular:");
            celular.Tamanho = double.Parse(Console.ReadLine());
          
            }catch(Exception ex){
              Console.WriteLine("Desculpe, houve uma falha no sistema :/ "+ex);
            }
        }
        public void ligar(){
            celular.Ligado = true;
            Console.WriteLine("Celular ligado!!!  :)");
        }

        public void desligar(){
            celular.Ligado = false;
            Console.WriteLine("Celular desligado!!!  x_x");
        }

        public void fazerLigacao(){
            if(celular.Ligado == true){
                Console.WriteLine("Digite seu número de telefone:");
                string number = Console.ReadLine();
                Console.WriteLine("Inciando chamada.");
                Console.WriteLine(".");
                Console.WriteLine("..");
                Console.WriteLine("...");
            }else{
                Console.WriteLine("Impossível fazer chamada.");
            }
        }

        public void enviarMensagem(){
            if(celular.Ligado == true){
                Console.WriteLine("Digite seu número de telefone:");
                string number = Console.ReadLine();
                Console.WriteLine("Escreva sua mensagem:");
                string msg = Console.ReadLine();
                Console.WriteLine("Mensagem Enviada.");
            }else{
                Console.WriteLine("Impossível enviar mensagem.");
            }
        }

    }
}