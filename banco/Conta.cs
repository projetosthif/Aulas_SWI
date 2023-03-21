namespace banco;
class Conta
{
    public int Numero {get; set;}
    private double Saldo {get; set;}
    public double Limite {get; set;}

    public void depositar (double valor){
        this.Saldo += valor;
    }

     public void sacar (double valor){
        if (valor> this.Saldo + this.Limite){
            Console.WriteLine("Você não pode fazer este saque");
        }else{
            this.Saldo -= valor;
        }
        this.Saldo = valor;
    }
    public double MostrarSaldo(){
        return this.Saldo + this.Limite;
    }

    public void AjustarLimite(double valor){
        this.Limite = valor;
    }

    
}
