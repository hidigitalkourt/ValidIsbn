using System;
using Xunit;
using ValidIsbn;
using FluentAssertions;

namespace ValidIsbnTest
{
    public class DigitCheckerTest
    {
        

        [Fact]
        public void ReturnsModuloOfSummedDigits()
        {
            var isbnInput = "9780262134729";
            var expected = 91 % 10; 
            var actual = DigitChecker.ModulusTenOfResult(isbnInput);

            actual.Should().Be(expected);

        }

        [Fact]
        
        public void ReturnsModuloOfResultSubtractedFromTen()
        {
            var isbnInput = "9780262134729";
            var expected = (10 - (91 % 10)) % 10;
            var actual = DigitChecker.ModulusTenOfSubtractedResult(isbnInput);

            actual.Should().Be(expected);
        }

        [Fact]
        public void ReturnsFalseForInvalidCheckDigit()
        {
            var isbn = "9780262134723";
            var expected = false;
            var actual = DigitChecker.IsValidIsbn(isbn);

            actual.Should().Be(expected);
        }
    }
}
