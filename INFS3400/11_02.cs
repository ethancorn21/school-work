using System;
using static System.Console;
using System.Globalization;

/*
X degrees is comfortable for swimming.
X degrees is not comfortable for swimming.
Value does not fall within the expected range.
Enter the value 999 to quit the program.
*/

class SwimmingWaterTemperature
{
	static void Main()
	{
		Write("Enter temperature or 999 to quit >> ");
		int waterTemp = int.Parse(ReadLine());
		while (waterTemp != 999){
			if(waterTemp == 999)
			{
				break;
			}
			try {
				bool comfortableTemp = ComfortableSwim(waterTemp);
				if (comfortableTemp == true)
				{
					WriteLine("{0} degrees is comfortable for swimming.", waterTemp);
				}
				else
				{
					WriteLine("{0} degrees is not comfortable for swimming.", waterTemp);
				}
			}
			catch(ArgumentException ex)
			{
				WriteLine(ex.Message);
			}
			Write("Enter another temperature or 999 to quit");
			waterTemp = int.Parse(ReadLine());
		}
	}

	public static bool ComfortableSwim(int temp)
	{
		if(temp >= 32 && temp <= 212){
			if(temp>= 70 && temp <= 85)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		else
		{
			throw new ArgumentException("Value does not fall within the expected range.");
		}

	}
}