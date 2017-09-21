using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FizzBuzzing.Library;

namespace FizzBuzzing.Library.Tests
{
    [TestFixture]
    public class FizzBuzzRulesTests
    {
        [Test]
        public void FizzBuzzMultiplier(
            [Values(15)] int multiplier)
        {
            var currentWords = Multiplier.FizzBuzz;
            Multiplier newMultiplier = FizzBuzzRules.GetNewValue(currentWords, multiplier);
            Assert.AreEqual(Multiplier.FizzBuzz, newMultiplier);
        }

        [Test]
        public void FizzMultiplier(
            [Values(3, 6)] int multiplier)
        {
            var currentWords = Multiplier.Fizz;
            Multiplier newMultiplier = FizzBuzzRules.GetNewValue(currentWords, multiplier);
            Assert.AreEqual(Multiplier.Fizz, newMultiplier);
        }

        [Test]
        public void BuzzMultiplier(
            [Values(5)] int multiplier)
        {
            var currentWords = Multiplier.Buzz;
            Multiplier newMultiplier = FizzBuzzRules.GetNewValue(currentWords, multiplier);
            Assert.AreEqual(Multiplier.Buzz, newMultiplier);
        }
    }
}