using System;
using Xunit;
using ValidIsbn;
using FluentAssertions;

namespace ValidIsbnTest
{
    public class ValidIsbnTest
    {
        [Fact]
        public void ReturnFalseForEmptyIsbn()
        {
            var isbnInput = "";
            var expected = false;
            var actual = ValidateIsbn.IsValidIsbn(isbnInput);

            actual.Should().Be(expected);
        }
        
        [Fact]
        public void ReturnTrueForValidIsbnNoSpaces()
        {
            var isbnInput = "9780470059029";
            var expected = true;
            var actual = ValidateIsbn.IsValidIsbn(isbnInput);

            actual.Should().Be(expected);
            
        }

        [Fact]
        public void ReturnFalseForIsbnLengthNotEqualThirteen()
        {
            var isbnInput = "97804700590298";
            var expected = false;
            var actual = ValidateIsbn.IsValidIsbn(isbnInput);

            actual.Should().Be(expected);
            
        }
    }
}
