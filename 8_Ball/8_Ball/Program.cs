class Program {
    public static void Main(String[] args)
    {
        String[] r = { "It is certain.", "It is decidedly so." ,"Without a doubt.","Yes definitely","You may rely on it.","As I see it, yes.","Most likely.","Outlook good.","Yes.","Signs point to yes.","Reply hazy, try again.","Ask again later.","Better not tell you now.","Cannot predict now.","Concentrate and ask again.","Don't count on it.","My reply is no.","My sources say no.","Outlook not so good.","Very doubtful"};
        Random rng = new Random();

        Console.Write("Ask a question to the Magic 8 Ball\n>");
        Console.ReadLine();
        int res = rng.Next(0, r.Length);
        Console.WriteLine(r[res]);
    }
}
//07-07-2022 9 mins