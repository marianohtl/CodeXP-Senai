using System;

namespace ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int cont = 1;
            int soma = 0;
            int f=1;
            string fatorial ="";
            int calc;

            do{
                Console.WriteLine("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                if(num > 0){
                    cont++;
                    if(num%2 != 0){
                        soma = num + soma;
                    }
                    if(num%3 == 0 ){
                        int cont2 = 1;
                        f=1;
                        while(cont2 <= num){
                            calc = cont2;
                            f = f * calc;
                            cont2++;
                        Console.WriteLine(calc + " - "+ f);
                        }
                        fatorial += f.ToString() + " ";
                    }
                }
            }while(cont <=5);
            if(fatorial == ""){
                fatorial = "0";
            }
                        Console.WriteLine($"A sequências dos fatoriais dos múltiplos de 3 digitados são: {fatorial}.");
                        Console.WriteLine($"A soma dos números ímpares é {soma}.");
 
        }
    }
}
