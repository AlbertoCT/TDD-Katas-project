using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PrimeFactors;
using FluentAssertions;

namespace PrimeFactorsTest
{
    public class PrimeFactorTest
    {
        // Build model compare to
        private List<int> GenerateList(int[] numbers)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                list.Add(numbers[i]);
            }

            return list;
        }

        [Fact]
        [Trait("Category", "PrimeFactors")]
        public void TestOne()
        {
            var result = PrimeFactor.Generate(1);
            result.Should().BeEquivalentTo(GenerateList(new int[] { }));
        }

        [Fact]
        [Trait("Category", "PrimeFactors")]
        public void TestTwo()
        {
            var result = PrimeFactor.Generate(2);
            result.Should().BeEquivalentTo(GenerateList(new int[] { 2 }));
        }

        [Fact]
        [Trait("Category", "PrimeFactors")]
        public void TestThree()
        {
            var result = PrimeFactor.Generate(3);
            result.Should().BeEquivalentTo(GenerateList(new int[] { 3 }));
        }

        [Fact]
        [Trait("Category", "PrimeFactors")]
        public void TestFour()
        {
            var result = PrimeFactor.Generate(4);
            result.Should().BeEquivalentTo(GenerateList(new int[] { 2, 2 }));
        }

        [Fact]
        [Trait("Category", "PrimeFactors")]
        public void TestSix()
        {
            var result = PrimeFactor.Generate(6);
            result.Should().BeEquivalentTo(GenerateList(new int[] { 2, 3 }));
        }

        [Fact]
        [Trait("Category", "PrimeFactors")]
        public void TestEight()
        {
            var result = PrimeFactor.Generate(8);
            result.Should().BeEquivalentTo(GenerateList(new int[] { 2, 2, 2 }));
        }

        [Fact]
        [Trait("Category", "PrimeFactors")]
        public void TestNine()
        {
            var result = PrimeFactor.Generate(9);
            result.Should().BeEquivalentTo(GenerateList(new int[] { 3, 3 }));
        }
    }
}
