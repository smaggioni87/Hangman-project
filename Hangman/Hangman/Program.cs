﻿namespace Hangman;
class Program
{
    const int STARTING_GUESS_COUNT = 10;

    static void Main(string[] args)
    {
        Random rng = new Random();
        string availableLetters = ""; //make an array of letters to choose from
        string lettersAlreadyUsed = ""; //array of letters already used
        string guessThisWord = "_ _ _ _ _";

        List<string> wordBank = new List<string>();
        {
            wordBank.Add("think");
            wordBank.Add("flame");
            wordBank.Add("train");
            wordBank.Add("clean");
            wordBank.Add("great");
        }

        Console.WriteLine("Let's play hangman!");
        Console.WriteLine(guessThisWord);
        Console.Write($"Guess a letter. You have made # incorrect guesses. Only # wrong guesses remaining."); //Needs variables to track number of guesses left.
        Console.WriteLine($"You have already used these letters: {lettersAlreadyUsed}");
        string userGuess = Console.ReadLine();


        //Random word from list - Will need to go in a loop
        int randomListItem = rng.Next(wordBank.Count);
    }
}

