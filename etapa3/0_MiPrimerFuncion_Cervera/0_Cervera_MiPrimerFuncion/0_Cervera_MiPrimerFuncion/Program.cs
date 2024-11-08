using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número decimal: ");
        int numeroDecimal = int.Parse(Console.ReadLine());
        Console.WriteLine("En binario: " + ConvertirDecimalABinario(numeroDecimal));

        Console.Write("Ingresa un número binario: ");
        string numeroBinario = Console.ReadLine();
        Console.WriteLine("En decimal: " + ConvertirBinarioADecimal(numeroBinario));
        Console.ReadKey();
    }

    static string ConvertirDecimalABinario(int numero)
    {
        string binario = "";
        while (numero > 0)
        {
            int resto = numero % 2;
            binario = resto + binario;
            numero = numero / 2;
        }
        return binario == "" ? "0" : binario;
    }

    static int ConvertirBinarioADecimal(string binario)
    {
        int numeroDecimal = 0;
        int posicion = 0;

        for (int i = binario.Length - 1; i >= 0; i--)
        {
            if (binario[i] == '1')
            {
                int valorPosicion = 1;
                for (int j = 0; j < posicion; j++)
                {
                    valorPosicion *= 2;
                }
                numeroDecimal += valorPosicion;
            }
            posicion++;
        }
        return numeroDecimal;

    }

}

