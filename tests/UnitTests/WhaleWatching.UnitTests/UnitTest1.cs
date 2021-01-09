using System;
using System.Threading.Tasks;
using Xunit;

namespace WhaleCD.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var p = 4 + 4;

            Assert.Equal(8, p);
        }
    }
}
