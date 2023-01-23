class Program {
    public static void Main(String[] args) {
        var rand = new Random();
        int r = rand.Next(1, 11); ;
        int g = 0;
        int u = 0;
        while (g < 5){
            Console.Write("Guess a number between 1 and 10, you have 5 guesses\n>");
            u = Convert.ToInt32(Console.ReadLine());
            g++;
            //CONDITIONAL STATEMENTS SOLUTION

            if (u == r)
            {
                Console.WriteLine("The secret number was: " + r);
                Console.WriteLine("Congrats you guessed correctly!");
                break;
            }
            else if (g == 5)
            {
                Console.WriteLine("Sorry you ran out of guesses");
            }
            else
            {
                Console.WriteLine("Try again...");
            }
        }

        //// SWITCH CASE STATEMENTS SOLUTION
        //
        //while (g < 5) {
        //u = u == r ? 1 : g == 5? 2 :0;
        //switch (u) {
        //    case 1:
        //        Console.WriteLine("The secret number was: " + r);
        //        Console.WriteLine("congrats you guessed correctly!");
        //        g = 5;
        //        break;
        //    case 2:
        //        Console.WriteLine("Sorry you ran out of guesses");
        //        break;
        //    default:
        //        Console.WriteLine("Try again...");
        //        break;
        //}
        //}

        //// TERNARY CONDITIONAL OPERATOR SOLUTION
        //
        ////but while loop doesn't work exit loop if number is guessed correctly (g < 5) or loop will carry on until correct number is guessed (r!=u)
        //while (r != u)
        //{
        //    Console.WriteLine(u == r ? "The secret number was: " + r + "\nCongrats you guessed correctly!" : g == 5 ? "Sorry you ran out of guesses." : "Try again...");
        //}

        //01-07-2022
    }
}