using System;
class CookieOrder
{
    protected string orderNum;
    protected string name;
    protected string cookieType;
    protected int dozen;
    protected double price;

    public CookieOrder()
    {

    }

    public CookieOrder(string orderNo, string reciepientName, string cookieType, int dozen)
    {
        this.orderNum = orderNo;
        this.name = reciepientName;
        this.cookieType = cookieType;
        this.dozen = dozen;
    }

    public string OrderNum
    {
        set { orderNum = value; }
        get { return orderNum; }
    }
    public string Name
    {
        set { name = value; }
        get { return name; }
    }
    public string CookieType
    {
        set { cookieType = value; }
        get { return cookieType; }
    }
    public int Dozens
    {
        set { dozen = value; computePrice(); }
        get { return dozen; }
    }

    public double Price 
    {
      set {price = value;}
      get{ return price;}
    }

    public virtual double computePrice()
    {
        double prc;
        if (dozen <= 2)
            prc = 15 * dozen;
        else
            prc = 30 + 13 * (dozen - 2);
          price = prc;    
        return prc;
    }
}
class SpecialCookieOrder : CookieOrder
{
    private string specialDescription;


    public SpecialCookieOrder()
    {

    }

    public SpecialCookieOrder(string orderNo, string reciepientName, string cookieType, int dozens, string speciality) : base(orderNo, reciepientName, cookieType, dozens)
    {
        this.specialDescription = speciality;
    }
    public override double computePrice()
    {
        double prc;
        if (Dozens <= 2)
            prc = 15 * Dozens;
        else
            prc = 30 + 13 * (Dozens - 2);

        if (prc <= 40)
            prc = prc + 10;
        else
            prc = prc + 8;
        price = prc;    
        return prc;
    }

    public string SpecialDescription
    {
        set { specialDescription = value; }
        get { return specialDescription; }
    }
}
public class CookieDemo
{
    public static void Main()
    {

        SpecialCookieOrder order1 = new SpecialCookieOrder("101", "Arthur", " Chocolate Chip", 1, "gluten-free");
        Console.WriteLine("\nOrder #" + order1.OrderNum + "\t" + order1.Name);
        Console.WriteLine("\ttype: " + order1.SpecialDescription + " " + order1.CookieType);
        Console.WriteLine("\t" + order1.Dozens + " dozen --- $" + order1.computePrice());


        SpecialCookieOrder order2 = new SpecialCookieOrder("102", "Brown", "peanut butter", 2, "sugar-free");
        Console.WriteLine("\nOrder #" + order2.OrderNum + "\t" + order2.Name);
        Console.WriteLine("\ttype: " + order2.SpecialDescription + " " + order2.CookieType);
        Console.WriteLine("\t" + order2.Dozens + " dozen --- $" + order2.computePrice());

        
        SpecialCookieOrder order3 = new SpecialCookieOrder("103", "Cooper", "sugar", 3, "iced");
        Console.WriteLine("\nOrder #" + order3.OrderNum + "\t" + order3.Name);
        Console.WriteLine("\ttype: " + order3.SpecialDescription + " " + order3.CookieType);
        Console.WriteLine("\t" + order3.Dozens + " dozen --- $" + order3.computePrice());

        /*CookieOrder oneDoz = new CookieOrder(103, "Cooper", "iced sugar",3);
         Console.WriteLine("\nOrder #" + oneDoz.OrderNum + "\t" + order3.Name);
        Console.WriteLine("\ttype: " + " " + oneDoz.CookieType);
        Console.WriteLine("\t" + oneDoz.Dozen + " dozen --- $" + oneDoz.computePrice());*/
    }
}
