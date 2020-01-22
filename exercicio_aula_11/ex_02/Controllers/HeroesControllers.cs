using System;
using ex_02.Models;
using ex_02.Controllers;

namespace ex_02.Controllers
{
    public class HeroesControllers
    {
        HeroesModel heroes = new HeroesModel();
        HomemFerroModel ferro = new HomemFerroModel();
        CapitaoAmericaModel capitao = new CapitaoAmericaModel();

        CapitaoControllers capitaoC = new CapitaoControllers();

        FerroControllers ferroC = new FerroControllers();

        public void ExibirDadosF(){
            Console.WriteLine($"VIDA: {ferro.Vida} | ARMADURA: {ferro.Armadura} | EQUIPE: {ferro.Equipe} | COR DO TEXTO: {ferro.CorText}");
        }
        
        public void ExibirDadosC(){
            Console.WriteLine($"VIDA: {capitao.Vida} | ARMADURA: {capitao.Escudo} | EQUIPE: {capitao.Equipe} | COR DO TEXTO: {capitao.CorText}");
        }
        public void CadastrarEquipe(){
            try{
                System.Console.WriteLine("Qual equipe você pertence?");
                capitaoC.Equipe = Console.ReadLine();
            }catch(Exception e){
            System.Console.WriteLine("Erro no sistema! " + e);
            }
            Console.Clear();

        }
        
        public void CadastrarEscudo(){
            try{
                System.Console.WriteLine("Qual é o tipo do seu escudo?");
                capitao.Escudo = Console.ReadLine();
            }catch(Exception e){
            System.Console.WriteLine("Erro no sistema! " + e);
            }
            Console.Clear();

        }
    
    
        public void CadastrarArmadura(){
            try{
                System.Console.WriteLine("Qual é o tipo da sua armadura?");
                ferro.Armadura = Console.ReadLine();
            }catch(Exception e){
            System.Console.WriteLine("Erro no sistema! "+ e);
            }
            Console.Clear();        
        }

        public string Pular(){
        string resp = "Uhuull, pulando";
        return resp;
        }    
        public void Menu(){
         string menu = " ";
            while(menu != "3"){
            Console.WriteLine("Com quem você quer jogar? \n (1) - HOMEM DE FERRO \n (2) - CAPITÃO AMÉRICA \n (3) - SAIR");
            menu = Console.ReadLine();
         Console.Clear();

            switch(menu){
                case "1":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I AM IRON MAN!");
                    CadastrarEquipe();
                    CadastrarArmadura();
                    string jogar = "";
                    while(jogar!="0"){
                    Console.WriteLine("Vamos Jogar!\nEscolha sua Jogada:\n# 1 - PULAR\n# 2 - VOAR\n# 3 - ATIRAR\n# 4 EXIBIR DADOS \n# 5 - SAIR ");
                    jogar = Console.ReadLine();

                     switch(jogar){
                        case "1":
                             Console.WriteLine(Pular());          
                            break;
                            case "2":
                             Console.WriteLine(" ");          
                                Console.WriteLine(ferroC.Voar());      
                            break;
                            case "3":
                             Console.WriteLine(" ");          
                                Console.WriteLine(ferroC.Atirar());      
                            break;
                            case "4":
                                ExibirDadosF();
                            break;
                            case "5":
                                jogar = "0";
                            break;
                            default:
                               Console.Clear();
                                jogar = "";
                                Console.WriteLine("Entrada inválida.");
                            break;
            
                        }
                    }    

                break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("EU ENTENDI A REFERÊNCIA!");
                    CadastrarEquipe();
                    CadastrarEscudo();
                    
                    string jogarC = "";
                    while(jogarC != "0"){
                    Console.WriteLine("Vamos Jogar!\nEscolha sua Jogada:\n# 1 - PULAR\n# 2 - LANÇAR ESCUDO\n# 3 - DEFENDER\n# 4 - EXIBIR DADOS \n# 5 - SAIR ");

                    jogarC = Console.ReadLine();
                    switch(jogarC){
                            case "1":
                                Console.WriteLine(Pular());          
                            break;
                            case "2":
                                Console.WriteLine(capitaoC.LancaEscudo());      
                            break;
                            case "3":
                                Console.WriteLine(capitaoC.Defender());      
                            break;
                            case "4":
                                ExibirDadosC();
                            break;
                            case "5":
                                jogarC = "0";
                            break;
                            default:
                                jogarC = "";
                                Console.WriteLine("Entrada inválida.");
                            break;
                        }
                    }
                break;

                case "3":
                    menu = "3";
                break;

                default:
                    menu = "";
                    Console.WriteLine("Opção Inválida!");
                break;
            }
                    Console.ForegroundColor = ConsoleColor.Gray;
            }

            
        }
    }
}