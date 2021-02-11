using System;
class HelloWorld
{
    //This shit makes it so simple!
    //The oject structure allows you to pass in int, string, schar, double, etc. 
    //All in the same array
    
  static void Main()
  {
    object[] attributes = {"Mike Hunt", 69, 'D'};
    double[] GPAs = {2.9, 4.0, 2.6, 3.4, 3.6, 4.0};
    object[] Gpas = {3.3, 4.0, 2.6};
    
  
    Display(attributes);
    Display("This dick");
    Display(1, 2, 3, 4.5, 5.2);
    Display(GPAs);
    DisplayDecimals(Gpas);
    
  }
  
  private static void Display(params object[] things)
  {
      foreach(object obj in things)
        Console.Write("{0}, ", obj);
        Console.WriteLine("\n----------------");
  }
  
  //Creating another method for the Format decimal for the Gpas array
  public static void DisplayDecimals(params object[] doubles)
  {
      foreach(object obj in doubles)
        Console.Write("{0:F1}, ", obj);
        Console.WriteLine("\n8================D");
  }
  
  
  /*private static void DisplayNames(params string[] array)
  {
      foreach(string arr in array)
        Console.Write("{0} ", arr);
        Console.WriteLine("\n--------------------");
        
        
        
  }*/
}
