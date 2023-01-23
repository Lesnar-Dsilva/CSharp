class Program {
    public static void Main(String[] args)
    {
        int s = 0;
        while (s != -1) {
            Random r = new Random();
            Console.Write("Enter the side of the die (ENTER -1 TO EXIT)\n>");
            try { s = Convert.ToInt32(Console.ReadLine()); } catch(Exception) { Console.WriteLine("\nThat wasn't a number.\n"); }
            if (s <= -1) { Console.WriteLine("Thanks for playing!"); break; }
            int[] n = new int[s];
            int[] freq = new int[s];
            for (int i = 0; i < s; i++)
            {
                n[i] = r.Next(1, s + 1);
            }
            foreach (var item in n)
            {
                freq[item - 1]++;
            }
            Console.WriteLine();
            for (int i = 0; i < freq.Length; i++)
            {
                Console.WriteLine($"Number {i + 1} appears {freq[i]} ({Math.Round(((double)freq[i] / (double)s)*100,2)}%) times.");
                // Today I learned that int division can return 0, so I had to type cast manually the values into double values.
            }
            Console.WriteLine();
        }
        
    }
}
//12-07-2022 35mins