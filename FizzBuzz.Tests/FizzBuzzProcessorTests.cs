using FizzBuzz.Rules;
using Moq;
using Xunit;

namespace FizzBuzz.Tests;

public class FizzBuzzProcessorTests
{
	[Theory]
	[InlineData(1, "1")]
	[InlineData(72, "72")]
	[InlineData(-10, "-10")]
	public void GenerateResult_ShouldReturnInputAsStringIfThereAreNoRules(int input, string expected)
	{
		var processor = new FizzBuzzProcessor([]);

		var result = processor.GenerateResult(input);

		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData(1, "1")]
	[InlineData(3, "3")]
	[InlineData(5, "factor of five")]
	[InlineData(10, "factor of five")]
	[InlineData(20, "factor of five")]
	[InlineData(21, "21")]
	public void GenerateResult_AppliesSingleRuleCorrectly(int input, string expected)
	{
		var firstRule = new Mock<Rule>();
		firstRule.Setup(r => r.IsApplicable(It.Is<int>(x => x % 5 == 0))).Returns(true);
		firstRule.Setup(r => r.Process(It.IsAny<int>())).Returns("factor of five");
		var processor = new FizzBuzzProcessor([firstRule.Object]);

		var result = processor.GenerateResult(input);

		Assert.Equal(expected, result);
	}
}