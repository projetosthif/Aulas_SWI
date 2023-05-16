namespace ex_1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desenvolvido por Thifany Garcia");

        Cachorro c = new Cachorro();
        Gato g = new Gato();
        Homem h = new Homem();

        Console.WriteLine("O cachorro emite o " + c.fala());
        Console.WriteLine("O cachorro emite o " + g.fala());
        Console.WriteLine("O cachorro emite o " + h.fala());

    }
}
