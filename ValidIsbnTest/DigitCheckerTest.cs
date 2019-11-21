using System;
using Xunit;
using ValidIsbn;
using FluentAssertions;

namespace ValidIsbnTest
{
    public class DigitCheckerTest
    {
        [Fact]
        public void ReturnsSumOfIsbnDigitsAlternatelyMulitipliedByOneOrThree()
        {
            var isbn = "9780262134729";
            var expected = 9 + (7 * 3) + 8 + (0 * 3) + 2 + (6 * 3) + 2 + (1 * 3) + 3 + (4 * 3) + 7 + (2 * 3);
            var actual = DigitChecker.GetSumOfMultipliedDigits(isbn);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnsFalseForInvalidCheckDigitThirteen()
        {
            var isbn = "9780262134723";
            var expected = false;
            var actual = DigitChecker.HasValidCheckDigit(isbn);

            actual.Should().Be(expected);
        }

        [Fact]
        public void ReturnsSumOfDigitsMultipliedByItsIndex()
        {
            var isbn = "0471606952";
            var expected = (0 * 1) + (4 * 2) + (7 * 3) + (1 * 4) + (6 * 5) + (0 * 6) + (6 * 7) + (9 * 8) + (5 * 9);
            var actual = DigitChecker.GetSumOfMultipliedDigits(isbn);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnsFalseForInvalidCheckDigitIsbnTen()
        {
            var isbn = "0471606951";
            var expected = false;
            var actual = DigitChecker.HasValidCheckDigit(isbn);

            actual.Should().Be(expected);
        }

           [Fact]
        public void ReturnsCheckDigitXForIsbnTen()
        {
            
            var isbn = "824013341X";
            var expected = "X";
            var actual = DigitChecker.GetCheckDigitForIsbnTen(isbn);
            actual.Should().Be(expected);
        }

        [Fact]
        public void ReturnsTrueForValidCheckDigitTen()
        {
            var isbn = "824013341X";
            var expected = true;
            var actual = DigitChecker.HasValidCheckDigit(isbn);

            actual.Should().Be(expected);
        }
    }
}
