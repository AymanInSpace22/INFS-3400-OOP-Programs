using static System.Console;
public class Auction
{
   static void Main()
   {
       // Write your main here
       double bid;
       int bidInt;
       string dollarString = " dollars";
    
       const int MIN_BID = 10;
        
       Write("Please enter a bid: ");
       string entryString = ReadLine();

      if(int.TryParse(entryString, out bidInt))
          AcceptBid(bidInt, MIN_BID);
      else if(double.TryParse(entryString, out bid))
          AcceptBid(bid, MIN_BID);
      else if(entryString.Substring(0, 1).Equals(("$")))
          AcceptBid(entryString, MIN_BID); 
       else 
          WriteLine("Bid was not in correct format.");    
   }
    
   public static void AcceptBid(int bid, int min)
   {
      if(bid >= 10)
          WriteLine("Bid accepted.");
       else
          WriteLine("Bid not high enough.");
       
   }
   public static void AcceptBid(double bid, int min)
   {
      if(bid >= 10)
          WriteLine("Bid accepted.");
       else
          WriteLine("Bid not high enough.");
       
   }
   public static void AcceptBid(string bid, int min)
   {
     string dollarString = " dollars";
     string numStr;
     double bidDouble;
     if(bid.Substring(0, 1).Equals(("$")))
        numStr = bid.Substring(1, bid.Length-1);
     else if(bid.Substring(bid.Length - dollarString.Length, dollarString.Length).Equals(dollarString))
        numStr = bid.Substring(0,bid.Length - dollarString.Length);
     else {
       WriteLine("Bid was not in correct format");
       return;
     }
      
      if(double.TryParse(numStr, out bidDouble)) {
        if(bidDouble >= 10)
            WriteLine("Bid accepted");
        else
            WriteLine("Bid not high enough.");
      }
      else 
      {
        WriteLine("Bid was not in correct format");
      }
       
   }

}
