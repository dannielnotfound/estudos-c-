namespace Bhaskara
{
    internal class Bhaskara
    {
        private double a;
        private double b;
        private double c;
        private double delta;

        public double calculaDelta(double delta)
        {

        }
        static void Main(string[] args)
        {   
            Bhaskara Bhaskara = new Bhaskara();


            // ax² + bx + c = 0

            Console.WriteLine("Vamos encontrar as raízes da sua equação!");

            Console.WriteLine("Insira o valor de A: ")
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor de B: ")
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor de C: ")
            double c = Convert.ToDouble(Console.ReadLine());
        }
    }
}
