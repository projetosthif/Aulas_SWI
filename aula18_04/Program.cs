namespace _18_04;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Banco Ariany Andrade");
        Banco b = new Banco();

        b.Depositar(1000);
        b.Sacar(1600);
        b.AjustarLimite(500);

        double valortotal = b.MostrarSaldo();

        Console.WriteLine("O seu saldo  é de " + valortotal);
        
        b.imprimi(b.emprestimo(12,1000));
    }
}
