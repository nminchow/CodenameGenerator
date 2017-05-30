﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodenameGenerator.Tests
{
    [TestClass]
    public class WordBankTests
    {
        [TestMethod]
        public void WordBanks()
        {
            var nouns = WordBank.Nouns;
            var adjectives = WordBank.Adjectives;
            var firstNames = WordBank.FirstNames;
            var lastNames = WordBank.LastNames;
            var titles = WordBank.Titles;
            var stateNames = WordBank.StateNames;
            var days = WordBank.Days;
            var femaleFirstNames = WordBank.FemaleFirstNames;
            var maleFirstNames = WordBank.MaleFirstNames;
            var months = WordBank.Months;
        }
        [TestMethod]
        public void Nouns()
        {
            var nounBank = WordBank.Nouns;
            string[] nouns = nounBank.Get();
            Assert.IsNotNull(nouns);
            //lol
            Assert.IsTrue(!nouns.Contains("dilapidated"));
            Assert.IsTrue(nouns.Contains("dog"));
        }
        [TestMethod]        
        public void Adjectives()
        {
            var adjectiveBank = WordBank.Adjectives;
            string[] adjectives = adjectiveBank.Get();
            Assert.IsNotNull(adjectives);
            //lol
            Assert.IsTrue(adjectives.Contains("dirty"));
            Assert.IsTrue(!adjectives.Contains("hospital"));
        }
        [TestMethod]
        public void FirstNames()
        {
            var firstNamesBank = WordBank.FirstNames;
            string[] firstNames = firstNamesBank.Get();
            Assert.IsNotNull(firstNames);
            //lol
            Assert.IsTrue(firstNames.Contains("Dan"));
            Assert.IsTrue(!firstNames.Contains("horse"));
        }
        [TestMethod]
        public void LastNames()
        {
            var lastNamesBank = WordBank.LastNames;
            string[] lastNames = lastNamesBank.Get();
            Assert.IsNotNull(lastNames);
            //lol
            Assert.IsTrue(lastNames.Contains("Smith"));
            Assert.IsTrue(!lastNames.Contains("hospital"));
        }
        [TestMethod]
        public void Titles()
        {
            var titlesBank = WordBank.Titles;
            string[] titles = titlesBank.Get();
            Assert.IsNotNull(titles);
            //lol
            Assert.IsTrue(titles.Contains("Mister"));
            Assert.IsTrue(!titles.Contains("hospital"));
        }
        [TestMethod]
        public void Days()
        {
            var daysBank = WordBank.Days;
            string[] days = daysBank.Get();
            Assert.IsNotNull(days);
            Assert.IsTrue(days.Contains("Monday"));
            Assert.IsTrue(!days.Contains("January"));
        }
        [TestMethod]
        public void Months()
        {
            var monthsBank = WordBank.Months;
            string[] months = monthsBank.Get();
            Assert.IsNotNull(months);
            Assert.IsTrue(!months.Contains("Monday"));
            Assert.IsTrue(months.Contains("January"));
        }
        [TestMethod]
        public void StateNames()
        {
            var stateNames = WordBank.StateNames;
            string[] states = stateNames.Get();
            Assert.IsNotNull(states);
            Assert.IsTrue(states.Contains("Idaho"));
            Assert.IsTrue(!states.Contains("Boise"));
        }
        [TestMethod]
        public void FemaleFirstNames()
        {
            var femaleFirstNamesBank = WordBank.FemaleFirstNames;
            string[] names = femaleFirstNamesBank.Get();
            Assert.IsNotNull(names);
            Assert.IsTrue(names.Contains("Sarah"));
            Assert.IsTrue(!names.Contains("Robert"));
        }
        [TestMethod]
        public void MaleFirstNames()
        {
            var maleFirstNameBank = WordBank.MaleFirstNames;
            string[] names = maleFirstNameBank.Get();
            Assert.IsNotNull(names);
            Assert.IsTrue(names.Contains("Robert"));
            Assert.IsTrue(!names.Contains("Sarah"));
        }
        [TestMethod]
        public void ImplicitOperatorTests()
        {
            var word = Word.Noun;
            var wordBank = WordBank.Nouns;
            Assert.IsTrue(word == wordBank);

            var word1 = "Adjectives";
            var wordBank1 = WordBank.Adjectives;
            Assert.IsTrue(word1 == wordBank1);
        }
    }
}
