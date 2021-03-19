using static System.Console;
class LetterDemo
{
   static void Main()
   {
     // Write your code here
     Letter l1 = new Letter();
     l1.Name = "Love Letter";
     l1.Date = "March 18th";
     
     // then up here I just used a WriteLine to output
     // the return to the screen
     WriteLine(l1.ToString());
   }
}

// Write your classes here

class Letter
{
  public string Name { get; set;}
  public string Date { get; set;}

  public override string ToString()
  {
    // oringinally I put Letter.GetType()
    // however, it was saying I needed an object reference so just change it to "this"
    // since it is a method in the same class
    return this.GetType() + " " + Name + " " + Date;
  }
}

class CertifiedLetter : Letter 
{
  public string TrackingNumber { get; set;}
}
