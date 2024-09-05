﻿namespace PropriedadesMetodosConstrutores.Models;

public class Curso
{
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    public void AdicionarAluno(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }

    public int ObterQuantidadeDeAlunosMatriculados()
    {
        return Alunos.Count;
        
    }

    public bool RemoverAluno(Pessoa aluno)
    {
        return Alunos.Remove(aluno);
      
    }

    public void ListarAlunos()
    {
        Console.WriteLine($"Alunos do Curso de Inglês: {Nome}");
        Console.WriteLine($"---------------------------------");
        foreach (Pessoa aluno in Alunos)
        {
            Console.WriteLine(aluno.NomeCompleto);
        }
    }
}