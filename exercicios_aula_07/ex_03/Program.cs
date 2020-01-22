using System;

namespace ex_03
{
    class Program
    {
        static void Main(string[] args)
        {   double[] arg = {1.1, 8.8, 3.3,10.5,5.5};
            Console.WriteLine(Maior(arg));
        }
        /// <summary>
        /// Função que recebe um vetor e verifica qual é o maior número dele.
        /// </summary>
        /// <param name="vetor">Um vetor ou uma sequência de argumentos do tipo double </param>
        /// <returns>Retorna um double com o valor maior dos argumentos passados/vetor</returns>
        static double Maior(double[] vetor){
        double retorno = 0;
        double maior = 0;

            for(int i = 0; i < vetor.Length; i++){  
                
                if(i == 0){
                    maior = vetor[i];                
                }

                if(maior < vetor[i]){
                    maior = vetor[i];                
                }
                retorno = maior;
            }


            return retorno;
        }
    }
}
