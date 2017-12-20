using System;
using Xunit;

using hello;

namespace hello_test
{
    public class HelloTextTest
    {
        [Fact]
        public void display_text_should_be_hello()
        {
            HelloText helloText = new HelloText();
            Assert.Equal(helloText.TextDisplay(), "hello");
        }
    }
}
