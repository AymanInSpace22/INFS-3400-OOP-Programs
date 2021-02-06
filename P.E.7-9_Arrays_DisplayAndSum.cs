using static System.Console;
public class FlexibleArrayMethod
{
   static void Main()
   {
     // Write your main here

     int[] array1 = new int[3] {1, 2, 3};
     int[] array2 = new int[4] {1, 2, 3, 4};
     int[] array3 = new int[5] {1, 2, 3, 4, 5};

     DisplayAndSum(array1);
     DisplayAndSum(array2);
     DisplayAndSum(array3);
   }
   public static void DisplayAndSum(int[] arr)
   {
     //  Write your DisplayAndSum method here.
     int sum = 0;
    for(int i = 0; i < arr.Length ; i++)
    {
      WriteLine(arr[i]);
      sum += arr[i];
    }
    WriteLine(sum);
   }
}
