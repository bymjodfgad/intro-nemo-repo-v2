namespace intro_nemo_repo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to nemo game!(press enter)");
            Console.ReadLine();
            Console.WriteLine("Wanna play a game?");
            Console.WriteLine("[1] Yes");
            Console.WriteLine("[2] No");
            int gameornot = Convert.ToInt32(Console.ReadLine());

            switch (gameornot)
            {
                case 1:
                    Console.WriteLine("Game here!(press enter to start)");
                    Console.ReadLine();
                    Console.WriteLine("Guess the number!");
                    Random rng = new Random();
                    int random1 = rng.Next(26);

                    //debug: Console.WriteLine(random1);

                    Console.WriteLine("Input a number from 1-25");
                    int userinput = Convert.ToInt32(Console.ReadLine());

                   

                    if (userinput == random1)
                    {
                        Console.WriteLine("You Win!");
                        Console.WriteLine("exiting...");
                    }
                    else
                    {
                        Console.WriteLine("You lose");
                        Console.WriteLine("exiting...");
                    }
                    break;

                case 2:
                    Console.WriteLine("Okay exiting...");
                    break;
            }

        }
    }
}
