using System;

namespace aula_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BomDia("Bom"));
            //>>>>>>>>>>>  chamando a função do tipo void que é sem retorno :3
            ImprimirDataHora();

            //chamando nossa função que calcula a média
            
            double[] numeros = {2,5,3};
            Console.WriteLine(CalculaMedia(numeros));
            Console.WriteLine($" A soma dos valores é  {SomaValores(numeros)}");
        }

    /// <summary>
    /// Retorna um número - Teste de Sobrecarga
    /// </summary>
    /// <param name="numero"> Um número inteiro qualquer</param>
    /// <returns>Número passado com parâmetro</returns>
         static int BomDia(int numero){
            return numero;
        }
        //As funções são declaradas dentro das classes
        /// <summary>
        /// Função que escreve bom dia para o usuário.
        /// </summary>
        /// <returns>Retorna: Bom dia. :3</returns>
        static string BomDia(){
            return "Bom dia. :3";
        }
        /// <summary>
        /// Função que retorna uma sasudação de acordo com o horário atual
        /// </summary>
        /// <param name="saudacao">Um texto qualquer (sobrecarga de método).</param>
        /// <returns>Saudação de acordo com o horário.</returns>
        static string BomDia(string saudacao){
           int hora = DateTime.Now.Hour;
            if( hora <= 12){
                saudacao = "Bom dia! :)";
            }else if(hora > 12 && hora <=18){
                saudacao = "Boa tarde :)";
            }else{
                saudacao = "Boa noite :)";
            }

            return saudacao;
        }

        /// <summary>  
        /// retorna data e hora atual
        /// </summary>
        static void ImprimirDataHora(){
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.Hour);
        }
/// <summary>
/// Função que calcula a média de um vetor
/// </summary>
/// <param name="valores">vetor com valores</param>
/// <returns>A media dos valores</returns>
        static double CalculaMedia(double[] valores){
            double resultado=0;
            
            for(int i = 0; i < valores.Length; i++){
                resultado = resultado + valores[i];
            }
            resultado = resultado / valores.Length;
            return resultado;
        }

/// <summary>
/// <summary>
/// Função que somar os valores de um vetor
/// </summary>
/// <param name="valores">vetor com valores</param>
/// <returns>A soma dos valores</returns>
        static double SomaValores(double[] parametros){
                    double resultado = 0;
                    for(int i = 0; i < parametros.Length; i++){
                        resultado = resultado + parametros[i];
                    }
                    return resultado;
        }

    }
}
