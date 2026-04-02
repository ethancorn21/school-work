using System;
using static System.Console;
using System.Globalization;

class AutomobileDemo
{
	static void Main()
	{
		// Write your code here
		//declare array of 8 automobile objects
		//iterate through array
		//get user input
		//check for duplicate ID
		//reprompt if duplicate
		//iterate to next automobile object in array

		//sort by id number : least to great
		//call .ToString
		//display total for all
		Automobile[] arr = new Automobile[8];
        for (int i = 0; i < arr.Length; ++i)
        {
            arr[i] = new Automobile();

            while (true)
            {
                Write("ID >> ");
                int inputId = int.Parse(ReadLine());

                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[j].IdNumber == inputId)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    arr[i].IdNumber = inputId;
                    break;
                }

                WriteLine("ID is taken");
            }

            Write("Make >> ");
            arr[i].Make = ReadLine();
            Write("Year >> ");
            arr[i].Year = int.Parse(ReadLine());
            Write("Price >> ");
            arr[i].Price = double.Parse(ReadLine());
        }

        Array.Sort(arr, (a, b) => a.IdNumber.CompareTo(b.IdNumber));

        double total = 0;
        foreach (Automobile a in arr)
        {
            WriteLine(a.ToString());
            total += a.Price;
        }

        WriteLine($"\nTotal for all Automobiles is {total.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
	}
}

class Automobile
{
	public int IdNumber{get;set;}
	public string Make{get;set;}
	public int Year{get;set;}
	public double Price{get;set;}

	public override string ToString()
	{
		return $"Automobile {IdNumber} {Year} {Make} Price is {Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
	}
}
