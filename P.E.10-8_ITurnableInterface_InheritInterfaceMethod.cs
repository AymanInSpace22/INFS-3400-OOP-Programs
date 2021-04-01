using System;

namespace _10_8_ITurnableIInterface_Inheriting
{
    class Program
    {
        static void Main(string[] args)
        {
            Page page1 = new Page();
            Corner corner1 = new Corner();
            Pancake pan1 = new Pancake();
            Leaf leaf1 = new Leaf();

            page1.Turn();
            corner1.Turn();
            pan1.Turn();
            leaf1.Turn();
        }
    }

    interface ITurnable
    {
        public void Turn();
    }

    class Page : ITurnable
    {
        // you do not need to write override here because there is nothing to override.
        // if the method you wanted to use has statements, then you would need to override
        // however becuase you are inheriting from an interface, there is no method statements to override.
        // so the declaration is just the access specifier and return type plus the interfaces method name.
        public  void Turn()
        {
            Console.WriteLine("You turn a page in a book.");
        }
    }

    class Corner : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine("You turn corners to go around the block.");
        }
    }

    class Pancake : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine("You turn a pancake when its done on one side.");
        }
    }

    class Leaf : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine("A leaf turns colors in the fall.");
        }
    }

}


