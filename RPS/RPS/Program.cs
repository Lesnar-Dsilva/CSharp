class Program {
    static int d = 0;
    static String u = "";
    static Random r = new Random();
    static String[] RPS = { "rock", "paper", "scissors" };
    static int us = 0;
    static int ais = 0;
    public static void Main(String[] args) {
        RPSF(u);
    }
    
    static void RPSF(String u) {
        while (d == 0)
        {
            String ai = RPS[r.Next(0, RPS.Length)];
            Console.WriteLine("Rock, Paper or Scissors?: ");
            Console.WriteLine("Type \"q\" to QUIT.\n");
            u = Console.ReadLine();
            if (u == "rock" && ai == "rock" || u == "paper" && ai == "paper" || u == "scissors" && ai == "scissors")
            {
                Console.WriteLine("DRAW");
                Console.WriteLine("Score\nYOU:" + us + " AI:" + ais + "\n");
            }
            else if (u == "rock" && ai == "scissors" || u == "scissors" && ai == "paper" || u == "paper" && ai == "rock")
            {
                Console.WriteLine("Player WINS!");
                us++;
                Console.WriteLine("Score\nYOU:" + us + " AI:" + ais + "\n");
            }
            else if (u == "scissors" && ai == "rock" || u == "paper" && ai == "scissors" || u == "rock" && ai == "paper")
            {
                Console.WriteLine("AI WINS!");
                ais++;
                Console.WriteLine("Score\nYOU:" + us + " AI:" + ais + "\n");
            }
            else
            {
                Console.WriteLine("Unknown shape");

            }
            d = (us >= 3) ? 2 : (ais >= 3) ? 1 : 0;

        }
        if (us >= 3)
        {
            Console.WriteLine("Player WINS!!!");
        }
        else if (ais >= 3)
        {
            Console.WriteLine("AI WINS!!!");
        }
    }
}

//08-07-2022 25mins