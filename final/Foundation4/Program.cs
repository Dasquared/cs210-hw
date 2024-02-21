using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Console.WriteLine("Program 4: Polymorphism with Exercise Tracking");
        Console.WriteLine();

        RunningActivity runningActivity = new RunningActivity("03 Nov 2022", 30, 3);
        activities.Add(runningActivity);

        CyclingActivity cyclingActivity = new CyclingActivity("04 Nov 2022", 20, 3);
        activities.Add(cyclingActivity);

        SwimmingActivity swimmingActivity = new SwimmingActivity("05 Nov 2022", 40, 30);
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }


    }
}