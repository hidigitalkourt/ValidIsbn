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
            var isbn = "";
            var expected = false;
            var actual = IsbnValidator.IsValidIsbn(isbn);

            actual.Should().Be(expected);
        }

        [Fact]
        public void ReturnTrueForValidIsbnNoSpaces()
        {
            var isbn = "9780470059029";
            var expected = true;
            var actual = IsbnValidator.IsValidIsbn(isbn);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnFalseForInvalidLength()
        {
            var isbn = "97804700590298";
            var expected = false;
            var actual = IsbnValidator.IsValidIsbn(isbn);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnTrueForIsbnLengthOfThirteenWithDashes()
        {
            var isbn = "978-0-262-13472-9";
            var expected = true;
            var actual = IsbnValidator.IsValidIsbn(isbn);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnTrueForIsbnLengthOfThirteenWithExtraSpaces()
        {
            var isbn = "978 0 262 13472 9";
            var expected = true;
            var actual = IsbnValidator.IsValidIsbn(isbn);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnTrueForValidLengthTen()
        {
            var isbn = "0471958697";
            var expected = true;
            var actual = IsbnValidator.IsValidIsbn(isbn);

            actual.Should().Be(expected);

        }


    }
}
