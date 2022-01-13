namespace DIOExemploPOO.models
{
    public class Pessoa
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public int Cpf { get; set; }
        public virtual void introduce(){
            Console.WriteLine($"Olá, meu nome é {Name} e tenho {Age} anos.\n_______________\n");
        }
    }
}