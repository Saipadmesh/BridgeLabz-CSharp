using System;

public class WageCalculator
{
    public static List<Dictionary<string, string>> WorkList = new List<Dictionary<string, string>>();

    public static string search(string query)
    {
        Dictionary<string, string>? comp = WorkList.Find((company) => company["name"] == query);
        if(comp == null)
        {
            return "No wage for that company exists";
        }
        return comp["wage"];
    }
	public static void GenerateReport(string company, int wagePerHour)
	{
        
        int FULLDAYHOURS = 8, HALFDAYHOURS = 4;
        int WORKINGDAYSPERMONTH = 20, CurrentWorkingDaysPerMonth = 0;
        int WORKINGHOURS = 100, CurrentWorkingHours = 0;
        int TotalWage = 0;

        Console.Write("Attendance Report for {0}: ",company);
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
            TotalWage = CurrentWorkingHours * wagePerHour;
            CurrentWorkingDaysPerMonth++;
        }
        Console.WriteLine("\n");
        //Console.WriteLine("Total Wage for {0}: " + TotalWage,company);

        WorkList.Add(new Dictionary<string, string> { { "name", company }, { "wage",TotalWage.ToString()} });
        Console.WriteLine("\n");
    }
}
