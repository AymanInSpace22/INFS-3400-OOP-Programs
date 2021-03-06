using static System.Console;
class ShirtDemo
{
   static void Main()
   {
      // Write your main here

    Shirt shirt1 = new Shirt();
    Shirt shirt2 = new Shirt();

    shirt1.Material = "Cotton";
    shirt1.Color = "Black";
    shirt1.Size = "Medium";

    shirt2.Material = "Polyester";
    shirt2.Color = "Grey";
    shirt2.Size = "Small";

    //WriteLine("Enter shirt material >> ");
    
    Display(shirt1, shirt2);


   }
   public static void Display(params Shirt[] shirts)
   {
     for(int i = 0; i < shirts.Length; ++i)
     // you must include the [i]
     // this will display all of your shirt object attributes
     {
      WriteLine("Shirt Material: {0}\nShirt Color: {1}\nShirt Size: {2}",
      shirts[i].Material, shirts[i].Color, shirts[i].Size);
     }
   }
}

class Shirt
{
  // you can get set like this
  public string Material {get; set;}

  // or get set like this. Plus other ways
  /*{
    get; set;
  }*/

  public string Color {get; set;}
  /*{
    get; set;
  }*/

  public string Size {get; set;}
  /*{
    get; set;
  }*/

}
