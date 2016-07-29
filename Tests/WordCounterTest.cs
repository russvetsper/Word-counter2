using Xunit;
using System.Collections.Generic;
using System;

namespace WordCounter.Objects
{
  public class WordTest
  {


    [Fact]
    public void Test1_CoutRepeats_FindsOneWords_true()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("A", "A");
      //Act
      int result = newWordCounter.CountRepeats();
      //Assert
      Assert.Equal(1, result);
    }


    [Fact]
    public void Test2_CoutRepeats_DoesntFindOneWords_true()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("A", "B");
      //Act
      int result = newWordCounter.CountRepeats();
      //Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void Test3_CoutRepeats_FindsTwoWords_true()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("a a b", "a");
      //Act
      int result = newWordCounter.CountRepeats();
      //Assert
      Assert.Equal(2, result);
    }


  }
}
