namespace Circuferencia
{
    internal class Circuferencia
    {
        private readonly double pi = 3.14;
        public double CalculaAreaCircuferencia(double raio)
        {
            return (double)pi * Math.Pow(raio, 2);
        }
        static void Main(string[] args)
        {
            Circuferencia Circuferencia = new Circuferencia();

            Console.WriteLine("Vamos calcular área de uma circuferência!");
            Console.WriteLine("Informe o RAIO desta circuferência");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Circuferencia.CalculaAreaCircuferencia((double)raio));

        }
    }
}
