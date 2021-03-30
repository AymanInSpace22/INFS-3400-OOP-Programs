using System;

namespace _10_7_UsingInterfaces_RecoveringDemo
{
    // this is P.E. 10-7
    // declasre 3 objects - for Patient, Upholster and FootballPlayer
    // Create an interface - named IRecoverable - method name Recover()
    // classess - Patient, Upholster and FootballPlayer
    // recover messages
    // messages - patient "I am gettinf better"
    // message - Upholstere " I have new material for the couch"
    // message - FootBallPlayer " I picked up the ball after a fumble"

    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            Upholsterer u = new Upholsterer();
            FootBallPlayer f = new FootBallPlayer();

            Console.Write("The patient says: ");
            p.Recover();
            Console.Write("The upholsterer says: ");
            u.Recover();
            Console.Write("The football player says: ");
            f.Recover();

            Console.ReadLine();
        }
    }




    interface IRecoverable
    {
        // dont put your code here - it only defines the structure
        // works like an abstract
        public void Recover();
    }



    // you must include everything from the IRecoverable in the class that inherits from it
    class Patient : IRecoverable
    {
        // this is an example - we are inheriting the interface method
        // WE MUST or we get an error
        public void Recover()
        {
            Console.WriteLine("I am getting better");
        }
    }




    class Upholsterer : IRecoverable
    {
        public void Recover()
        {
            Console.WriteLine(" I have new material for my couch");
        }
    }




    class FootBallPlayer : IRecoverable
    {
        public void Recover()
        {
            Console.WriteLine("I picked up the ball after a fumble");
        }
    }

}
