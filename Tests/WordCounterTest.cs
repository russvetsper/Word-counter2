using Xunit;
// using System.Collections.Generic;
using System;

namespace WordCountering
{
  public class WordTest
  {


    [Fact]
    public void Test1_CoutRepeats_FindsOneWords_true()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("A", "A");
      //Act
      int result = newWordCounter.CountRepeat();
      //Assert
      Assert.Equal(1, result);
    }


    [Fact]
    public void Test2_CoutRepeats_DoesntFindOneWords_true()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("A", "B");
      //Act
      int result = newWordCounter.CountRepeat();
      //Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void Test3_CoutRepeats_FindsTwoWords_true()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("a a b", "a");
      //Act
      int result = newWordCounter.CountRepeat();
      //Assert
      Assert.Equal(2, result);
    }

    [Fact]
    public void Test4_CoutRepeats_FindsOneWord_true()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("how are you", "how");
      //Act
      int result = newWordCounter.CountRepeat();
      //Assert
      Assert.Equal(1, result);
    }

    // [Fact]
    // public void Test5_CoutRepeats_FindsSentence_true()
    // {
    //   //Arrange
    //   WordCounter newWordCounter = new WordCounter("i like summer","i like summer");
    //   //Act
    //   int result = newWordCounter.CountRepeats();
    //   //Assert
    //   Assert.Equal(1, result);
    // }

    [Fact]
    public void Test5_compareCapitalTOSmall_fail()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("how are you", "HOW");
      //Act
      int result = newWordCounter.CountRepeat();
      //Assert
      Assert.Equal(1, result);
    }

  }
}
