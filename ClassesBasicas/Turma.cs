using System.Collections.Generic;

namespace Estudinhos.ClassesBasicas
{
    public class Turma
    {
        //propriedades de Turma
        public string Nome { get; set; }
        public List<Aluno> Alunos { get; set; }

        //método construtor que obriga a atribuir um nome a turma para poder crir uma turma
        public Turma(string nome)
        {
            Nome = nome;

            //sempre que há uma lista devemos instancear ela no método construtor
            Alunos = new List<Aluno>();
        }


        //é uma boa prática criar um método para adicionar elementos a lista
        public void AddAluno(Aluno aluno)
        {
            //aqui pode ser atribuídas regras de negócio para adicionar alunos
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
    }
}