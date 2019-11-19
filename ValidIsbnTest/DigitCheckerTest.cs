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
            //   131 3 131 31313
            var isbnInput = "9780262134729";
            var expected = 9 + (7 * 3) + 8 + (0 * 3) + 2 + (6 * 3) + 2 + (1 * 3) + 3 + (4 * 3) + 7 + (2 * 3);
            var actual = DigitChecker.GetSumOfDigitsWithAlternatingMultiplier(isbnInput);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnsFalseForInvalidCheckDigit()
        {
            var isbn = "9780262134723";
            var expected = false;
            var actual = DigitChecker.HasValidCheckDigitForLengthThirteen(isbn);

            actual.Should().Be(expected);
        }
    }
}
