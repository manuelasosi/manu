using System;
class oi
{
    static void Main(string[] args)
    {
        Console.Write(" Digite um numero:");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite outro numero:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num + num2;
        Console.WriteLine($" A soma dos numeros é {result}");

        if (num2 > num)
        {
            Console.WriteLine($"O numero {num2} é maior");
        }

        Console.ReadKey();
    }
}
