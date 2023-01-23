class Program
{
    public static void Main(String[] args)
    {
        String gh = System.IO.File.ReadAllText("C:\\Users\\Lesna\\OneDrive\\Website Portfolio\\C#\\Green Eggs and Ham\\Green Eggs and Ham (Error).txt");
        int ci = 0;
        int cs = 0;
        String[] ghs = gh.Split();
        for (int i = 0; i < ghs.Length; i++)
        {
            if (ghs[i] == "i")
            {
                ci++;
                ghs[i] = "I";
            }
            else if (ghs[i] == "Sam-i-am!")
            {
                cs++;
                ghs[i] = "Sam-I-am!";
            }
            else if (ghs[i] == "Sam-i-am.")
            {
                cs++;
                ghs[i] = "Sam-I-am.";
            }

        }
        TextWriter tw = new StreamWriter("C:\\Users\\Lesna\\OneDrive\\Website Portfolio\\C#\\Green Eggs and Ham\\Green Eggs and Ham (Fixed).txt");
        tw.Write(String.Join(" ", ghs));
        tw.Close();
        Console.WriteLine("Fixed!" + " Corrected:" + ci + " i's" + ", Corrected:" + cs + " Sam-I-am's");

    }
}


    //13-07-2022 1hr 30mins