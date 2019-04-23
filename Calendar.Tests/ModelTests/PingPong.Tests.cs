using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;
using System;

namespace Calendar.Tests
{
  [TestClass]
  public class PingPongTests
  {
    [TestMethod]
    public void IsPingPong_DisplayTheGoodWords_False()
    {
    PingPong testPingPong = new PingPong();
    Assert.AreEqual(false, testPingPong.IsPingPong(3));
    }
    [TestMethod]
    public void IsLeapYear_MultiplesOfOneHundred_False()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsPingPong(8));
    }

  }
}








