namespace DIOExemploPOO.models
{
    public class CheckingAccount : Account
    {
        public override void creditar(double n1)
        {
            base.saldo = n1;
        }
    }
}