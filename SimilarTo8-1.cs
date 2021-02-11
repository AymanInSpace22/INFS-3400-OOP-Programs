using System;
class HelloWorld 
{
  static void Main() 
  {
   
    int [] nums = new int[10];
    int numEls;
    
    numEls = FillArray(nums);
  
      
  }
  
  public static int FillArray(int[] array)
  {
    int position = 0;  
    int entry = 0;  
    Console.Write("Please enter an integer or 999: ");
    while(position < array.Length && entry != 999)
    {
        if (int.TryParse(Console.ReadLine(), out entry))
            {
                if(entry != 999)
                {
                    array[position] = entry;
                    ++position;
                    Console.Write("Please enter an integer or 999: ");
                }
            }
            
        else
            Console.WriteLine("Invalid entry - try again");
    }
    return position;
  }
  
 
  
}
