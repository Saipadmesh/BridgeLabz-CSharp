using System;

public class Line
{
	private int x1,y1,x2,y2;
	public Line(int x1, int x2, int y1, int y2)
	{
		this.x1 = x1;
		this.y1 = y1;
		this.x2 = x2;	
		this.y2 = y2;
	}

	public double CalculateDist()
	{
		return Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2 - y1,2));
	}
}
