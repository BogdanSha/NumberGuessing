namespace NumGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumGuess();
        }

        private static void NumGuess()
        {
            bool cont = true;
            Random rand=new Random();
            int num = rand.Next(10, 100);
            int guess;
            //Console.WriteLine(num);
            Console.WriteLine("Guess a number between 10 and 100");
            while (cont == true)
            {
                
                guess = int.Parse(Console.ReadLine());
                if (guess == num)
                {
                    Console.WriteLine("Congrats Champ, you guessed right!!!");
                    cont = false;
                    break;
                }
                if (guess > num)
                {
                    Console.WriteLine("Your number is higher, Guess Again!");
                }
                if (guess < num)
                {
                    Console.WriteLine("Your number is lower, Guess Again!");
                }
            }
        }
    }
}