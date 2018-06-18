using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace DiversionTests
{
    public class Diversion
    {
        [Fact]
        [Trait("Category", "Diversion")]
        public void CombinatiosForThreeDigitNumbers()
        {
            DiversionKata.Diversion.BinaryNumbersSize(3).Should().Be(5);
        }

        [Fact]
        [Trait("Category", "Diversion")]
        public void CombinatiosForFourDigitNumbers()
        {
            DiversionKata.Diversion.BinaryNumbersSize(4).Should().Be(8);
        }

        [Fact]
        [Trait("Category", "Diversion")]
        public void CombinatiosForFiveDigitNumbers()
        {
            DiversionKata.Diversion.BinaryNumbersSize(5).Should().Be(13);
        }

        [Fact]
        [Trait("Category", "Diversion")]
        public void CombinatiosForTenDigitNumbers()
        {
            DiversionKata.Diversion.BinaryNumbersSize(10).Should().Be(144);
        }
    }
}
