using System;

namespace Estudinhos.ClassesBasicas
{
    public class Aluno
    {
        public int Nota { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public DateTime Nasc { get; set; }

        public Aluno(int nota, string nome)
        {
            Nota = nota;
            Nome = nome.ToUpper();
        }

        public Aluno(string nome, DateTime nascimento)
        {
            Nome = nome.ToUpper();
            Nasc = nascimento;
        }

        public void Adiciona(DateTime nascimento)
        {
            Nasc = nascimento;
        }

        public void Adiciona(int nota)
        {
            Nota = nota;
        }

        public override string ToString()
        {
            return $"{Nome}; {Nota}";
        }
    }
}
