using Estudinhos.ClassesBasicas;
using System.Collections.Generic;

namespace Estudinhos.Relatorios
{
    public class Relatorio
    {
        //propriedades do relatorio
        public Turma Turma { get; set; }

        //método construtor que obriga passar uma turma para criar um relatório
        public Relatorio(Turma turma)
        {
            Turma = turma;
        }

        //método que constroi o relatório e gera uma lista de linhas
        public List<string> DadosTurma()
        {
            List<string> linhas = new List<string>();

            linhas.Add("Dados da turma: " + Turma.Nome);
            linhas.Add("Maior Nota: " + Turma.MaiorNota());
            linhas.Add("Menor Nota: " + Turma.MenorNota());
            linhas.Add("Media da turma: " + Turma.MediaNota());

            linhas.Add("");

            linhas.Add("Aluno; Nota");
            foreach (var aluno in Turma.Alunos)
            {
                linhas.Add(aluno.ToString());
            }

            return linhas;
        }
    }
}