using static System.Console;
using System.Globalization;
public class TestClassifiedAd
{
   public static void Main()
   {
    // Write your main here.
    ClassifiedAd ad1 = new ClassifiedAd();
    ad1.Category = "Used Cars";
    ad1.Words = 100;

    ClassifiedAd ad2 = new ClassifiedAd();
    ad2.Category = "Help Wanted";
    ad2.Words = 60;

    WriteLine("The classified ad with {0} words in category {1} costs {2}", ad1.Words, ad1.Category, ad1.price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    WriteLine("The classified ad with {0} words in category {1} costs {2}", ad2.Words, ad2.Category, ad2.price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
   }
}
 class ClassifiedAd
{
    // Write your ClassifiedAd class here.
    public string Category {get; set;}
    public int Words {get; set;}

    public double price
    {
      get{return Words * .09;}
    }
}
