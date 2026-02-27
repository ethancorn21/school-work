using System;
using static System.Console;
using System.Globalization;
using System.Runtime.ExceptionServices;

class Reverse3
{
    static void Main()
    {
        int firstInt=1;
        int middleInt=2;
        int lastInt = 3;

        WriteLine("{0} {1} {2}",firstInt,middleInt,lastInt);
        Reverse(ref firstInt,ref middleInt,ref lastInt);
        WriteLine("{0} {1} {2}",firstInt,middleInt,lastInt);
        //assign value to vars
        //call reverse method with ref parms to vars
        //places first value in lastInt variable
        //places lastInt value into firstInt variable
    }

    public static void Reverse(ref int first, ref int mid, ref int last)
    {
        int temp = first;
        first = last;
        last = temp;
    }
}
