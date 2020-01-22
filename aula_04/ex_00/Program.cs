using System;

namespace aula_04 {
    class Program {
        static void Main (string[] args) {
            double[] media = new double[10];
            Console.WriteLine ("==============================");

            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Digite uma média: ");
                media[i] = double.Parse (Console.ReadLine ());
            }
            Console.WriteLine ("==============================");
            Console.WriteLine (media[3]);
            Console.WriteLine ("==============================");

            for (int ii = 0; ii <= media.Length - 1; ii++) {
                Console.Write (media[ii]);
            }

        }
    }
}