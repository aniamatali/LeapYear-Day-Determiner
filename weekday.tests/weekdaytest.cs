using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Weekday.Models;

namespace Weekday.Tests
{

  [TestClass]
  public class WeekdayerTests
  {
    [TestMethod]
    public void GetValue1Year()
    {
      //Arrange
      Weekdayer newDay = new Weekdayer(1,1,2);

      int output = 366;

      //Act
      int result = (newDay.dateCalc());
      Console.WriteLine("result " + result);

      //Assert
      Assert.AreEqual(result, output);

    }

    [TestMethod]
    public void GetValue1Leap()
    {
      //Arrange
      Weekdayer newDay = new Weekdayer(1,1,5);

      int output = 1462;

      //Act
      int result = (newDay.dateCalc());
      Console.WriteLine("result " + result);

      //Assert
      Assert.AreEqual(result, output);

    }

    [TestMethod]
    public void GetValueLeapCentury()
    {
      //Arrange
      Weekdayer newDay = new Weekdayer(1,1,100);

      int output = 36160;

      //Act
      int result = (newDay.dateCalc());
      Console.WriteLine("result " + result);

      //Assert
      Assert.AreEqual(result, output);

    }

    [TestMethod]
    public void GetValueLeapMillenium()
    {
      //Arrange
      Weekdayer newDay = new Weekdayer(1,1,1000);

      int output = 364878;

      //Act
      int result = (newDay.dateCalc());
      Console.WriteLine("result " + result);

      //Assert
      Assert.AreEqual(result, output);

    }

    [TestMethod]
    public void GetValueLeapBeforeLeapYear()
    {
      //Arrange
      Weekdayer newDay = new Weekdayer(1,1,12);

      int output = 4018;

      //Act
      int result = (newDay.dateCalc());
      Console.WriteLine("result " + result);

      //Assert
      Assert.AreEqual(result, output);

    }

    [TestMethod]
    public void GetDayOfWeek()
    {
      //Arrange
      Weekdayer newDay = new Weekdayer(1,1,1);

      string output = "Saturday";

      //Act
      string result = (newDay.dayCalc(newDay.dateCalc()));
      Console.WriteLine("result " + result);

      //Assert
      Assert.AreEqual(result, output);

    }




      // public void Dispose()
      // {
      //   Weekdayer.ClearAll();
      // }
    }
  }
