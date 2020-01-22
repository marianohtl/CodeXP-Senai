using System;

namespace organix_buscar_produto {
    class Program {
        static void Main (string[] args) {
                string regiao, min, max;
                int produto;
                Console.WriteLine ("ESCOLHA UMA REGIÃO: \n Zona Norte  \n Zona Leste \n Zona Oeste \n Zona Sul ");
                regiao = Console.ReadLine ();
                Console.WriteLine ("PREÇO MÁXIMO:");
                max = Console.ReadLine ();
                Console.WriteLine ("PREÇO MÍNIMO:");
                min = Console.ReadLine ();

                if (regiao == ""  || min == "" || max == "") {
                    Console.WriteLine ("Preencha os campos obrigatórios.");
                } else {

                    switch (regiao) {

                        case "Zona Norte":
                            Console.WriteLine ("ESCOLHA UM PRODUTO: \n 1 - Batata \n 2 - Beterraba \n 3 - Arroz\n 4 - Maçã");
                            produto = int.Parse (Console.ReadLine ());
                            switch (produto) {
                                case 1:
                                    Console.WriteLine ("PRODUTO: Batata\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                    break;
                                case 2:
                                    Console.WriteLine ("PRODUTO: Beterraba\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                    break;
                                case 3:
                                    Console.WriteLine ("PRODUTO: Arroz\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                    break;
                                case 4:
                                    Console.WriteLine ("PRODUTO: Maçã\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                    break;
                                default:
                                    Console.WriteLine ("Opção Inválida");
                                    break;
                            }
                                    break;

                                case "Zona Leste":
                                    Console.WriteLine ("ESCOLHA UM PRODUTO: \n 1 - Amendoim \n 2 - Pera \n 3 - Cenoura\n 4 - Cebola");
                                    produto = int.Parse (Console.ReadLine ());
                                    switch (produto) {
                                        case 1:
                                            Console.WriteLine ("PRODUTO: Amendoim\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                            break;
                                        case 2:
                                            Console.WriteLine ("PRODUTO: Pera\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                            break;
                                        case 3:
                                            Console.WriteLine ("PRODUTO: Cenoura\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                            break;
                                        case 4:
                                            Console.WriteLine ("PRODUTO: Cebola\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                            break;
                                        default:
                                            Console.WriteLine ("Opção Inválida");
                                            break;
                                    }
                                break;

                                case "Zona Oeste":
                                            Console.WriteLine ("ESCOLHA UM PRODUTO: \n 1 - Batata \n 2 - Lixia \n 3 - Banana\n 4 - Cebola");
                                            produto = int.Parse (Console.ReadLine ());
                                            switch (produto) {
                                                case 1:
                                                    Console.WriteLine ("PRODUTO: Batata\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                                    break;
                                                case 2:
                                                    Console.WriteLine ("PRODUTO: Lixia\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                                    break;
                                                case 3:
                                                    Console.WriteLine ("PRODUTO: Banana\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                                    break;
                                                case 4:
                                                    Console.WriteLine ("PRODUTO: Cebola\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                                    break;
                                                default:
                                                    Console.WriteLine ("Opção Inválida");
                                                    break;
                                            }
                                    break;

                                    case "Zona Sul":
                                                    Console.WriteLine ("ESCOLHA UM PRODUTO: \n 1 - Pinha \n 2 - Beterraba \n 3 - Xuxu\n 4 - Cebola");
                                                    produto = int.Parse (Console.ReadLine ());
                                                    switch (produto) {
                                                        case 1:
                                                            Console.WriteLine ("PRODUTO: Pinha\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                                            break;
                                                        case 2:
                                                            Console.WriteLine ("PRODUTO: Beterraba\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                                            break;
                                                        case 3:
                                                            Console.WriteLine ("PRODUTO: Xuxu\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                                            break;
                                                        case 4:
                                                            Console.WriteLine ("PRODUTO: Cebola\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                                            break;
                                                        default:
                                                            Console.WriteLine ("Opção Inválida");
                                                        break;
                                                    }
                                                    break;
                                        default:
                                             Console.WriteLine ("Região inválida!");
                                        break;
                                                    }
                        }

                    }
                }
        }

                