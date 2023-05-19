namespace ex_2;
class Program
{
    static void Main(string[] args)
    {
        //Intânciando a classe
        Contrato c = new Contrato();
        PessoaFisica pf = new PessoaFisica();
        PessoaJuridica pj = new PessoaJuridica();



        Console.WriteLine("Contrato Pesso Física");
        Console.WriteLine("Digite o seu nome: ");
        pf.Nome = Console.ReadLine();
        Console.WriteLine("Digite o seu telefone: ");
        pf.Telefone = Console.ReadLine();
        Console.WriteLine("Digite o seu email: ");
        pf.Email = Console.ReadLine();

        pf.CPF = "000.000.000-25";
        pf.Idade = 48;



        Console.WriteLine("Contrato Pesso Jurídica");
        Console.WriteLine("Digite o seu nome: ");
        pj.Nome = Console.ReadLine();
        Console.WriteLine("Digite o seu telefone: ");
        pj.Telefone = Console.ReadLine();
        Console.WriteLine("Digite o seu email: ");
        pj.Email = Console.ReadLine();

        pj.NomeEmpresa = "ETEC MCM";
        pj.CNPJ = "00.000.000/0000-00";
        pj.IE = "123456789";


        Console.WriteLine("Os dados da Pessoa Física são: ");
        Console.WriteLine(pf.MostraDados());

        Console.WriteLine("Os dados da Pessoa Jurídica são: ");
        Console.WriteLine(pj.MostraDados());

        


    }
}
