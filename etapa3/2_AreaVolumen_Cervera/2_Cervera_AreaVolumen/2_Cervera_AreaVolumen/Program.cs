using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());
        Console.WriteLine("Área del círculo: " + CalcularAreaCirculo(radio));

        Console.Write("Ingresa la altura del cilindro: ");
        double altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Volumen del cilindro: " + CalcularVolumenCilindro(radio, altura));

        Console.ReadKey();
    }

    static double CalcularAreaCirculo(double radio)
    {
        return 3.1416 * radio * radio;
    }

    static double CalcularVolumenCilindro(double radio, double altura)
    {
        double areaBase = CalcularAreaCirculo(radio);
        return areaBase * altura;
    }
}