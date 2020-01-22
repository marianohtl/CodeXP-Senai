using System;

namespace ex_00
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = 0;
            double porcentagem = 0;
            try{
            Console.WriteLine("Escreva o preço: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o percentual de %: ");
            porcentagem = double.Parse(Console.ReadLine().Replace("%",""));
            Console.WriteLine("O valor do preço com desconto é R$"+calculoPorcentagem(preco,porcentagem));
            }catch(Exception){
                Console.WriteLine("Os dados devem ser numéricos.");
            }
        }

        /// <summary>
        ///     Função que recebe um valor e uma porcentagem de desconto e retorna a subtração do valor com a porcentagem de desconto.
        /// </summary>
        /// <param name="valor">double</param>
        /// <param name="porcentagem">double</param>
        /// <returns>retorna o preço com o desconto, usando uma porcentagem determinada pelo usuário</returns>
        static double calculoPorcentagem(double valor,double porcentagem){
            double resultado=0;
                resultado = valor * (porcentagem/100);
                resultado = valor - resultado;
                return resultado;
            
        }
    }
}
