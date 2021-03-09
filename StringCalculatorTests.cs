using System;
using TDDWorks;
using Xunit;

namespace TTDTests
{
    public class StringCalculatorTests
    {
        private StringCalculator sc;
        public StringCalculatorTests()
        {
            sc = new StringCalculator();
        }
        [Fact]
        public void EmptyTest()
        {
            Assert.Equal(0, sc.Add(""));
        }

        [Fact]
        public void SingleNumberTest()
        {
            Assert.Equal(7, sc.Add("7"));
        }

        [Fact]
        public void TwoNumbersCommaSumTest()
        {
            Assert.Equal(4, sc.Add("2,2"));
        }

        [Fact]
        public void TwoNumbersNewlineSumTest()
        {
            Assert.Equal(12, sc.Add("10\n2"));
        }

        [Fact]
        public void ThreeSumMixedSeparatorsTest()
        {
            Assert.Equal(15, sc.Add("5,8\n2"));
        }

        [Fact]
        public void NegativeNumberExceptionTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => sc.Add("-5"));
        }

        [Fact]
        public void IgnoreGreaterThan1000Test()
        {
            Assert.Equal(1010, sc.Add("1,2021\n1000,1001,103123013,9"));
        }
        [Fact]
        public void CustomDelimiterTest()
        {
            Assert.Equal(14, sc.Add("\\#\n5,4\n3#2"));
        }
        [Fact]
        public void CustomMulticharDelimiterTest()
        {
            Assert.Equal(14, sc.Add("\\[###]\n5,4\n3###2"));
        }
        [Fact]
        public void CustomMixedDelimitersTest()
        {
            Assert.Equal(15, sc.Add("\\[###]\n\\[XD]\n\\A\n\\B\n5###4XD3A2B1,0\n0"));
        }
    }
}
