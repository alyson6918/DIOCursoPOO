namespace DIOExemploPOO.models
{
    public class Teatcher : Pessoa
    {
        public double Wage { get; set; }

        public override void introduce(){
            Console.WriteLine($"Olá, meu nome é {Name} e tenho {Age} anos. Sou um professor, ganho {Wage}.\n_______________\n");
        }
    }
}