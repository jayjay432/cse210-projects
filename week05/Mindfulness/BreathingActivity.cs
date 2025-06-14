public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") {}

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int interval = 4; // 4 seconds per breath phase
        while (duration > 0)
        {
            Console.Write("Breathe in...");
            ShowCountDown(interval);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(interval);
            Console.WriteLine();
            duration -= interval * 2;
        }
        DisplayEndingMessage();
    }
}
