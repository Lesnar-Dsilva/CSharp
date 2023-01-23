class Program {
    static int s;
    
    static void Main(String[] args) {
        Console.Write("Enter the seconds\n>");
        s = Convert.ToInt32(Console.ReadLine());
        seconds(s);
        Console.WriteLine("*BEEP*");
    }
    static void seconds(int s)
    {
        for (int i = s; i > 0; i--)
        {
            Console.WriteLine(i+" second(s)");
            Thread.Sleep(1000);
        }
    }
}