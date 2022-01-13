namespace DIOExemploPOO.models
{
    public abstract class Account
    {
        protected double saldo;

        public abstract void creditar(double n1);

        public void balance(){
            System.Console.WriteLine($"Seu saldo é: {saldo}");
        }
    }
}