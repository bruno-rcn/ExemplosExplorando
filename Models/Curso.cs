using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; } // quando vc tem uma propriedade que tem como tipo uma lista, vc precisa instanciar essa lista

        public void AdicionarAluno(Pessoa n1)
        {
            Alunos.Add(n1);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count();
            return quantidade;
        }

        public bool RemoverAlunos(Pessoa n1)
        {
            return Alunos.Remove(n1);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine("Nome: " + aluno.NomeCompleto + ", idade: " + aluno.Idade + ";");
            // }

            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = "N. " + (count + 1) + " " + Alunos[count].NomeCompleto; // quando usa o sinal de + para concatenar string. Tudo aqui sera transformado para string internamente
                Console.WriteLine(texto);
            }
        }


    }
}