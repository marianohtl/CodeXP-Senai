using System;

namespace exercicios_aula_05 {
    class Program {
        static void Main (string[] args) {
            int[] valor = new int[10];
            int mult = 0;

            for (int i = 0; i < 10; i++) {
                Console.WriteLine ("Digite um valor: ");
                valor[i] = int.Parse (Console.ReadLine ());
            }
            for (int i = 0; i < 10; i++) {
                Console.Write(valor[i] + " ");
            }
            mult = valor[9];
            mult = mult *5;
            Console.WriteLine("  ");
            Console.WriteLine(mult);
        }
    }
}