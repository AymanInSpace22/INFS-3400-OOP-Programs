using static System.Console;
public class SalesLetter
{
   public static void Main()
    {
      // Write your main here.
      WriteLine("From");
      DisplayContactInfo();
      WriteLine("______________________________\n");
      WriteLine("Dear Client,");
      WriteLine("We want to provide you good service. \nFeel free to contact us at any time.");
      DisplayContactInfo();
     
      WriteLine("   *********\n");
      WriteLine("Looking forward to a long relationship.");
      DisplayContactInfo();

    }
   public static void DisplayContactInfo()
    {
     // Write your DisplayContactInfo()
     WriteLine("C# Company");
     WriteLine("Phone: 555-1234   Cell: 555-0912");
     WriteLine("Email: csharpcompany@csharp.com");
     WriteLine("On the web at www.csharpcompanyforyou.com");

    }
}
