using System;
using static System.Console;
using System.Globalization;
class PaintingEstimate
{
    static void Main()
    {
        // Write your main here.
      Write("Enter length of the room in feet >> ");
      double length = double.Parse(ReadLine());
      Write("Enter width of room in feet >> ");
      double width = double.Parse(ReadLine());
      double endCost = ComputeCost(length, width);

      WriteLine("Cost of job for {0} X {1} foor room is {2}", length, width, endCost.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }

    public static double ComputeCost(double length, double width)     
    {
        // Write your ComputeCost method here.
        double totalCost = ((2 * 9 * length) + (2 * 9 * width)) * 6;
        return totalCost;
    }
}
