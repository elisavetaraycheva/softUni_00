using System;


class WorkHours
{
    static void Main(string[] args)
    {
        int RequiredWorkHour;
        Int32.TryParse(Console.ReadLine(), out RequiredWorkHour);
        int AvailableDays;
        Int32.TryParse(Console.ReadLine(), out AvailableDays);
        byte Productivity;
        Byte.TryParse(Console.ReadLine(), out Productivity);

        double WorkTime = (AvailableDays  - AvailableDays * 10.0 / 100) * 12.0 * Productivity / 100;
        int WorkHour = (int)WorkTime - RequiredWorkHour;
        
        if (WorkHour < 0)
            Console.WriteLine("No");
        else
            Console.WriteLine("Yes");
        Console.WriteLine(WorkHour);
    }
}

