namespace Conversor
{
    internal class Conversor
    {
        private double celsius;
        public double ConverteFahrenheitToCelsius(double fahrenheit)
        {
            this.celsius = (fahrenheit - 32);
            this.celsius = this.celsius * 5 / 9;
            return Math.Round((double)this.celsius);
        }
        static void Main(string[] args)
        {   
            Conversor Conversor = new Conversor();

            Console.WriteLine("Converta Fahrenheit em Celsius!");
            Console.WriteLine("Insira a temperatura em Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{fahrenheit}º Fahrenheit é o mesmo que " + Conversor.ConverteFahrenheitToCelsius(fahrenheit) + "º C");
        }
    }
}
