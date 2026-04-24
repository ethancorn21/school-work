
using System;
using static System.Console;
using System.Globalization;
using System.IO;
class FindPatientRecords
{
   static void Main()
   {
      const char DELIM = ',';
      FileStream inFile = new FileStream("Patients.txt", FileMode.Open, FileAccess.Read);
      StreamReader reader = new StreamReader(inFile);
      bool recordFound = false;

      string[] fields;

      string recordIn = reader.ReadLine();

      Write("Enter patient minimum balance due >> ");
      double userInput = Convert.ToDouble(ReadLine());
      WriteLine("IdNumber  Name                 Balance\n");

      while (recordIn != null)
      {
         fields = recordIn.Split(DELIM);
         string id = fields[0];
         string name = fields[1];
         double balance = Convert.ToDouble(fields[2]);

         if (balance >= userInput)
         {
               WriteLine("{0,-5}{1,-12}{2,8}", id, name, balance.ToString("C", CultureInfo.GetCultureInfo("en-US")));
         }
         recordIn = reader.ReadLine();
      }

      reader.Close();
      inFile.Close();
}
}