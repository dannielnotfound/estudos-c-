using System;

namespace Retangulo
{
  class Retangulo
  {
    static void calculaArea()
    {   
        Console.WriteLine("Vamos calcular a área do seu retangulo!");
        Console.WriteLine("Informe o lado A: ");
        int a = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine("Informe o lado B: ");
        int b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("A área deste retângulo é: " +  a*b);
    }   

    static void Main(string[] args)
    {  
        calculaArea();
    }
  }
}