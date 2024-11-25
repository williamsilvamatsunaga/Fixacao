using System;

public class AlunosFunc
{
    public List<Aluno> alunosList = new List<Aluno>();

    public void AdicionarAlunos(Aluno a)
    {
        alunosList.Add(a);
    }

    public void Listar()
    {
        foreach (var aluno in alunosList)
        {
            Console.WriteLine($"Nome: {aluno.nome}, idade: {aluno.nome}, {aluno.serie}");
        }
    }
}
