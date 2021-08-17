using System;
using Xunit;
using OddEven;

namespace OddEvenTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(13,true)]
        [InlineData(12, false)]
        [InlineData(57,false)]
        [InlineData(3, true)]
        [InlineData(17, true)]

        public void TestIsPrime(int search, bool expected)
        {
            bool actual = Program.IsPrime(search);
            Assert.True(expected);
            
        }
    }
}
