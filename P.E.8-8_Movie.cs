using static System.Console;
class Movie
{
   static void Main()
   {
      // Write your main here
      
      Write("Enter movie name: ");
      string movieName = ReadLine();
      Write("Enter movie duration: ");
      if(int.TryParse(ReadLine(), out int duration))
      {
        //WriteLine(duration);
        DisplayMovie(movieName, duration);
      }
      else
      {
        DisplayMovie(movieName);
        //or, you could have done this
        // WriteLine(90);
        //or 
        // duration = 90;
        // WriteLine(duration);
      }

      //DisplayNames(movieName, duration);

   }
   public static void DisplayMovie(string title, int duration = 90)
   {
     WriteLine("The movie {0} has a running time of {1} minutes.",title, duration);
   }
}
