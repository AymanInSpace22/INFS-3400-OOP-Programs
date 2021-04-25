using System;
using System.IO;
using static System.Console;
using System.Globalization;
class ReadPatientRecords
{
static void Main(string[] args)
  {
      //string fileName = "Patients.txt";

      /*using(StreamWriter sw = new StreamWriter(fileName, true))
      {
          sw.WriteLine("p1" +",Patient1," + "20");
          sw.WriteLine("p2" + ",Patient2," + "40");
          sw.WriteLine("p3" +",Patient3," + "120");
          sw.WriteLine("p4" + ",Patient4," + "20");
          sw.WriteLine("p5" + ",Patient5," + "35");

          sw.Close();
      }*/


      string path = "Patients.txt";

      string readText = File.ReadAllText(path);
      string[] patients = readText.Split("\n");
      foreach(string patient in patients)
      {
        if(!string.IsNullOrEmpty(patient) && patient != " ")
        {
          string[] patientInfo = patient.Split(',');
          Console.WriteLine("{0}\t{1}\t{2}",patientInfo[0], patientInfo[1],
          Convert.ToDecimal(patientInfo[2]).ToString("C", CultureInfo.GetCultureInfo("en-US")));
        }
      }




      /*int count = 0;
      using(StreamReader sr = new StreamReader(fileName))
      {
          while(!sr.EndOfStream)
          {
              Console.WriteLine(sr.ReadLine());
              count++;
          }

          //Console.WriteLine($"Total number of lines: {count}");
      }*/
      //int lines = File.ReadAllLines(fileName).Length;
      //Console.WriteLine($"Total number of lines: {lines}");
  }
}
