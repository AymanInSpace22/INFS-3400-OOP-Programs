using System;
using static System.Console;
using System.IO;
class FileComparison
{
   static void Main()
   {
      // Write your code here
      FileInfo fileInfo1 = new FileInfo("Quote.txt");
      double size1 = fileInfo1.Length;

      FileInfo fileInfo2 = new FileInfo("Quote.docx");
      double size2 = fileInfo2.Length;

      double ratio = (size1 / size2) * 100;

      WriteLine("The size of the Word file is {0}", size2);
      WriteLine("and the size of the Notepad file is {0}", size1);
      WriteLine("The Notepad file is {0} % of the size of the word file", Math.Round(ratio, 2));         
      

   }
}
