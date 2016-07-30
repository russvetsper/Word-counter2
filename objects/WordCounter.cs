using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class WordCounter
  {
    private string _sentence;
    private string _word;

    public WordCounter(string sentence, string word)
    {
      _sentence = sentence.ToLower();
      _word = word.ToLower();
    }

    public string GetSentence()
    {
      return _sentence;
    }


    public void SetSentence(string sentence)
    {
      _sentence = sentence;
    }

    public string GetWord()
    {
      return _word;
    }


    public void SetWord(string word)
    {
      _word = word;
    }



    public int CountRepeat()
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
