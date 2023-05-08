namespace ExercicioAvaliativo;
class Banco
{   
    public int Numero {get; set;}
    private double Saldo { get;  set;}
    public double Limite {get; private set;}

    public void AjusteLimite(double valor){
        this.Limite = valor;
    }
    public void Deposito( double valor){
        this.Saldo += valor;
    }
    public void Saque(double valor){
        if (this.Saldo + this.Limite < valor){
            Console.WriteLine("Você não tem saldo suficiente.");
        }else{
             this.Saldo -= valor;
        }
    }
    public double MostrarSaldo(){
        return this.Saldo + this.Limite;
    }

    public double parcela {get; set;}
    public double valor {get; set;}

    public string emprestimo(int parcelas, double dinheiro){
        this.parcela = parcelas;
        this.valor = dinheiro;
        
        double divi = dinheiro/parcelas;
        double multi = dinheiro * 0.06;
        double soma = multi + divi;
        double total = soma * parcelas;

        string resultado = "O valor da parcela sem juros é de: R$"+ divi +". O valor da parcela com juros é de: R$"+ multi + ". O juros com prestações é de: R$"+ soma + " O valor total a pagar é de: R$"+total;
        return resultado;
        
     
    }
    public void imprimir(string texto){
        Console.WriteLine(texto);
    }
}
