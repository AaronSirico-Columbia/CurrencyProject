using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyProject.USCoins;
using CurrencyProject.Repos;
using CurrencyProject.Interfaces;
using CurrencyProject;
using static CurrencyProject.USCoins.USCoin;
using static CurrencyProject.Currency;
using static CurrencyProject.Currency.US;

namespace UnitTestsCurrency
{
    [TestClass]
    public class PennyTests
    {


        [TestMethod]
        public void PennyConstructor()
        {
            //Arrange
            Penny p, philiPenny;
            //Act 
            p = new Penny();
            philiPenny = new Penny(USCoinMintMark.P);
            //Assert
            //D is the default mint mark
            //Current Year is default year

            Assert.AreEqual(USCoinMintMark.P, philiPenny.MintMark);
        }

        [TestMethod]
        public void PennyMonetaryValue()
        {
            //Arrange
            Penny p;
            //Act 
            p = new Penny();
            //Assert
            Assert.AreEqual(.01, p.MonetaryValue);
        }

        [TestMethod]
        public void PennyAbout()
        {

            //Arrange
            Penny p;
            //Act 
            p = new Penny();
            //Assert
            Assert.AreEqual(Currency.US.USCoinMintMark.D, p.MintMark); //D is the default mint mark
            Assert.AreEqual(System.DateTime.Now.Year, p.Year); //Current year is default year
        }


    }


}