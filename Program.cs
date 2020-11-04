using Estudinhos.ClassesBasicas;
using Estudinhos.Relatorios;
using System;

namespace Estudinhos
{
    internal class Program
    {
        private static void Main(string[] _)
        {
            //recebendo o nome da turma do console 
            Console.WriteLine("diga a turma");
            var turmaRead = Console.ReadLine();

            //instanceando uma turma
            var turma = new Turma(turmaRead);

            //esta é uma das maneiras de manter uma continuidade em aplicação console
            //dessa forma poderemos ter n alunos até que o nome do aluno seja PARE 
            while (true)
            {
                //recebendo os dados dos alunos
                //isso precisa ser antes de criar o aluno para não dar problema de nulo 
                Console.WriteLine("Diga o nome");
                var nome = Console.ReadLine();

                if (nome == "PARE")
                {
                    //sai do while, para de criar alunos
                    break;
                }

                //recebe a nota para o aluno
                Console.WriteLine("diga a nota");
                //é necessário converter de string para inteiro por que tudo que vem do console é string
                var nota = int.Parse(Console.ReadLine());

                //Cria um aluno
                var aluno = new Aluno(nota, nome);

                //Adiciona um aluno a turma
                turma.AddAluno(aluno);
            }

            //instanceado o objeto relatório que recebe uma turma
            var relatorio = new Relatorio(turma);

            // imprime os dados da turma
            foreach (var linha in relatorio.DadosTurma())
            {
                Console.WriteLine(linha);
            }
           
        }
    }
}