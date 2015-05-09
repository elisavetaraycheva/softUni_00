using System;


class SumOfElements
{
    static void Main(string[] args)
    {
        string sLine = Console.ReadLine();
        string[] sNumbers = sLine.Split(' ');

        int Sum = 0;
        int MaxNum = int.MinValue;
        for(int i = 0; i < sNumbers.Length; i++)
        {
            int Number;
            Int32.TryParse(sNumbers[i], out Number);
            if (Number > MaxNum)
            {
                MaxNum = Number;
            }
            Sum += Number;
        }
        if (Sum == 2 * MaxNum)
        {
            Console.WriteLine("Yes, sum={0}", MaxNum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(Sum - 2 * MaxNum));
        }
    }
}

