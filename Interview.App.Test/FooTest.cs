
using Xunit;

namespace Interview.App.Test
{
    public class FooTest
    {
        [Fact]
        public void IsPalindrome_ReturnsTrue()
        {
            var testClass = new Foo();

            bool result = testClass.IsPalindrome("aba");

            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_ReturnsFalse()
        {
            var testClass = new Foo();

            bool result = testClass.IsPalindrome("ab");

            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_ThrowsNullException()
        {
            var testClass = new Foo();

            Assert.Throws<ArgumentNullException>(() => testClass.IsPalindrome(null));
        }
    }
}