using TDD_Katas_project;
using Xunit;
using FluentAssertions;
using System;

namespace TestFizzBuzz.UnitTests
{
    public class TestFizzBuzz : IClassFixture<ResultFizzFixture>
    {
        private readonly FizzBuzz _fizzBuzz;
        private readonly string _resultFizz;
        public TestFizzBuzz(ResultFizzFixture fixture)
        {
            _fizzBuzz = new FizzBuzz();
            _resultFizz = fixture.ResultFizz;
        }

        [Fact]
        public void CanTestFizz()
        {
            _fizzBuzz.PrintNumber().Should().Be(_resultFizz);
        }

        [Fact]
        public void CanReturnFizzIfNumberDivisibleByThree()
        {
            var actualResult = _fizzBuzz.PrintNumber();
            actualResult.Should().Contain("Fizz");
        }

        [Fact]
        public void CanReturnBuzzIfNumberDivisibleByFive()
        {
            var actualResult = _fizzBuzz.PrintNumber();
            actualResult.Should().Contain("Buzz");
        }

        [Fact]
        public void CanReturnFizzBuzzIfNumberDivisibleByThreeAndFive()
        {
            var actualResult = _fizzBuzz.PrintNumber();
            actualResult.Should().Contain("FizzBuzz");
        }
    }

    public class ResultFizzFixture : IDisposable
    {
        public string ResultFizz { get; set; } = @"1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz";

        public void Dispose()
        {
            ResultFizz = null;
        }
    }
}
