using System;
using ex_01.Model;

namespace ex_01.Controller
{
    public class AlunosController
    {
        AlunoModel aluno = new AlunoModel();
         public void CadastrarAluno(){
             
          try{
            Console.WriteLine("Digite seu nome:");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite seu curso:");
            aluno.Curso = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            aluno.Idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite seu RG:");
            aluno.Curso = Console.ReadLine();

            Console.WriteLine("Você é bolsista? S/N");
            string resp = Console.ReadLine().ToUpper();

            if(resp == "S"){
                aluno.Bolsista = true;
            }else{
                 aluno.Bolsista = false;
            }
            }catch(Exception ex){
              Console.WriteLine("Desculpe, houve uma falha no sistema :/  "+ex);
            }
        }


        public void EscreverInformacoes(){
            Console.WriteLine($"NOME: {aluno.Nome}");
            Console.WriteLine($"CURSO: {aluno.Curso}");
            Console.WriteLine($"IDADE: {aluno.Idade}");
            Console.WriteLine($"RG: {aluno.Rg}");
            Console.WriteLine($"BOLSISTA: {aluno.Bolsista}");
        }   
    }
}