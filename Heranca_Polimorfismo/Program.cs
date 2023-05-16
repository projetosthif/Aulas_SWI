namespace Heranca_Polimorfismo;
class Program
{
    static void Main(string[] args)
    {
        Cachorro c = new Cachorro();
        c.fala = "Au au";
        Console.WriteLine("O cachorro faz" + c.som);
    }
}
