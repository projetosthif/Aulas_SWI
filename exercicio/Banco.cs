namespace exercicio;
class Banco
{ 
 public int num1 {get;set;}  
 public int num2 {get;set;}  

  public string dividir (int n1, int n2){
    this.num1 = n1;
    this.num2 = n2;
    int dividir = this.num1/this.num2;
    string resultado1 = "O valor emprestado de R$"+this.num1+ " com o prazo de " + this.num2+" meses é de: R$" + dividir + " sem juros"; 

    return resultado1;
}

//public string taxa (int n1, int n2){
    //this.num1 = n1;
    //this.num2 = n2;
    //int taxa = this.num1 * this.num2;
    //string resultadotaxa = "O valor de R$"+this.num1+ "com a taxa será de: " + taxa;

    //return resultadotaxa;
}


   //public void imprime(string texto){
    //Console.WriteLine(texto);
   //}

//}
