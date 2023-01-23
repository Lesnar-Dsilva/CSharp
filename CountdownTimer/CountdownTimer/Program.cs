class Program {
    public static void Main(String[] args) {
        Console.WriteLine("Enter the date: ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the month: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the year: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the hour(24 hours): ");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the minute: ");
        int mm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the seconds: ");
        int s = Convert.ToInt32(Console.ReadLine());
        DateTime left = DateTime.Parse(d+"/"+m+"/"+y+" "+h+":"+mm+":"+s);
        DateTime start = DateTime.Now;
        TimeSpan t = left - start;
        Console.WriteLine($"Day/s:{t.Days} Hour/s:{t.Hours} Minute/s:{t.Minutes} Second/s:{t.Seconds}");
    }
}
//09-07-2022 10mins