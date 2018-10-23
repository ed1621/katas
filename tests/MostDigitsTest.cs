using System;
using code;
using Shouldly;
using Xunit;

namespace tests
{
    public class MostDigitsTest
    {
        [Fact]
        public void ReturnsMostDigits()
        {
            var mostDigits = new MostDigits();

            var digits = mostDigits.GetDigits(new int[] {1500, 14, 1300});
            digits.ShouldBeOfType<int>();
            digits.ShouldBe(1500);
        }
    }
}