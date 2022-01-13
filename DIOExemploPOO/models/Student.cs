namespace DIOExemploPOO.models
{
    public class Student : Pessoa
    {
        public int Note { get; set; }

        public override void introduce(){
            Console.WriteLine($"Olá, meu nome é {Name}, tenho {Age} anos e sou um aluno nota {Note}.\n_______________\n");
        }
    }
}