namespace Heranca_Polimorfismo;
class Animal
{
    public string? fala {get;set;}
    public virtual string som(string fala){
        return fala;
    }
}
