using System;

public class Clock4YouDisplay : IClockObserver
{
	public void Update(DateTime time)
	{
		Console.WriteLine("Clock4You Tid: " + time.ToString("HH:mm:ss"));
	}
}