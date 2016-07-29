using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class WordCounter
  {
    private string _sentence;
    private string _word;

    public WordCounter(string sen, string word)
    {
      _sentence = sen;
      _word = word;
    }


    public int CountRepeats()
    {
    if(this._word == this._sentence)
    {

      return 1;
    }else{
      return 0;
    }



  }
}
}
