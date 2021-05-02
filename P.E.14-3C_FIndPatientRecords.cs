using System;
using static System.Console;
using System.Globalization;
using System.IO;
class FindPatientRecords
{
    static void Main()
    {
        // we are searching the file for a specific keyword
        // reading the file

        int counter = 0;
        string line;
        string patientID;
        int flag = 0;
        Console.WriteLine("Please enter patient ID >> ");
        patientID = Console.ReadLine();

        System.IO.StreamReader file = new System.IO.StreamReader("Patients.txt");

        while ((line = file.ReadLine()) != null)
        {
            string[] st = line.Split(',');

            if (st[0].Equals(patientID) == true)
            {
                //Console.WriteLine("Patient ID: {0}\tPatient Name: {1}\tBalance: {2}", patientID, st[1], st[2]);
                Console.WriteLine("ID Number\tName\t\tBalance");
                Console.WriteLine("{0} {1, 22} {2, 10}", patientID, st[1], Decimal.Parse(st[2]).ToString("C", CultureInfo.GetCultureInfo("en-US")));

                flag = 1;
                break;
            }
            counter++;
        }

        if (flag == 0)
        {
            Console.WriteLine("No records found for {0}", patientID);
        }

        file.Close();

        Console.ReadLine();
    }
}
