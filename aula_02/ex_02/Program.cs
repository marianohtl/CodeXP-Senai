using System;

namespace aula_02_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa, resultado, final;

            
        Console.WriteLine("Digite a placa do seu carro: ");
        placa = Console.ReadLine();
        
        //contamos a quantidade de caracteres de um elemento
        int caracteres = placa.Length;

        // Console.WriteLine("Digite os números finais da placa do seu carro: ");
        // placa = Console.ReadLine();
        //pegando o último dígito 
        // com o método substring
        final = placa.Substring(caracteres - 1);

        if(final == "1" || final == "2"){
            resultado = "Seu rodízio é na Segunda-Feira.";
        }else if(final == "3" || final == "4"){
            resultado = "Seu rodízio é na Terça-Feira.";
        }else if(final == "5" || final == "6"){
            resultado = "Seu rodízio é na Quarta-Feira.";
        }else if(final == "7" || final == "8"){
            resultado = "Seu rodízio é na Quinta-Feira.";
        }else if(final == "9" || final == "0"){
            resultado = "Seu rodízio é na Sextat-Feira.";
        } else{
            resultado = "Placa inválida.";
        }
        Console.WriteLine(resultado);
      
      switch(final){
          case "1":
          resultado = "Switch - Segunda-Feira";
          break;
          case "2":
          resultado = "Switch - Segunda-Feira";
          break;
          case "3":
          resultado = "Switch - Terça-Feira";
          break;
          case "4":
          resultado = "Switch - Terça-Feira";
          break;
          case "5":
          resultado = "Switch - Quarta-Feira";
          break;
          case "6":
          resultado = "Switch - Quarta-Feira";
          break;
          case "7":
          resultado = "Switch - Quinta-Feira";
          break;
          case "8":
          resultado = "Switch - Quinta-Feira";
          break;
          case "9":
          resultado = "Switch - Sexta-Feira";
          break;
          case "0":
          resultado = "Switch - Sexta-Feira";
          break;
          default:
            resultado = "Placa inválida.";
          break;      
      }
        Console.WriteLine(resultado);

        }
    }
}
