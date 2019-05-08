using System;
using Xunit;
using Katas;

namespace KatasTests
{
    public class FooTest
    {
        [Fact]
        public void fooMethodShouldReturnTrue()
        {
            var foo = new Foo();
            Assert.True(foo.fooMethod());
        }
    }
}
