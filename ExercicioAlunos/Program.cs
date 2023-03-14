namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {

        Alunos aluno1 = new Alunos();
        Console.WriteLine("Digite o nome do aluno: ");
        aluno1.nome = Console.ReadLine(); 


        Console.WriteLine("Digite a 1° nota: ");
        aluno1.nota1 = double.Parse(Console.ReadLine());

       
        Console.WriteLine("Digite a 2° Nota: ");
        aluno1.nota2 = double.Parse(Console.ReadLine());
        

        aluno1.mensagem();

    }

}
