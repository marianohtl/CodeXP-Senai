using System;

namespace ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
           double[] arg = {10.5,10.5,10.5,10.5};
           Console.WriteLine(Soma(arg));
        }
        /// <summary>
        /// Função que recebe um vetor ou uma quantidade de valores do tipo double e retorna a somada dos valores
        /// </summary>
        /// <param name="vetor">vetores do tipo double</param>
        /// <returns>a soma do vetor</returns>
          static double Soma(double[] vetor){
        double retorno = 0;

            for(int i = 0; i < vetor.Length; i++){  
                retorno = retorno + vetor[i];
            }


            return retorno;
        }
    }
}
