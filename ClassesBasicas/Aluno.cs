using System;

namespace Estudinhos.ClassesBasicas
{
    public class Aluno
    {
        //propriedades de aluno
        public int Nota { get; set; }
        public string Nome { get; set; }
        public string Nmatricula { get; set; }
        public DateTime Nasc { get; set; }

        //este método construtor obriga a atribuir um nome e uma nota para criar um aluno
        public Aluno(int nota, string nome)
        {
            Nota = nota;

            //atendendo a regra de negócio do nome ser maiúsculo
            Nome = nome.ToUpper();
        }

        //aqui estamos fazendo sobrescrita do método toString para atender a regra de negócio do CSV
        public override string ToString()
        {
            return $"{Nome}; {Nota}";
        }
    }
}
