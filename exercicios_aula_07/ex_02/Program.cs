using System;

namespace ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
      
           Console.WriteLine(MostraInfo());
           Console.WriteLine(MostraInfo("Thalita","Mariano"));
           Console.WriteLine(MostraInfo(1.1,2.2,3.3));
     
        }

        /// <summary>
        /// Função sem argumento
        /// </summary>
        /// <returns>retorna uma string com a razão social do Senai</returns>
         static string MostraInfo(){
            return "SERVICO NACIONAL DE APRENDIZAGEM INDUSTRIAL - SENAI";
        }

        /// <summary>
        /// Função que recebe dois argumentos do tipo string e retorna o nnome e o sobrenome
        /// </summary>
        /// <param name="nome">string</param>
        /// <param name="sobrenome">string</param>
        /// <returns>retorna o nome completo</returns>
        static string MostraInfo(string nome,string sobrenome){
            return $"{nome} {sobrenome}";
        }

        /// <summary>
        ///     Função que recebe, peso, altura e idade e retorna um textinho com estes dados, de uma forma lindamente organizada
        /// </summary>
        /// <param name="idade">double</param>
        /// <param name="peso">double</param>
        /// <param name="altura">double</param>
        /// <returns>retorna uma string com o peso, idade e altura, recebido por argumento</returns>
        static string MostraInfo(double idade,double peso,double altura){
            return "Idade: "+ idade.ToString()+ "\nPeso:"+ idade.ToString() + "\nAltura:"+ altura.ToString();;
        }
    }
    }

