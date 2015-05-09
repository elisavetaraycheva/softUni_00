using System;


class CatchTheBits
{
    static void Main(string[] args)
    {
        byte NumCount;
        Byte.TryParse(Console.ReadLine(), out NumCount);

        byte Step;
        Byte.TryParse(Console.ReadLine(), out Step);
        byte[] Nums = new byte[NumCount];
        for(int i = 0; i < NumCount; i++)
        {
            Byte.TryParse(Console.ReadLine(), out Nums[i]);
        }
        //byte k = 1;
        //k = (byte)(k + Step);
        int Index = 0;
        int Result = 0;
        int cnt = 0;
        for(byte k = 1; k < 8 * NumCount; k = (byte)(k + Step))
        {
            if (k >= 8)
            {
                k = (byte)(k - 8);
                Index++;
                if (Index == Nums.Length) 
                    break;
            }
            
            byte Number = (byte)(Nums[Index] << k);
            Result = Result << 1;
            Result = (Result | (Number >> 7));
            cnt++;
        }
        while (cnt % 8 != 0)
        {
            cnt++;
            Result <<= 1;
        }
        for(int i = cnt - 8; i >= 0; i = i - 8)
            Console.WriteLine((byte)(Result >> i));
 
        
    }
}


