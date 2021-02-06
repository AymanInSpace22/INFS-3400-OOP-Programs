using System;
using static System.Console;
using System.Globalization;
public class FineForOverdueBooks
{
   public static void Main()
   {
    // Write your main here.
    Write("Enter number of books checked out >> ");
    int books = int.Parse(ReadLine());

    Write("Enter the number of days overdue >> ");
    int days = int.Parse(ReadLine());

    DisplayFine(books, days);

   }
   public static void DisplayFine(int books, int days)
   {
    // Write your DisplayFine method here.
    const double FINES = .10;
    const double MORE_FINES = .20;
    const int FIRST_WEEK = 7;
    double fines;

    if (days <= 7)
    {
      fines = books * days * FINES;
    }

    else
    {
      fines = ((books * FINES * FIRST_WEEK) + (books * MORE_FINES * (days - FIRST_WEEK)));
    }
    
      WriteLine("The fine for {0} book(s) for {1} day(s) is {2}", books, days, fines.ToString("C", CultureInfo.GetCultureInfo("en-US")));

   }
}
