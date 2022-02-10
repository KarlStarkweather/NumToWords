using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumToWords.Models;

namespace NumToWords.Tests
{
  [TestClass]
  public class NumberTests
  {
    [TestMethod]
    public void NumberConstructor_CreateInstanceOfNumber_Number()
    {
      //Arrange
      int firstNum = 1;

      //Act
      Number newNumber = new Number(firstNum);

      //Assert
      Assert.AreEqual(typeof(Number), newNumber.GetType());
    }

    [TestMethod]
    public void NumberConstructor_SetValueOfNumber_1()
    {
      //Arrange
      int firstNum = 1;

      //Act
      Number newNumber = new Number(firstNum);

      //Assert
      Assert.AreEqual(newNumber.Value, 1);
    }

    [TestMethod]
    public void NumberName_NameSingleDigit_one()
    {
      //Arrange
      int firstNum = 1;

      //Act
      Number newNumber = new Number(firstNum);

      //Assert
      Assert.AreEqual(newNumber.Name(), "one");
    }

    [TestMethod]
    public void NumberName_NameTwoDigitNumber_thirteen()
    {
      //Arrange
      int firstNum = 13;

      //Act
      Number newNumber = new Number(firstNum);

      //Assert
      Assert.AreEqual(newNumber.Name(), "thirteen");
    }


  }
}

