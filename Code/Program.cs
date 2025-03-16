using System;

class Program
{
    static void Main()
    {
        Clock4YouClock clock = new Clock4YouClock();
        Clock4YouDisplay display = new Clock4YouDisplay();
        clock.Attach(display);

        Console.ReadLine(); // Håller programmet igång
    }
}