namespace Cubo
{
    internal class Cubo
    {   
        public double CalculaVolumeCubo(double a)
        {
            return a * a * a;
        }

        static void Main(string[] args)
        {
            Cubo Cubo = new Cubo();
            Console.WriteLine("Vamos calcular o volume de um cubo!");

            Console.WriteLine("Insira o valor do lado do Cubo!");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O volume deste cubo é " + Cubo.CalculaVolumeCubo(a));

        }
    }
}
