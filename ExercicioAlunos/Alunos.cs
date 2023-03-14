namespace ExercicioAlunos;
class Alunos
{
    public string nome="";
    public double nota1, nota2;

    //MEDIA --> Retorna um double (por exemplo um número como 8.3)

    public double obterMedia(){
        double media = (nota1 + nota2)/2;
        return media;

    }

    //SITUACAO --> Retorna uma String ("Aprovado" ou "Reprovado")

    public string obterSituacao(double media){
      string situacao="";
      if(media>=6){
        situacao="aprovado";
         }else{
            situacao="reprovado";
         } 
         return situacao;
    }

    //MENSAGEM --> Não retorna nada, só mostra na tela os detalhes (nome, media e situação)

    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resultadoSituacao =  obterSituacao(mediaCalculada);
        Console.WriteLine("O aluno " + nome + " foi " + resultadoSituacao + " com média: " + mediaCalculada);
         }
    }


