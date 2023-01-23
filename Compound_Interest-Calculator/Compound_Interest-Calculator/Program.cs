class Program {
    public static void Main(String[] args) {
        double i = 0;
        double ir = 0;
        double n = 0;
        Console.Write("Enter the initial amount you deposited\n>");
        i = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the ANNUAL interes rate\n>");
        ir = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the compounding periods(years)\n>");
        n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your currency: ");
        String c = Console.ReadLine();
        Console.WriteLine($"Interest = {c}"+Math.Round((i*Math.Pow((1+(ir/100)),n)-i),2)+" 2dp(Decimal places)");
    }
}
//14-07-2022 18 mins