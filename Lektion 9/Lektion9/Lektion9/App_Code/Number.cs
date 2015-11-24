using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Number
/// </summary>
[Serializable]
public class Number
{
    private Random rN = new Random(DateTime.Now.Millisecond);
    public int NextNumber {get; set;}
    public int Max  {get; set;}
    private int count;
    private double aveage;
	
    public Number()
	{
        Max = 10;
        count = 1;
        aveage = 0.0;
        Random rN = new Random(DateTime.Now.Millisecond);
        NextNumber = rN.Next(DateTime.Now.Millisecond);
		
	}

    public double Next()
    {
        double v = (aveage * count + rN.Next(Max))/++count;
        aveage = v;
        return v;
    }

    public double RandomNext()
    {
        return rN.Next(Max);
    }
}