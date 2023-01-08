using System;

class Program
{
    public static int magicNumber =0;
    public static Random rand = new Random();
    public static bool GameOver =false;
    static void Main(string[] args)
    {
        magicNumber=rand.Next(1,101);
        int userGuess = 0;
        Console.WriteLine(magicNumber);//computer pick for user


        do
        {
            Console.Write("What is your guess? ");
            userGuess=Convert.ToInt32(Console.ReadLine());
            GuessNumber (userGuess);
        }
        while (GameOver == false);

        Console.ReadLine();

     }  
     public static void GuessNumber (int userGuess)
     {
        // challange to stop and continue the game
        int contPlay = 0;

        if (userGuess < magicNumber)
        Console.WriteLine("Lower");
        else if (userGuess > magicNumber)
        Console.WriteLine("Higher");
        else
        {
            Console.WriteLine("you guess it. press 1 to continue or 2 to exit");
            contPlay = Convert.ToInt32(Console.ReadLine());

            while (contPlay != 1 && contPlay !=2 )
            {
                Console.Write("Invaid selection: press 1 or 2 ");
                contPlay = Convert.ToInt32(Console.ReadLine());
            }
            if (contPlay.Equals(2))
            GameOver= true;
            else
            magicNumber = rand.Next(1, 101);
             
        }
     }

    }
    
