using System;
public class Averages
{
    public static void Main(string[] args)
    {
        double num1, num2, num3;
        Console.WriteLine("Enter an integer: ");
        double.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Enter another integer: ");
        double.TryParse(Console.ReadLine(), out num2);
        Console.WriteLine("Enter another integer: ");
        double.TryParse(Console.ReadLine(), out num3);


        Average(num1, num2, num3);

        Console.ReadKey();
    }

    public static void Average(params double[] nums)
    {


        double sum = 0;

        foreach (double num in nums)
        {
            sum += num;
            Console.Write(num + " ");
        }

        double average = 0;
        average = sum / nums.Length;

        Console.WriteLine(" -- Average is {0}", average);

    }
}
