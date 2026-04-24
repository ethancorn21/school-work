/*
IdNumber  Name                 Balance

222       Anderson           $2,000.00
390       Bell               $2,500.00
488       Carter             $1,000.00
*/

using System;
using System.IO;
using static System.Console;
using System.Globalization;
class ReadPatientRecords
{
   static void Main()
    {
        const char DELIM = ',';
        FileStream inFile = new FileStream("Patients.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(inFile);

        string[] fields;
        WriteLine("IdNumber  Name                 Balance\n");

        string recordIn = reader.ReadLine();
        while (recordIn != null)
        {
            fields = recordIn.Split(DELIM);
            string id = fields[0];
            string name = fields[1];
            double salary = Convert.ToDouble(fields[2]);

            WriteLine("{0,-5}{1,-12}{2,8}", id, name, salary.ToString("C", CultureInfo.GetCultureInfo("en-US")));

            recordIn = reader.ReadLine();
        }
        reader.Close();
        inFile.Close();

    }
}
   