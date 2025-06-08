using MathParser;

namespace MathParser.Tests
{
    public class MathParserTests
    {
        private readonly MathParser _sut = new();

        [Theory]
        [InlineData("1 + 2", 3)]
        [InlineData("2 * 3 + 4", 10)]
        [InlineData("2 + 3 * 4", 14)]
        [InlineData("(2 + 3) * 4", 20)]
        [InlineData("10 / 2 + 3", 8)]
        [InlineData("10 / (2 + 3)", 2)]
        [InlineData("3 + 4 * 2 / (1 - 5)", 1)]         // 3 + 8 / -4 = 3 - 2 = 1
        [InlineData("sqrt(25)", 5)]
        [InlineData("sqrt(9) + 1", 4)]
        [InlineData("2 + sqrt(16)", 6)]
        [InlineData("sqrt(4 + 5)", 3)]
        [InlineData("sqrt(16) + sqrt(9)", 7)]
        [InlineData("2 * sqrt(9 + 7)", 8)]             // 2 * sqrt(16) = 2 * 4 = 8
        public void Evaluate_ValidExpressions_ReturnsExpectedResult(string expression, double expected)
        {
            var result = _sut.Evaluate(expression);
            Assert.Equal(expected, result, precision: 6);
        }

        [Theory]
        [InlineData(")1 + 2(")]
        [InlineData("2 ** 3")]
        [InlineData("sqrt)9(")]
        [InlineData("sqrt(4 + )")]
        [InlineData("")]
        [InlineData("10 +")]
        public void Evaluate_InvalidExpressions_ThrowsException(string expression)
        {
            Assert.Throws<Exception>(() => _sut.Evaluate(expression));
        }
    }
}