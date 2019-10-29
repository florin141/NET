using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NET.Domain.Tests
{
    public class CalculateTests
    {
        [Fact]
        public void AddTest1()
        {
            Assert.Equal(2, Calculate.Add(1, 1));
        }

        [Fact]
        public void AddTest2()
        {
            Assert.Equal(3, Calculate.Add(1, 1));
        }
    }
}
