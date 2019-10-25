using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Afgift;

namespace TestBilAfgift
{
    [TestClass]
    public class TestAfgift
    {
        [TestMethod]
        public void CarPrice_WhenPriceIsLessThanNull_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            int bil = -120000;

            //Acting
            try
            {
                Afgift.BilAfgift.AfgiftTilBil(bil);
                Assert.Fail("Den forventede exception var ikke kastet.");

            }
            catch (System.ArgumentOutOfRangeException e)
            {
                //Assert
                StringAssert.Contains(e.Message, Afgift.BilAfgift.CarPrice_WhenPriceIsLessThanNull);
            }
        }

        [TestMethod]
        public void CarPrice_WhenPriceIsHigherThanNull_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            int bil = -200000;

            //Acting
            try
            {
                Afgift.BilAfgift.AfgiftTilBil(bil);
                Assert.Fail("Den forventede exception var ikke kastet.");

            }
            catch (System.ArgumentOutOfRangeException e)
            {
                //Assert
                StringAssert.Contains(e.Message, Afgift.BilAfgift.CarPrice_WhenPriceIsLessThanNull);
            }
        }

        [TestMethod]
        public void CarPrice_WhenPriceIsLowerThanTwohundredThousand_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            int bil = 150000;

            //Acting
            try
            {
                Afgift.BilAfgift.AfgiftTilBil(bil);
                Assert.Fail("Den forventede exception var ikke kastet.");

            }
            catch (System.ArgumentOutOfRangeException e)
            {
                //Assert
                StringAssert.Contains(e.Message, Afgift.BilAfgift.CarPrice_WhenPriceIsLessThanNull);
            }
        }

        [TestMethod]
        public void CarPrice_WhenPriceIsOverTwohundredThousand_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            int bil = -100000;

            //Acting
            try
            {
                Afgift.BilAfgift.AfgiftTilBil(bil);
                Assert.Fail("Den forventede exception var ikke kastet.");

            }
            catch (System.ArgumentOutOfRangeException e)
            {
                //Assert
                StringAssert.Contains(e.Message, Afgift.BilAfgift.CarPrice_WhenPriceIsLessThanNull);
            }
        }

        [TestMethod]
        public void ElCarPrice_WhenPriceIsOverTwohundredThousand_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            int bil = -250000;

            //Acting
            try
            {
                Afgift.BilAfgift.AfgiftTilElbil(bil);
                Assert.Fail("Den forventede exception var ikke kastet.");

            }
            catch (System.ArgumentOutOfRangeException e)
            {
                //Assert
                StringAssert.Contains(e.Message, Afgift.BilAfgift.CarPrice_WhenPriceIsLessThanNull);
            }
        }

        [TestMethod]
        public void ElCarPrice_WhenPriceIsLessThanNull_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            int bil = -120000;

            //Acting
            try
            {
                Afgift.BilAfgift.AfgiftTilElbil(bil);
                Assert.Fail("Den forventede exception var ikke kastet.");

            }
            catch (System.ArgumentOutOfRangeException e)
            {
                //Assert
                StringAssert.Contains(e.Message, Afgift.BilAfgift.CarPrice_WhenPriceIsLessThanNull);
            }
        }

        [TestMethod]
        public void ElCarPrice_WhenPriceIsHigherThanNull_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            int bil = 200000;

            //Acting
            try
            {
                Afgift.BilAfgift.AfgiftTilElbil(bil);
                Assert.Fail("Den forventede exception var ikke kastet.");

            }
            catch (System.ArgumentOutOfRangeException e)
            {
                //Assert
                StringAssert.Contains(e.Message, Afgift.BilAfgift.CarPrice_WhenPriceIsLessThanNull);
            }
        }

        [TestMethod]
        public void ElCarPrice_WhenPriceIsLowerThanTwohundredThousand_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            int bil = -150000;

            //Acting
            try
            {
                Afgift.BilAfgift.AfgiftTilElbil(bil);
                Assert.Fail("Den forventede exception var ikke kastet.");

            }
            catch (System.ArgumentOutOfRangeException e)
            {
                //Assert
                StringAssert.Contains(e.Message, Afgift.BilAfgift.CarPrice_WhenPriceIsLessThanNull);
            }
        }

    }


}
