using System;

namespace ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float salario, total, novoSalario;
            Console.WriteLine("Digite o nome do funcionário: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionário: ");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas: ");
            total = float.Parse(Console.ReadLine());
            total = total * 0.1f;
            novoSalario = salario + total;
            Console.WriteLine($"Funcionário: {nome}");
            Console.WriteLine($"Salário: {salario}");
            Console.WriteLine($"Novo salário: {novoSalario}");

        }   
    }
}
