using System;

public static class LineComparison
{
	
	public static void Compare(Line p1, Line p2)
	{
		double dist1 = p1.CalculateDist(), dist2 = p2.CalculateDist();
		if(dist1 == dist2)
		{
			Console.WriteLine("Line1 is equal to Line2");
		}
		else if(dist1 < dist2)
		{
			Console.WriteLine("Line1 is lesser than Line2");
		}
		else
		{
			Console.WriteLine("Line1 is greater than Line2");
		}
	}
}
