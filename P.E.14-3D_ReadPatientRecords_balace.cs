using System;
using static System.Console;
using System.Globalization;
using System.IO;
class FindPatientRecords2
{
    static void Main()
    {
        try
        {
            int counter = 0;
            string line;
            double balance;
            int flag = 0;
            Console.WriteLine("Please enter balance >> ");
            balance = double.Parse(Console.ReadLine());


            StreamReader file = new StreamReader("Patients.txt");



        


        while ((line = file.ReadLine()) != null)
            {
                string[] st = line.Split(',');

              

            double pBalance = double.Parse(st[2]);
                if (pBalance >= balance)
                {
                    Console.WriteLine("ID Number\tName\t\tBalance");
                    Console.WriteLine("{0} {1, 22} {2, 10}", st[0], st[1], Decimal.Parse(st[2]).ToString("C", CultureInfo.GetCultureInfo("en-US")));
                }

            

            }
        }

        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message + "\nSorry... shutting down now");
            //Console.WriteLine(ioe.StackTrace);
        }

        /*flag = 1;
        break;
        }
        counter++;
        }

        if (flag == 0)
        {
        Console.WriteLine("No records found for {0}", patientID);
        }

        file.Close();

        Console.ReadLine();*/

    }
}
