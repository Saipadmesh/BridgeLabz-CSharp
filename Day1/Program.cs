namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WageCalculator.GenerateReport();
            var L1 = new Line(1, 2, 0, 5);
            var L2 = new Line(5, 3, -1, 6);
            LineComparison.Compare(L1, L2);
            
        }
    }
}