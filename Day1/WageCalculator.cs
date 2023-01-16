using System;

public static class WageCalculator
{
	public static void GenerateReport()
	{
        int WAGEPERHOUR = 20;
        int FULLDAYHOURS = 8, HALFDAYHOURS = 4;
        int WORKINGDAYSPERMONTH = 20, CurrentWorkingDaysPerMonth = 0;
        int WORKINGHOURS = 100, CurrentWorkingHours = 0;
        int TotalWage = 0;

        Console.Write("Attendance Report: ");
        while (CurrentWorkingHours < WORKINGHOURS && CurrentWorkingDaysPerMonth < WORKINGDAYSPERMONTH)
        {
            // generating attendance
            Random random = new Random();
            int attendance = random.Next(0, 2);
            int hours = random.Next(0, 2);
            Console.Write(attendance + ",");

            switch (attendance)
            {
                case 1: CurrentWorkingHours += (hours == 1) ? FULLDAYHOURS : HALFDAYHOURS; break;
                default: continue;
            }

            // calculating wage
            TotalWage = CurrentWorkingHours * WAGEPERHOUR;
            CurrentWorkingDaysPerMonth++;
        }
        Console.WriteLine("\n");
        Console.WriteLine("Total Wage: " + TotalWage);
    }
}
