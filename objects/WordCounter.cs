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

     var count=0;
      string mySentence=this._sentence;
      string[] myArry=mySentence.Split(' ');
      for (int i=0; i<myArry.Length; i++) {

      if(myArry[i]==this._word)
      {
        count=count+1;
      }
         }
         return count;
      }




  }
}
