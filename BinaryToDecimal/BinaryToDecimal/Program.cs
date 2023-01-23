class Program {
    static void Main(string[] args)
    {
        Console.Write("Enter a binary number\n>");
        String bin = Console.ReadLine();

        //SIMPLEST SOLUTION

        Console.WriteLine(Convert.ToInt32(bin, 2).ToString());

        ////FOR LOOP SOLUTION

        //char[] dec = bin.ToCharArray();
        //Array.Reverse(dec);
        //int sum = 0;
        //for (int i = 0; i < dec.Length; i++) {
        //    if (dec[i] == '1') {if (i == 0) { sum += 1; }else{sum += (int)Math.Pow(2, i);}
        //    }
        //}
        //Console.WriteLine(sum);

        ////WHILE LOOP SOLUTION

        //char[] dec = bin.ToCharArray();
        //Array.Reverse(dec);
        //int sum = 0;
        //int i = 0;
        //while (i < dec.Length) {
        //    if (dec[i] == '1') {
        //        if (i == 0)
        //        {
        //            sum += 1;
        //        }
        //        else {
        //            sum += (int)Math.Pow(2, i);
        //        }
        //    }
        //    i++;
        //}
        //Console.WriteLine(sum);

        //02-07-2022
    }
}