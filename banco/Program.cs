namespace banco;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Banco etec MCM");
        Conta c = new Conta();
        // c.Saldo = 1500;
        c.depositar(1500);
        //c.Limite = 500;
        c.AjustarLimite(500);

        

        

       // Console.WriteLine("Seu saldo é de: " + c.Saldo + ", e seu limite é de: " + c.Limite);
        Console.WriteLine("Seu saldo é de: " + c.MostrarSaldo());
}

}
