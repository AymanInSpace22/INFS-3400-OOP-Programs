using static System.Console;
class Reverse3
{
   static void Main()
   {
      // Write your main here
      int firstInt = 23;
      int middleInt = 45;
      int lastInt = 67;

      WriteLine("{0} {1} {2}", firstInt, middleInt, lastInt);

      Reverse(ref firstInt, ref middleInt, ref lastInt);
      WriteLine("{0} {1} {2}", firstInt, middleInt, lastInt);
     


   }
   
   public static void Reverse(ref int firstInt, ref int middleInt, ref int lastInt)
   {
     
     int temp;
     temp = firstInt;
     firstInt = lastInt;
     lastInt = temp;
   }

}
