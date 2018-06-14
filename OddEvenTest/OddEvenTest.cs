using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using OddEvenKata;

namespace OddEvenTest
{
    public class OddEvenTest
    {
        [Fact]
        [Trait("Category", "OddEven")]
        public void CanGenerateNumbers()
        {
            OddEven oddEven = new OddEven();
            var result = oddEven.PrintNumbers();
            result.Should().NotBeNullOrWhiteSpace();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(66)]
        [InlineData(100)]
        [Trait("Category", "OddEven")]
        public void CanDetermineEvens(int number)
        {
            OddEven oddEven = new OddEven();
            var result = oddEven.IsEven(number);
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(65)]
        [InlineData(99)]
        [Trait("Category", "OddEven")]
        public void CanDetermineNotEvens(int number)
        {
            OddEven oddEven = new OddEven();
            var result = oddEven.IsEven(number);
            result.Should().BeFalse();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(65)]
        [InlineData(99)]
        [Trait("Category", "OddEven")]
        public void CanDetermineOdds(int number)
        {
            OddEven oddEven = new OddEven();
            var result = oddEven.IsOdd(number);
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(66)]
        [InlineData(100)]
        [Trait("Category", "OddEven")]
        public void CanDetermineNotOdds(int number)
        {
            OddEven oddEven = new OddEven();
            var result = oddEven.IsOdd(number);
            result.Should().BeFalse();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(41)]
        [Trait("Category", "OddEven")]
        public void CanDeterminePrimes(int number)
        {
            OddEven oddEven = new OddEven();
            var result = oddEven.IsPrime(number);
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(9)]
        [InlineData(99)]
        [Trait("Category", "OddEven")]
        public void CanDetermineNoPrimes(int number)
        {
            OddEven oddEven = new OddEven();
            var result = oddEven.IsPrime(number);
            result.Should().BeFalse();
        }

        [Theory]
        [InlineData(1, 100)]
        [InlineData(2, 200)]
        [InlineData(99, 9999)]
        [Trait("Category", "OddEven")]
        public void CanGenerateNumbersRange(int startNumber, int finishNumber)
        {
            OddEven oddEven = new OddEven();
            var result = oddEven.PrintNumbers(startNumber, finishNumber);
            result.Should().NotBeNullOrWhiteSpace();
        }
    }
}
