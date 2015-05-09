using System;
// Problem 15.	* – New House 
class NewHouse
{
    static void Main(string[] args)
    {
        byte HouseHeight;
        Byte.TryParse(Console.ReadLine(), out HouseHeight);
        byte medium = (byte)(HouseHeight / 2);
        for(byte i = medium; i > 0; i--)
            Console.WriteLine(Roof(HouseHeight, i));
        Console.WriteLine(BaseRoof(HouseHeight));
        for (int i = 0; i < HouseHeight; i++)
            Console.WriteLine(Floor(HouseHeight));
    }

    static string Floor(byte n)
    {
        string s;
        s = "|";
        for (int i = 1; i < n - 1; i++)
        {
            s += "*";
        }
        s += "|";
        return s;
    }

    static string BaseRoof(byte n)
    {
        string s = String.Empty;
        for (int i = 0; i < n; i++)
        {
            s += "*";
        }
        return s;
    }

    static string Roof(byte n, byte symCount)
    {
        string s = String.Empty;
        for (int i = 0; i < symCount; i++)
        {
            s += "-";
        }
        int k = n - 2 * symCount;
        for (int i = symCount; i < symCount + k; i++)
        {
            s += "*";
        }
        for (int i = symCount + k; i < n; i++)
        {
            s += "-";
        }
        return s;
    }
}

