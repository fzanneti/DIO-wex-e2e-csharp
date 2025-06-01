using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codification.Models // Namespace para agrupar as classes relacionadas a cursos
{
    public class Curso
    {
        public string Nome { get; set; } // Nome dos alunos do curso
        public List<Pessoa> Alunos { get; set; } // Lista de alunos do curso


        public void AdicionarAluno(Pessoa aluno) // Método para adicionar um aluno ao curso
        {
            Alunos.Add(aluno); // Adiciona o aluno à lista
        }

        public int ObterQuantidadeAlunos() // Método para obter a quantidade de alunos no curso
        {
            int quantidade = Alunos.Count; // Conta o número de alunos na lista
            return quantidade; // Retorna a quantidade de alunos
        }

        public bool RemoverAluno(Pessoa aluno)  // Método para remover um aluno
        {
            return Alunos.Remove(aluno); // Tenta remover o aluno da lista de alunos e retorna true se for bem-sucedido, caso contrário, retorna false
        }

        public void ListarAlunos() // Método para listar os alunos
        {
            Console.WriteLine($"Alunos do curso de: {Nome}"); // Exibe o nome do curso
            foreach (Pessoa aluno in Alunos) // Percorre cada aluno na lista de alunos
                {
                    Console.WriteLine(aluno.NomeCompleto); // Exibe o nome completo do aluno
                }
        }
        
    }
}