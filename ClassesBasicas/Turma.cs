using System;
using System.Collections.Generic;

namespace Estudinhos.ClassesBasicas
{
    public class Turma
    {
        public string Nome { get; set; }
        public List<Aluno> Alunos { get; set; }
        public Turma(string nome)
        {
            Nome = nome;
            Alunos = new List<Aluno>();
        }

        public void AddAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public int MaiorNota()
        {
            int maiorNota = 0;
            foreach (var aluno in Alunos)
            {
                if (aluno.Nota > maiorNota)
                {
                    maiorNota = aluno.Nota;
                }
            }
            return maiorNota;
        }

        public int MenorNota()
        {
            int menorNota = 10;
            foreach (var aluno in Alunos)
            {
                if (aluno.Nota < menorNota)
                {
                    menorNota = aluno.Nota;
                }
            }
            return menorNota;
        }

        public int MediaNota()
        {
            int media = 0;

            foreach (var aluno in Alunos)
            {
                media += aluno.Nota;
            }

            return media / Alunos.Count;
        }

        public int MediaIdade()
        {
            int idades = 0;
            foreach (var aluno in Alunos)
            {
                idades += (DateTime.Now.Year - aluno.Nasc.Year);
            }
            return idades / Alunos.Count;
        }
        
    }
}