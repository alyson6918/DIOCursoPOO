namespace DIOExemploPOO.models
{
    public class Retangulo
    {
        private double rlenght;
        private double rwidth;
        private bool valid;
        public void DefineMeasures(double rlenght, double rwidth){
            if ((rlenght > 0) && (rwidth > 0)){
                this.rlenght=rlenght;
                this.rwidth=rwidth;
                valid = true;
            }
            else {
                System.Console.WriteLine("Os valores são invalidos para um retangulo");
            }
        }
        public double obtainWidth(){
            return this.rwidth;
        }
        public double odtainLenght(){
            return this.rlenght;
        }
        public double ObtainArea(){
            if (valid == true)
                return rlenght * rwidth;
            else
                System.Console.WriteLine("Preencha com valores validos");
                return 0;
        }
    }
}