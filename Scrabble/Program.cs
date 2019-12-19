using System;
using System.Collections.Generic;

namespace Scrabble.Models {
  public class Program{
    static void Main()
    {
      Console.WriteLine("Welcome to Scrabble word score calculator. Please enter what word you'd like to calculate the score of below.");
      string inputWord = Console.ReadLine();
      Word theWord = new Word(inputWord);
      int score = theWord.Score();
      Console.WriteLine("If you played " + inputWord + " in Scrabble, it would score you " + score + " points!");
    }
  }
}