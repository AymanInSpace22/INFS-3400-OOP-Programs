using System;

namespace _10_6_GeometricShapeClass_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(3, 4);
            Triangle t1 = new Triangle(3, 4);
            Square s1 = new Square(10, 10);
            Square s2 = new Square(5);


            DisplayShapeStatistics(r1);
            DisplayShapeStatistics(t1);
            DisplayShapeStatistics(s1);
            DisplayShapeStatistics(s2);

            Console.ReadKey();
        }

        static void DisplayShapeStatistics(GeometricFigure g)
        {
            Console.WriteLine(g.GetType() + " Height: " + g.Height + " Width: " + g.Width + " Area: " + g.Area);
        }
    }

 

   abstract class GeometricFigure
    {
        // fields
        protected int height;
        protected int width;
        protected int area;

        // properties
        public int Height
        {
            get { return height; }
            set
            {
                height = value;
                ComputeArea();
            }
        }

        public int Width
        {
            get { return width; }
            set
            {
                width = value;
                ComputeArea();
            }
        }

        // Read-Only property
        public int Area
        {
            get { return area; }
        }


        // method
        public abstract void ComputeArea();


        // constructor
        public GeometricFigure(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }
    }




    class Rectangle : GeometricFigure
    {


        // we must implement this method becuase it is declared as abstract in the above class
        public override void ComputeArea()
        {
            area = Width * Height;
        }

        // constructor
        // always coming from the parent with the base
        public Rectangle(int h, int w) : base(h,w)
        {
        }
    }




    class Square : Rectangle
    {


        // construcotr accepts both height and width - forcing to be equal
        public Square(int h, int w) : base(w,w)
        {
        }

        // second constructor accepts one dimension - uses for both height and width
        public Square(int w) : base(w,w)
        {
        }

        // you must pull in the ComputeArea method again because it is abstract
        public override void ComputeArea()
        {
            area = Width * Height;
        }
    }




    class Triangle : GeometricFigure
    {
        public Triangle(int h, int w) : base(h,w)
        {
        }

        public override void ComputeArea()
        {
            area = Width * Height / 2;
        }
    }



}
