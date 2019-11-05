using System;
using Xunit;
using ValidIsbn;
using FluentAssertions;

namespace ValidIsbnTest
{
    public class ValidIsbnTest
    {
        [Fact]
        public void ReturnTrueForValidIsbnNoSpaces()
        {
            var isbnInput = "0471958697";
            var expected = true;
            var actual = ValidateIsbn.IsValidIsbn(isbnInput);

            actual.Should().Be(expected);
            
        }
    }
}
