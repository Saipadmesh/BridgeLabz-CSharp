namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WageCalculator.GenerateReport("GE",30);
            WageCalculator.GenerateReport("Accenture", 10);

            Console.WriteLine("Total Wages Report");
            foreach (var comp in WageCalculator.WorkList)
            {
                Console.WriteLine("{0}: Rs.{1}", comp["name"], comp["wage"]);
            }

            // var L1 = new Line(1, 2, 0, 5);
            //var L2 = new Line(5, 3, -1, 6);
            //LineComparison.Compare(L1, L2);

        }
    }
}