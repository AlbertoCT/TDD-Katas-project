using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace CalcStatsTest
{
    public class CalcStatsTest
    {
        private List<int> _numbers;

        public CalcStatsTest()
        {
            _numbers = new List<int> { 6, 9, 15, -2, 92, 11 };
        }

        [Fact]
        [Trait("Category", "CalcStats")]
        public void CanCalculateMinimum()
        {
            var resultado = CalcStats.CalculationStats.CalculateMinimum(_numbers);
            resultado.Should().Be(-2);
        }

        [Fact]
        [Trait("Category", "CalcStats")]
        public void CanCalculateMinimumVoidList()
        {
            var resultado = CalcStats.CalculationStats.CalculateMinimum(new List<int>());
            resultado.Should().Be(0);
        }

        [Fact]
        [Trait("Category", "CalcStats")]
        public void CanCalculateMaximum()
        {
            var resultado = CalcStats.CalculationStats.CalculateMaximum(_numbers);
            resultado.Should().Be(92);
        }

        [Fact]
        [Trait("Category", "CalcStats")]
        public void CanCalculateMaximumVoidList()
        {
            var resultado = CalcStats.CalculationStats.CalculateMaximum(new List<int>());
            resultado.Should().Be(0);
        }

        [Fact]
        [Trait("Category", "CalcStats")]
        public void CanCalculateNumberOfElements()
        {
            var resultado = CalcStats.CalculationStats.CalculateNumberOfElements(_numbers);
            resultado.Should().Be(6);
        }

        [Fact]
        [Trait("Category", "CalcStats")]
        public void CanCalculateNumberOfElementsVoidList()
        {
            var resultado = CalcStats.CalculationStats.CalculateNumberOfElements(new List<int>());
            resultado.Should().Be(0);
        }

        [Fact]
        [Trait("Category", "CalcStats")]
        public void CanCalculateAverage()
        {
            var resultado = CalcStats.CalculationStats.CalculateAverage(_numbers);
            resultado.Should().BeApproximately(21.83333333, 0.1);
        }

        [Fact]
        [Trait("Category", "CalcStats")]
        public void CanCalculateCalculateAverageVoidList()
        {
            var resultado = CalcStats.CalculationStats.CalculateAverage(new List<int>());
            resultado.Should().Be(0);
        }
    }
}
