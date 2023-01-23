class Program {
    public static void Main(String[] args) {

        Console.WriteLine("Would you like to convert from 1 = R2D(Roman to Decimal) OR 2 = D2R(Decimal to Roman): ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x == 1)
        {
            Console.Write("Enter a decimal number\n>");
            int u = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(D2R(u));
        }
        else if (x == 2)
        {
            Console.Write("Enter a roman number\n>");
            String u = Console.ReadLine().ToUpper();
            Console.WriteLine(R2D(u));
        }
        else {
            Console.WriteLine("UNKNOWN COMMAND!!!");
        }
    }static String D2R(int u) {
        return
            new String('I', u)
            .Replace(new String('I', 1000), "M")
            .Replace(new String('I', 900), "CM")
            .Replace(new String('I', 500), "D")
            .Replace(new String('I', 400), "CD")
            .Replace(new String('I', 100), "C")
            .Replace(new String('I', 90), "XC")
            .Replace(new String('I', 50), "L")
            .Replace(new String('I', 40), "XL")
            .Replace(new String('I', 10), "X")
            .Replace(new String('I', 9), "IX")
            .Replace(new String('I', 5), "V")
            .Replace(new String('I', 4), "IV");
    }

    static String R2D(String u) {
        var s = 0;

        foreach (var l in u)
        {
            switch (l)
            {
                case 'I':
                    s += 1;
                    break;
                case 'V':
                    s += 5;
                    break;
                case 'X':
                    s += 10;
                    break;
                case 'L':
                    s += 50;
                    break;
                case 'C':
                    s += 100;
                    break;
                case 'D':
                    s += 500;
                    break;
                case 'M':
                    s += 1000;
                    break;
                default:
                    Console.WriteLine("UNKNOWN SYMBOL/S!!!");
                    break;
            }
        }
        if (u.Contains("IV") || u.Contains("IX"))
        {
            s -= 2;
        }
        if (u.Contains("XL") || u.Contains("XC"))
        {
            s -= 20;
        }
        if (u.Contains("CD") || u.Contains("CM"))
        {
            s -= 200;
        }

        return "Sum: " + s;
    }
}



//06-07-2022 45mins