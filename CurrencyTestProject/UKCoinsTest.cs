using CurrencyProject.USCoins;
using CurrencyProject.Repos;
using CurrencyProject.Interfaces;
using CurrencyProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurrencyProject.UKCoins.UKCoin;
using static CurrencyProject.Currency;
using static CurrencyProject.Currency.UK;

namespace USCoinsTest
{

    [TestClass]
    public class UKCoinTests
    {

        [TestMethod]
        public void UKCoinMintMark()
        {

            //Arrange
            string mintNameRoyal, mintNameBirmingham, mintNameManchester, mintNameEdinburgh;
            UKCoinMintMark R, B, M, E;

            //Act 
            mintNameRoyal = "Royal Mint";
            mintNameBirmingham = "Birmingham Mint";
            mintNameManchester = "Manchester Mint";
            mintNameEdinburgh = "Edinburgh Mint";
            R = Currency.UK.UKCoinMintMark.R;
            B = Currency.UK.UKCoinMintMark.B;
            M = Currency.UK.UKCoinMintMark.M;
            E = Currency.UK.UKCoinMintMark.E;

            //Assert
            Assert.AreEqual(UKCoin.GetMintNameFromMark(R), mintNameRoyal);
            Assert.AreEqual(UKCoin.GetMintNameFromMark(B), mintNameBirmingham);
            Assert.AreEqual(UKCoin.GetMintNameFromMark(M), mintNameManchester);
            Assert.AreEqual(UKCoin.GetMintNameFromMark(E), mintNameEdinburgh);
        }

    }
}
