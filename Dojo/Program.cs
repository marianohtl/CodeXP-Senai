using System;

namespace Dojo {
    class Program {
        static void Main (string[] args) {
            string[] produto = new string[10];
            double[] preco = new double[10];
            string sair = "";
            double soma = 0;
            string resposta = "S";
            int ii = 0;

            while (sair != "0") {
                Console.WriteLine ("Menu \n 1- Cadastrar produto: \n 2-Listar todos os produtos: \n 3-Calcular soma:");
                sair = Console.ReadLine ();
                switch (sair) {
                    case "1":

                        while (resposta == "S") {
                            Console.WriteLine ("Digite o produto: ");
                            produto[ii] = Console.ReadLine ();

                            Console.WriteLine ("Digite o preço: ");
                            preco[ii] = double.Parse (Console.ReadLine ());

                            Console.WriteLine("Deseja Cadastrar mais um produto ? S/N");
                            resposta = Console.ReadLine().ToUpper();

                            ii++;

                            if(resposta == "N"){
                                resposta = "N";
                            }
                            if(ii >= 9){
                                resposta = "N";
                            }
                        }

                        break;

                        case "2":
                            for (int i = 0; i <= 9; i++)
                            {Console.WriteLine($"Produto:{produto[i]} Preço: {preco[i]}");
                                
                            } break;

                            case "3":
                                for (int i = 0; i <= 9; i++)
                                { soma = soma + preco[i];
                                    
                                }
                                Console.WriteLine($"A soma do preço dos produtos é:  {soma}");
                                break;

                                default: 
                                Console.WriteLine("Valores inválidos");

                                break;

                }

            }

        }
    }
}