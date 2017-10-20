using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _inputWord;
    private string _inputSentence;

    public RepeatCounter (string inputWord, string inputSentence)
    {
      _inputWord = inputWord;
      _inputSentence = inputSentence;
    }

    public int Counts()
    {
      int Counter = 0;
      string word = _inputWord;
      string sentence = _inputSentence;


      string [] splitSentence = sentence.Split();

      if (word.Length == 0 || splitSentence.Length == 0)
      {
        Counter = 0;
      }
      else
      {
        for (int i = 0; i < splitSentence.Length; i+= 1)
        {
          if (splitSentence[i] == word)
          {
            Counter += 1;
          }
          else
          {
            Counter += 0;
          }
        }
      }
       return Counter;
    }
  }
}
