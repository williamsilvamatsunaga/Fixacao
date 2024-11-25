using System.Xml;

public class Program
{
    static void Main(string[] args)
    {
        AlunosFunc aFunc = new AlunosFunc();

        do
        {
            

            int opcao = 0;
            Console.Write("1 p/ ADD A LISTA 2 p/ add LISTAR");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Aluno a = new Aluno();

                Console.Write("Nome:");
                a.nome = Console.ReadLine();

                Console.Write("Idade: ");
                a.idade = Console.ReadLine();

                Console.Write("Série: ");
                a.serie = Console.ReadLine();

                aFunc.AdicionarAlunos(a);
            }

            if (opcao == 2)
            {
                aFunc.Listar();
            }

        } while (true);     
    }
}



