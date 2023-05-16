namespace ex_2;
class Program
{
    static void Main(string[] args)
    {
        //Intânciando a classe
        Contrato c = new Contrato();
        PessoaFisica pf = new PessoaFisica();
        PessoaJuridica pj = new PessoaJuridica();


        c.Nome = "Fulano";
        c.Email = "Fulano@gmail.com";
        c.Telefone = "(11) 9999-9999";


        pj.NomeEmpresa = "ETEC MCM";
        pj.CNPJ = "00.000.000/0000-00";
        pj.IE = "123456789";

        pf.CPF = "000.000.000-25";
        pf.Idade = 48;


        Console.WriteLine();



    }
}
