using Estudinhos.ClassesBasicas;
using Estudinhos.Relatorios;
using System;

namespace Estudinhos
{
    internal class Program
    {
        private static void Main(string[] _)
        {
            Console.WriteLine("diga a turma");
            var turmaRead = Console.ReadLine();

            var turma = new Turma(turmaRead);

            while (true)
            {
                Console.WriteLine("Diga o nome");
                var nome = Console.ReadLine();

                if (nome == "PARE")
                {
                    break;
                }

                Console.WriteLine("diga a nota");
                var nota = int.Parse(Console.ReadLine());

                var aluno = new Aluno(nota, nome);

                turma.AddAluno(aluno);
            }

            var relatorio = new Relatorio(turma);

            foreach (var linha in relatorio.DadosTurma())
            {
                Console.WriteLine(linha);
            }
           
        }
    }
}