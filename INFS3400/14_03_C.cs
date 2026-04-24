/*
Using the output file generated from your program in Exercise 3A, write the program FindPatientRecords that prompts the user for an ID number, reads records from Patients.txt, and displays data for the specified record. If the record does not exist, display the following error message:

No records found for p#

An example of the program is shown below:

Enter patient ID number to find >> p1

ID Number Name                 Balance

p1        Patient1              $20.00
*/

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
 
        Write("Enter patient ID number to find >> ");
        string userInput = ReadLine();

        while (recordIn != null)
        {
            fields = recordIn.Split(DELIM);
            string id = fields[0];
            string name = fields[1];
            double salary = Convert.ToDouble(fields[2]);

            if (id == userInput)
            {
                WriteLine("IdNumber  Name                 Balance\n");
                WriteLine("{0,-5}{1,-12}{2,8}", id, name, salary.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                recordFound = true;
            }
            recordIn = reader.ReadLine();
        }
        if (recordFound == false)
        {
            Write($"No records found for {userInput}");
        }

        reader.Close();
        inFile.Close();
   }
}