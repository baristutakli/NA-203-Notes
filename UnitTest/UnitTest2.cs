using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest
{
    public class UnitTest2
    {
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        [Theory]
        [InlineData(10,2,600)]
        [InlineData(5,5,-4)]
        [InlineData(3, 3, 0)]
        public void MySecondTheory(int number1,int number2,int number3)
        {
            Assert.True(IsPositive(number1,number2,number3));
        }
        bool IsPositive(int x, int y,int z)
        {
            return x > 0 && y > 0 && z > 0;
        }

    }
}
