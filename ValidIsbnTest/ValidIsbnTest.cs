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

        [Fact]
        public void ReturnTrueForIsbnLengthOfThirteenWithDashes()
        {
            var isbnInput = "978-0-262-13472-9";
            var expected = true;
            var actual = ValidateIsbn.IsValidIsbn(isbnInput);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnTrueForIsbnLengthOfThirteenWithExtraSpaces()
        {
            var isbnInput = "978 0 262 13472 9";
            var expected = true;
            var actual = ValidateIsbn.IsValidIsbn(isbnInput);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnsSumOfIsbnDigitsAlternatelyMulitipliedByOneOrThree()
        {
            //   131 3 131 31313
            var isbnInput = "9780262134729";
            var expected = 9 + (7 * 3) + 8 + (0 * 3) + 2 + (6 * 3) + 2 + (1 * 3) + 3 + (4 * 3) + 7 + (2 * 3);
            var actual = ValidateIsbn.SumsAlternatingMulitpliersOfDigits(isbnInput);

            actual.Should().Be(expected);

        }

        [Fact]
        public void ReturnsModuloOfSummedDigits()
        {
            var isbnInput = "9780262134729";
            var expected = 91 % 10; 
            var actual = ValidateIsbn.ModulusTenOfResult(isbnInput);

            actual.Should().Be(expected);

        }

        
    }
}
