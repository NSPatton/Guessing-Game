using System;


Console.WriteLine("Lets play a guessing game!");
Console.WriteLine("--------------------------------------------");

GameStart();

void GameStart()
{
    Console.Write("Guess the secret number!  ");

    int secretNumber = new Random().Next(1, 100);
    int tries = 4;
    string guess = Console.ReadLine();
    int parsedGuess = int.Parse(guess);

    while (tries > 0)
        if (parsedGuess == secretNumber && tries > 0)
        {
            Console.WriteLine($"{parsedGuess} Is Correct! You got it dude!");
            return;
        }
        else if (parsedGuess != secretNumber && tries == 0)
        {
            Console.WriteLine($"Womp womp womp! {parsedGuess} aint it! No tries remaining... ");
            return;
        }
        else
        {
            string highLow = parsedGuess > secretNumber ? "Too High" : "Too Low";
            Console.WriteLine($"{highLow}! {parsedGuess} aint it! Try again! ({tries} guesses remaining)");
            tries--;
        }


}
