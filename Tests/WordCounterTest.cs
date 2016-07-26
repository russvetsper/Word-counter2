using Xunit;
using System.Collections.Generic;
using System;

namespace WordCounter.Objects
{
  public class WordTest : IDisposable
  {
    public void Dispose()
    {

    }

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
    public void Test1_CoutRepeats_DoesntFindOneWords_true()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("A", "B");
      //Act
      int result = newWordCounter.CountRepeats();
      //Assert
      Assert.Equal(0, result);
    }

  }
}
