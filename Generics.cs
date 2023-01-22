namespace FirstProject
{
    class Comp<T> where T : IComparable<T>
    {

        public static T Compare(T a, T b, T c)
        {
            // Refactor 2
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0) return a;
            if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0) return b;
            else return c;
        }

        public static T CompareMultiple(T[] vars)
        {
            // UC4
            Array.Sort(vars);
            return vars.Last();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            Console.WriteLine(Comp<int>.CompareMultiple(nums));

        }

        public static void PrintArray<T>(T[] array)
        {
            // Practice Problem
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static int MaxInt(int a, int b, int c)
        {
            // UC1
            if (a >= b && a >= c) return a;
            if (b >= c && b >= a) return b;
            else return c;
        }

        public static float MaxFloat(float a, float b, float c)
        {
            // UC2
            if (a >= b && a >= c) return a;
            if (b >= c && b >= a) return b;
            else return c;
        }

        public static string MaxString(string a, string b, string c)
        {
            // UC3
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0) return a;
            if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0) return b;
            else return c;
        }

        public static T Max<T>(T a, T b, T c) where T : IComparable
        {
            // Refactor 1
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0) return a;
            if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0) return b;
            else return c;

        }

        public static void PrintMax<T>(T a, T b, T c) where T : IComparable
        {
            // UC5
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0) Console.WriteLine(a);
            if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0) Console.WriteLine(b);
            else Console.WriteLine(c);

        }
    }
}