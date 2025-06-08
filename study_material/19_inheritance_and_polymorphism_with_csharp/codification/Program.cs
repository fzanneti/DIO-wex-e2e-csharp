using codification.Models;
using System;

Aluno aluno = new Aluno();
aluno.Nome = "João";
aluno.Sobrenome = "Silva";
aluno.Idade = 20;
aluno.Curso = "Engenharia de Software";
aluno.Matricula = 123456;
aluno.Apresentar();
aluno.ApresentarAluno();

Professor professor = new Professor();
professor.Nome = "Pedro";
professor.Sobrenome = "Alencar";
professor.Idade = 56;
professor.Salario = 5500.00M;
professor.ApresentarProfessor();