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
            var actual = IsbnValidator.IsValidIsbn(isbnInput);

            actual.Should().Be(expected);
        }

        [Fact]
        public void ReturnTrueForValidIsbnNoSpaces()
        {
            var isbnInput = "9780470059029";
            var expected = true;
            var actual = IsbnValidator.IsValidIsbn(isbnInput);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnFalseForIsbnLengthNotEqualThirteen()
        {
            var isbnInput = "97804700590298";
            var expected = false;
            var actual = IsbnValidator.IsValidIsbn(isbnInput);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnTrueForIsbnLengthOfThirteenWithDashes()
        {
            var isbnInput = "978-0-262-13472-9";
            var expected = true;
            var actual = IsbnValidator.IsValidIsbn(isbnInput);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnTrueForIsbnLengthOfThirteenWithExtraSpaces()
        {
            var isbnInput = "978 0 262 13472 9";
            var expected = true;
            var actual = IsbnValidator.IsValidIsbn(isbnInput);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnsFalseForInvalidCheckDigit()
        {
            var isbnInput = "9780262134723";
            var expected = false;
            var actual = IsbnValidator.IsValidIsbn(isbnInput);

            actual.Should().Be(expected);
        }
    }
}
