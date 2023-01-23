class Program {
    public static void Main(String[] args) {
        int marks = 0;
        Console.Write("How many check marks do you have?: ");
        marks = Convert.ToInt32(Console.ReadLine());
        if (marks == 0)
        {
            timer(10);
        }
        else if (marks > 0 && marks < 4)
        {
            Console.WriteLine("Take a 5 minute break.\n");
            timer(300);
            Console.WriteLine("Begin working again.\n");
            timer(10);
        }
        else if (marks == 4)
        {
            Console.WriteLine("Take a 30 minute break.\n");
            timer(1800);
            Console.WriteLine("Time to work again.\n");
            timer(1500);
        }
        else {
            Console.WriteLine("That doesn't add up.\n");
        }
    }
    static void timer(int sec)
    {
        if (sec < 60 && sec >= 1) {
            Console.WriteLine("Setting up timer for "+sec+" seconds.\n");
            
        }
        else {
            Console.WriteLine("Setting up a timer for " + sec/60 + " minutes.\n");
        }
        DateTime now = DateTime.Now;
        int seconds = sec;//1500 seconds for 25 minutes
        double interval;
        do
        {
            Thread.Sleep(1000);
            interval = Math.Floor((DateTime.Now - now).TotalSeconds);
            Console.WriteLine(interval);
        } while (interval < seconds);
        Console.WriteLine("*BEEP*");
    }
}
//10-07-2022 50mins