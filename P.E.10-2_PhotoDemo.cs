using System;
using static System.Console;
using System.Globalization;
class PhotoDemo
{
   static void Main()
   {
      // Write your main here
      /*Photo p1 = new Photo(8, 10);
      Photo p2 = new Photo(8, 9);

      MattedPhoto mp1 = new MattedPhoto(10, 12, "white");
      FramedPhoto fp1 = new FramedPhoto(8, 10, "modern", "silver");*/

      Photo  photo = new Photo();
      photo.Width = 8;
      photo.Height = 10;

      Photo photo2 = new Photo();
      photo2.Width = 8;
      photo2.Height = 9;

      MattedPhoto mp1 = new MattedPhoto();
      mp1.Width = 10;
      mp1.Height = 12;
      mp1.Color = "White";

      FramedPhoto fp1 = new FramedPhoto();
      fp1.Width = 8;
      fp1.Height = 10;
      fp1.Style = "modern";
      fp1.Material = "silver";

     WriteLine(photo.ToString());
     WriteLine(photo2.ToString());
     WriteLine(mp1.ToString());
     WriteLine(fp1.ToString());
     
   }
}

class Photo
{
  private double width;
  private double height;

  public double Width { get; set;}
  public double Height { get; set;}


  protected double price;
  public double Price 
  { 
    get
    {
      if(this.Width == 8 && this.Height == 10) 
      {
        this.price = 3.99;
      }
      else if(this.Width == 10 && this.Height == 12)
      {
        this.price = 5.99;
      }
      else
      {
        this.price = 9.99;
      }

      return price;
    }
  }
  

    public override string ToString()
    {
      return "Photo\t" + Width + " X " + Height + "\tPrice: " + Price.ToString("C", CultureInfo.GetCultureInfo("en-US")); 
    }
}


class MattedPhoto : Photo
{
  public string Color { get; set;}

  public override string ToString()
  {
    return "MattedPhoto\t" + Color + " matting " + Width + " X " + Height + "\tPrice: " + (Price + 10).ToString("C", CultureInfo.GetCultureInfo("en-US"));
  }
}

class FramedPhoto : Photo
{
  public string Material { get; set;}
  public string Style { get; set;}

  public override string ToString()
  {
    return $"FramedPhoto\t{Style}, {Material} frame. {Width} X {Height}\tPrice:{(Price + 25).ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
  }
}
