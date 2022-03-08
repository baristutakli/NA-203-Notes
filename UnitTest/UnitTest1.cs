using System;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Learn Unit Test
            Assert.Equal(4, Add(2, 2));
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal(5, Add(2, 2));
        }
        int Add(int x,int y)
        {
            return x + y;
        }

        
    }
}
