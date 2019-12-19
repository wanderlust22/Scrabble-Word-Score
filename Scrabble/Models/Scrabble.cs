using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrabble.Models
{
  public class Word
  {
    public string ScrabbleWord { get; set;}

    public Word(string scrabbleWord)
    {
      ScrabbleWord = scrabbleWord;
    }

    public char[] one = { 'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't' };
    public char[] two = { 'd', 'g' };
    public char[] three = { 'b', 'c', 'm', 'p' };
    public char[] four = { 'f', 'h', 'v', 'w', 'y' };
    public char[] five = { 'k' };
    public char[] eight = { 'j', 'x' };
    public char[] ten = { 'q', 'z' };

    public int Score()
    {
      int count = 0;
      string lower = ScrabbleWord.ToLower();
      char[] wordArr = lower.ToCharArray();
      for (int i = 0; i < wordArr.Length; i++)
      {
        if (one.Contains(wordArr[i]))
        {
          count++;
        }
        else if (two.Contains(wordArr[i]))
        {
          count = count + 2;
        }
        else if (three.Contains(wordArr[i]))
        {
          count = count + 3;
        }
        else if (four.Contains(wordArr[i]))
        {
          count = count + 4;
        }
        else if (five.Contains(wordArr[i]))
        {
          count = count + 5;
        }
        else if (eight.Contains(wordArr[i]))
        {
          count = count + 8;
        }
        else if (ten.Contains(wordArr[i]))
        {
          count = count + 10;
        }
      }
      return count;
    }
  }
}