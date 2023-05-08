namespace ExercicioAvaliativo;
class Program
{
    static void Main(string[]args)
    {
        Banco b = new Banco();

        b.Deposito(1000);
        b.Saque(1600);
        b.AjusteLimite(500);

        double valortotal = b.MostrarSaldo();

        Console.WriteLine("O seu saldo  é de " + valortotal);
        
        b.imprimir(b.emprestimo(12,1000));
    }
}
