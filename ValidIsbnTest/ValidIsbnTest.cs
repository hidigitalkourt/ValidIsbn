using System;
using Xunit;
using ThirteenDigitIsbnValidator;
using FluentAssertions;

namespace ThirteenDigitIsbnValidatorTest
{
    public class ThirteenDigitIsbnValidatorTest
    {
        [Fact]
        public void ReturnFalseForEmptyIsbn()
        {
            var isbn = "";
            var expected = false;
            var actual = IsbnValidator.IsThirteenDigitIsbnValidator(isbn);

            actual.Should().Be(expected);
        }

        [Fact]
        public void ReturnTrueForThirteenDigitIsbnValidatorNoSpaces()
        {
            var isbn = "9780470059029";
            var expected = true;
            var actual = IsbnValidator.IsThirteenDigitIsbnValidator(isbn);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnFalseForIsbnLengthNotEqualThirteen()
        {
            var isbn = "97804700590298";
            var expected = false;
            var actual = IsbnValidator.IsThirteenDigitIsbnValidator(isbn);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnTrueForIsbnLengthOfThirteenWithDashes()
        {
            var isbn = "978-0-262-13472-9";
            var expected = true;
            var actual = IsbnValidator.IsThirteenDigitIsbnValidator(isbn);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnTrueForIsbnLengthOfThirteenWithExtraSpaces()
        {
            var isbn = "978 0 262 13472 9";
            var expected = true;
            var actual = IsbnValidator.IsThirteenDigitIsbnValidator(isbn);

            actual.Should().Be(expected);

        }
    }
}
