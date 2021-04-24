using System;
using System.IO;

namespace _14_3A_WritePatientRecords
{
    class Program
    {
        static void Main(string[] args)
        {


            string fileName = "Patients.txt";

            using(StreamWriter sw = new StreamWriter(fileName, true))
            {
                //Patient p1 = new Patient();
                //Patient p2 = new Patient();
                //Patient p3 = new Patient();
                Patient p1 = new Patient();

                bool flag = true;
                while(flag)
                {
                    Console.WriteLine("Enter patient ID number or 999 to quit >> ");
                    p1.ID = Console.ReadLine();
                    //int idNum = int.Parse(Console.ReadLine());
                    if (p1.ID == "999")
                    {
                        flag = false;
                        continue;
                    }

                    Console.WriteLine("Enter last name >> ");
                    p1.Name = Console.ReadLine();
                    //string lName = Console.ReadLine();
                    Console.WriteLine("Enter balance >> ");
                    p1.Balance = double.Parse(Console.ReadLine());
                    //double balance = double.Parse(Console.ReadLine());

                    // this is how we actually write to the file
                    sw.WriteLine(p1.ID + "," + p1.Name + "," + p1.Balance);
                    //sw.WriteLine(p1.Name);
                    //sw.WriteLine(p1.Balance);

                    
                    //sw.Close();
                }
                // remember to close
                sw.Close();
            }
        }
    }


    class Patient
    {
        private string id;
        private string name;
        private double balance;

        public string ID
        {
            set { id = value; }
            get { return id; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public double Balance
        {
            set { balance = value; }
            get { return balance; }
        }
    }
}
