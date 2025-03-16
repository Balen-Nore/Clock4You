using System;
using System.Collections.Generic;
using System.Timers;

public class Clock4YouClock
{
	private Timer timer;
	private DateTime currentTime;
	private List<IClockObserver> observers = new List<IClockObserver>();

	public Clock4YouClock()
	{
		timer = new Timer(1000); // Uppdatera varje sekund
		timer.Elapsed += (sender, e) => Tick();
		timer.Start();
	}

	public void Attach(IClockObserver observer)
	{
		observers.Add(observer);
	}

	public void Detach(IClockObserver observer)
	{
		observers.Remove(observer);
	}

	private void Tick()
	{
		currentTime = DateTime.Now;
		NotifyObservers();
	}

	private void NotifyObservers()
	{
		foreach (var observer in observers)
		{
			observer.Update(currentTime);
		}
	}
}