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

    [TestMethod]
    public void appearsTwice()
    {
      RepeatCounter newCount = new RepeatCounter("a", "bb a a");
      int expected = 2;
      int actual = newCount.Counts();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Thrice_withCaps()
    {
      RepeatCounter newCount = new RepeatCounter("A", "bb A a A bA bbAa AAaa");
      int expected = 3;
      int actual = newCount.Counts();
      Assert.AreEqual(expected, actual);
    }

  }
}
