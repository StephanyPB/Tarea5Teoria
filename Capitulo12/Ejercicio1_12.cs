using System;

public class Ejercicio1_12
{

    public Ejercicio1_12()
    {
        init_Class();
    }

    public void init_Class()
    {
        int numero, factorial  = 0;

        Console.Write("Ingrese el numero para factorial: ");
        numero = Convert.ToInt32(Console.ReadLine());

        CalcFactorial(numero, 
             ref factorial);

        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    public void CalcFactorial(int numero, ref int producto)
    {
        producto = 1;

        for (int i = numero; i >= 1; i--)
        {
            producto *= i;
        }
    }
}
