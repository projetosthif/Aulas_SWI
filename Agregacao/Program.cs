namespace agregacao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Agregação");
        
        //instanciando os objetos de cada classe
        CartaoDeCredito cdc = new CartaoDeCredito();
        Cliente cli = new Cliente();

        //Adicionando um nome para um cliente
        cli.Nome = "Thifany Garcia";

        //Adicionando número e validade do Cartão de Crédito
        cdc.Numero = "123654789";
        cdc.DataDeValidade = "01/2024";

        //Associando o cliente ao atributo de agregação em Cartão de Credito
        cdc.Cliente = cli;

        //Visualizando as informações
        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade é: " + cdc.DataDeValidade);
        Console.WriteLine("O nome do cliente que foi agregado é: " + cdc.Cliente.Nome);

    }
}
