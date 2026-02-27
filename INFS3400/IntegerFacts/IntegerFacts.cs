using System;
using static System.Console;

class IntegerFacts
{
    static void Main()
    {
        int[] array = new int[10];
        int count = FillArray(array);
        Statistics(array, count, out int high, out int low, out int sum, out double avg);

        WriteLine("The array has {0} values", count);
        WriteLine("The highest value is {0}", high);
        WriteLine("The lowest value is {0}", low);
        WriteLine("The sum of the values is {0}", sum);
        WriteLine("The average is {0}", avg);
    }

    public static int FillArray(int[] array)
    {
        int count = 0;
        Write("Please enter an integer or 999 to quit >> ");
        while (count < 10)
        {
            string input = ReadLine();
            if (int.TryParse(input, out int value))
            {
                if (value == 999)
                    break;
                array[count] = value;
                count++;
            }
            else
            {
                WriteLine("invalid");
            }
        }
        return count;
    }

    public static void Statistics(int[] array, int len, out int high, out int low, out int sum, out double avg)
    {
        high = array[0];
        low = array[0];
        sum = 0;

        for (int i = 0; i < len; i++)
        {
            if (array[i] > high)
                high = array[i];
            if (array[i] < low)
                low = array[i];
            sum += array[i];
        }

        avg = (double)sum / len;
    }
}
