using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void BreatheInAnOut()
    {
        if (_seconds != 0)
        {
            Console.Write("Breathe in...");
            this.PauseWithCountdown(2);
            Console.Write("Now breathe out...");
            this.PauseWithCountdown(3);
            Console.WriteLine();

            int times = _seconds / 10;
            for (int i = times; i > 0; i--)
            {
                Console.Write("Breathe in...");
                this.PauseWithCountdown(4);
                Console.Write("Now breathe out...");
                this.PauseWithCountdown(6);
                Console.WriteLine();
            }
        }

    }
}