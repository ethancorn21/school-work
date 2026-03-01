using System;
using static System.Console;
using System.Globalization;
class SalesTaxDemo
{
	static void Main()
	{
		// Write your code here
		//create a array w/ 10 Sale objects
		//prompt user to fill Sale objects data 
		//(double InventoryNumber,double amount,double tax)
		//30 inputs in total
		//get and set accessirs for InvwentoryNumber and amount
		//tax calculated whenever amount is set
		//tax rate = 8% for first $100
		//6% tax rate for any amount more than $100
		//if (amount > 100){salestax = .06};else{salextax=.08};

		//after 10 displayed, sort by highest sales tax then display again
		//modify Modify the Sale class so its objects are comparable to each other based on tax owed
		//using IComparable.CompareTo()
		Sale[] arr = new Sale[10];
		for (int i = 0; i < 10; ++i)
		{
			Console.Write("Enter inventory number #{0} >> ", i + 1);
			string inventoryNum = ReadLine();
			Console.Write("Enter amount of sale >> ");
			double saleAmount = Double.Parse(ReadLine());

			arr[i] = new Sale
			{
				InventoryNumber = inventoryNum,
				Amount = saleAmount,
			};
		}

		for (int i = 0; i < 10; ++i)
		{
			Console.WriteLine("Sale # {0} Amount: {1} Sale {2}", i + 1, arr[i].InventoryNumber, arr[i].Amount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
			Console.WriteLine("     Tax is {0}", arr[i].Tax.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		}

		Array.Sort(arr);

		for (int i = 0; i < 10; ++i)
		{
			Console.WriteLine("Sale # {0} Amount: {1} Sale {2}", i + 1, arr[i].InventoryNumber, arr[i].Amount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
			Console.WriteLine("     Tax is {0}", arr[i].Tax.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		}
	}	
}


public class Sale : IComparable
{
	public string InventoryNumber { get; set; }
	public double Amount { get; set; }
	public double Tax
	{
		get
		{
			if (Amount > 100) { return ((Amount - 100) * .06) + 8.00; }
			else { return Amount * .08; }
		}
	}

    int IComparable.CompareTo(Object other)
	{
		Sale temp = (Sale)other;
		int returnVal;

		if (this.Tax < temp.Tax) returnVal = 1;
		else
		{
			if (this.Tax > temp.Tax) returnVal = -1;
			else
			{
				returnVal = 0;
			}
		}
		return returnVal;
    }
}