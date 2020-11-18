using Csharp_Play;
using System;
using Xunit;

namespace Csharp.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Sum()
        {
            var r= Program.Sum(1, 1);
            Assert.Equal(2, r);
        }
    }
}
