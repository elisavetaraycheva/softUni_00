using System;
using System.Collections.Generic;

class MagicStrings
{
    static int[,] arr;
    static int p = 0;
    static int q = 0;
    static void Main(string[] args)
    {
        byte diff;
        Byte.TryParse(Console.ReadLine(), out diff);
        int[] arrChar = new int[4];
        arr = new int[256, 4];
        List<int> Sums = new List<int>();
        List<string> MagicStr = new List<string>();

        Variations(arrChar, 4, 0, 1);
        for(int i = 0; i < 256; i++)
        {
            Sums.Add(GetRealInt(arr[i, 0]) + GetRealInt(arr[i, 1]) + GetRealInt(arr[i, 2]) + GetRealInt(arr[i, 3]));
        }

        for (int i = 0; i < 256; i++)
        {
            int Number = Sums[i] + diff;

            if (Sums.Contains(Number))
            {
                int Index = Sums.IndexOf(Number, 0);
                while (Index > 0)
                {
                    string s1 = String.Format("{0}{1}{2}{3}", GetRealLetter(arr[i, 0]), GetRealLetter(arr[i, 1]), GetRealLetter(arr[i, 2]), GetRealLetter(arr[i, 3]));
                    string s2 = String.Format("{0}{1}{2}{3}", GetRealLetter(arr[Index, 0]), GetRealLetter(arr[Index, 1]),
                        GetRealLetter(arr[Index, 2]), GetRealLetter(arr[Index, 3]));

                    MagicStr.Add(s1 + s2);
                    MagicStr.Add(s2 + s1);
                    Index = Sums.IndexOf(Number, Index + 1);
                }
            }
        }
        MagicStr.Sort();
        if (MagicStr.Count <= 0)
            Console.WriteLine("No");
        foreach (string s in MagicStr)
            Console.WriteLine(s);
    }


    static void Variations(int[] output, int n, int iter, int start)
    {
        if (iter >= output.Length)
        {
            foreach (int value in output)
            {
                arr[p, q] = value;
                q++;
            }
            p++;
            q = 0;
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                output[iter] = i;
                Variations(output, n, iter + 1, i);
            }
        }
    }

    static int GetRealInt(int a)
    {
        if (a == 1)
            return  3;
        else if (a == 2)
            return 4;
        else if (a == 3)
            return 1;
        else 
            return 5;
    }
    static char GetRealLetter(int a)
    {
        if (a == 1)
            return 's';
        else if (a == 2)
            return 'n';
        else if (a == 3)
            return 'k';
        else
            return 'p';
    }
}

