using System;
using static System.Console;
using System.IO;
class WritePatientRecords
{
   static void Main()
    {
        bool running = true;

        Write("Enter patient ID number or 999 to quit >> ");
        string id = ReadLine();

        const string DELIM = ",";
        FileStream outFile = new FileStream("Patients.txt", FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(outFile);

        while (running)
        {
            if (id == "999")
            {
                running = false;
                break;
            }

            Patient p = new Patient();
            p.idNum = id;

            Write("Enter last name >> ");
            p.Name = ReadLine();
            Write("Enter balance >> ");
            p.Balance = double.Parse(ReadLine());

            writer.WriteLine(p.idNum + DELIM + p.Name + DELIM + p.Balance);

            Write("Enter next patient ID number or 999 to quit >> ");
            id = ReadLine();
        }

        writer.Close();
        outFile.Close();
   }
}

class Patient
{
    string idnum;
    string name;
    Double balance;

    public string idNum
    {
        get;
        set;
    }
    public string Name
    {
        get;
        set;
    }
    public double Balance
    {
        get;
        set;
    }

    public override string ToString()
    {
        string BalanceStr = Balance.ToString();

        return $"{idNum},{Name},{BalanceStr}";
    }
}