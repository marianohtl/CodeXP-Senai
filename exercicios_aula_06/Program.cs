using System;

namespace exercicios_aula_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int sair = 1;
            while(sair != 0){
                int opcão;
                String[] nome = new string[5];
                String[] origem = new string[5];
                String[] destino = new string[5];
                String[] data = new string[5];
                bool validar = true;

                Console.WriteLine("Digite a opção que você deseja:");
                Console.WriteLine("=================================");
                Console.WriteLine(" 1 - Cadastrar Passagem");
                Console.WriteLine(" 2 - Listar Passagem");
                Console.WriteLine(" 0 - Sair");
                Console.WriteLine("=================================");
                
                opcão = int.Parse(Console.ReadLine());

             switch(opcão){
                case 1:
                for(int i =0;i <10; i++){
                        Console.WriteLine("Digite seu nome: ");
                        nome[i] = Console.ReadLine();
                        Console.WriteLine("Digite sua origem: ");
                        origem[i] = Console.ReadLine();
                        Console.WriteLine("Digite seu destinho: ");
                        destino[i] = Console.ReadLine();
                        Console.WriteLine("Digite a data do voo: ");
                        data[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Opção Inválida");
                   
                    while( validar == true){
                        Console.WriteLine("Digite a opção que você deseja:");
                        Console.WriteLine("=================================");
                        Console.WriteLine(" 1 - Cadastrar Passagem");
                        Console.WriteLine(" 2 - Listar Passagem");
                        Console.WriteLine(" 0 - Sair");
                        Console.WriteLine("=================================");
                        opcão = int.Parse(Console.ReadLine());
                        validar = false;
                    }

                break;
                case 2:
                    for(int i =0;i <10; i++){
                        Console.WriteLine($"Nº DO PEDIDO: {i+1} PASSAGEIRO: {nome[i]} - ORIGEM DO USUÁRIO: {origem[i]} - DESTINO DO PASSAGEIRO: {destino[i]} - DATA DO VOO: {data[i]} ");  
                    }
                break;
                case 3:
                    opcão = 0;
                break;
                default:
                    Console.WriteLine("Opção Inválida");
                    while( validar == true){
                        Console.WriteLine("Digite a opção que você deseja:");
                        Console.WriteLine("=================================");
                        Console.WriteLine(" 1 - Cadastrar Passagem");
                        Console.WriteLine(" 2 - Listar Passagem");
                        Console.WriteLine(" 0 - Sair");
                        Console.WriteLine("=================================");
                        opcão = int.Parse(Console.ReadLine());
                    }
                break;
            }

            }
        }
    }
}
