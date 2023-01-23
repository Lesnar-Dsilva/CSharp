class Program {
    public static void Main(String[] args) {
        Console.Write("Enter the amount of dollars\n>");
        Console.WriteLine(D2C(Convert.ToInt32(Console.ReadLine())));
    }
    static String D2C(int x) =>x*100+ "¢(cents)";
}

//05-07-2022 Elapsed 5mins