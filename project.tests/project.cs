using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CountRepeats_DoesNotAppearInSentence_0()
    {
      RepeatCounter newCount = new RepeatCounter("a", "bb");
      int expected = 0;
      int actual = newCount.Counts();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void appearsOnce()
    {
      RepeatCounter newCount = new RepeatCounter("a", "bb a");
      int expected = 1;
      int actual = newCount.Counts();
      Assert.AreEqual(expected, actual);
    }
    //
    // [TestMethod]
    // public void appearsTwice()
    // {
    //
    // }
    //
    // [TestMethod]
    // public void Thrice_withCaps()
    // {
    //
    // }

  }
}
