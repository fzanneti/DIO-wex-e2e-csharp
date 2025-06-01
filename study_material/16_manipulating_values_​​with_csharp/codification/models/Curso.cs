using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codification.Models // Namespace para agrupar as classes relacionadas a cursos
{
    public class Curso
    {
        public string NomeCurso { get; set; } // Propriedade para armazenar o nome do curso
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
            Console.WriteLine($"Alunos do curso de: {NomeCurso}"); // Exibe o nome do curso - Interpolação de strings é utilizada para formatar a mensagem com o nome do curso.

            for (int contador = 0; contador < Alunos.Count; contador++) // Percorre a lista de alunos
            {
                /*
                string texto = "Nº " + contador + " - " + Alunos[contador].NomeCompleto;
                Exemplo acima mostra a con
                */

                string texto = $"Nº {contador + 1} - {Alunos[contador].NomeCompleto}"; // Cria uma string formatada com o número do aluno e o nome completo do aluno atual
                /* 
                Utiliza interpolação de strings para formatar o texto com o número do aluno e o nome completo.
                Toda interpolação inicia com o sinal de cifrão ($) e as variáveis são colocadas entre chaves ({}) dentro da string.
                */

                /* 
                    Cria uma string com o número do aluno e o nome completo - o sinal + é utilizado para concatenar strings - tudo que começa e termina com aspas é considerado uma string.
                */
                Console.WriteLine(texto); // Exibe o texto formatado com o número do aluno e o nome completo
            }
        }
        
    }
}