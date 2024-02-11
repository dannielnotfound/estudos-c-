using System;

namespace Triangulo
{
    class CaculaAreaTriangulo
    {   
        
        public double calculaArea(double a, double b)
        {
            return (a * b) / 2;
        }

        static void Main(string[] args) 
        {
            CaculaAreaTriangulo Program = new CaculaAreaTriangulo();
            double result = Program.calculaArea(5.5, 10.5);
            Console.WriteLine(result);
        }
    }
}