using System;
using FluentAssertions;
using Xunit;

namespace sigil.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            (1+2).Should().Be(3);
        }

        [Fact]
        public void FailingTest()
        {
            (1+1).Should().Be(5);
        }
    }
}
