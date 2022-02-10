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
  }
}

