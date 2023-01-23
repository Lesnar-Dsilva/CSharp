class Program {
    public static void Main(String[] args) {
        Console.WriteLine("Convert to\n1.Google Case\n2.Camel Case: ");
        String x = Console.ReadLine();
        if (Convert.ToInt32(x) == 1)
        {
            Console.Write("Enter a sentence\n>");
            Google_Case(Console.ReadLine());
        }
        else if (Convert.ToInt32(x) == 2) {
            Console.Write("Enter a sentence\n>");
            Camel_Case(Console.ReadLine());
        }
        
        
    }
    static void Google_Case(String x)
    {
        char[] u = x.ToCharArray();
        char[] ul = x.ToLower().ToCharArray();
        char[] uu = x.ToUpper().ToCharArray();
        for (int i = 0; i < u.Length; i++)
        {
            if (u[i] == uu[i])
            {
                u[i] = ul[i];
            }
            else
            {
                u[i] = uu[i];
            }
        }
        Console.WriteLine(u);
    }
    static void Camel_Case(String x) {
        int z = 0;
        int sc = 0;
        char[] u = x.ToCharArray();
        char[] c = new char[u.Length-sc];
        
        for (int i = 0; i < u.Length; i++)
        {
            if (u[i] == ' ')
            {
                sc++;
                u[i + 1] = char.ToUpper(u[i + 1]);
                continue;
            }
            else
            {
                u[z++] = u[i];
            }
        }
        for (int i = 0; i < u.Length - sc; i++) {
            c[i] = u[i];
        }
        Console.WriteLine(c);
    }
}

//11-07-2022 8mins(Google Case) 18mins(Camel Case)