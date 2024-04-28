using FizzBuzz.Business_Logic;
using FizzBuzz.Rules;
using Moq;
using Xunit;

namespace FizzBuzz.Tests.Business_Logic;

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

	[Theory]
	[InlineData(1, "1")]
	[InlineData(3, "factor of three")]
	[InlineData(5, "factor of five")]
	[InlineData(10, "factor of five")]
	[InlineData(20, "factor of five")]
	[InlineData(21, "factor of seven")]
	public void GenerateResult_AppliesRulesInOrderOfDivisorDescending(int input, string expected)
	{
		var firstRule = new Mock<Rule>();
		firstRule.Setup(r => r.Divisor).Returns(5);
		firstRule.Setup(r => r.IsApplicable(It.Is<int>(x => x % 5 == 0))).Returns(true);
		firstRule.Setup(r => r.Process(It.IsAny<int>())).Returns("factor of five");
		var secondRule = new Mock<Rule>();
		secondRule.Setup(r => r.Divisor).Returns(3);
		secondRule.Setup(r => r.IsApplicable(It.Is<int>(x => x % 3 == 0))).Returns(true);
		secondRule.Setup(r => r.Process(It.IsAny<int>())).Returns("factor of three");
		var thirdRule = new Mock<Rule>();
		thirdRule.Setup(r => r.Divisor).Returns(7);
		thirdRule.Setup(r => r.IsApplicable(It.Is<int>(x => x % 7 == 0))).Returns(true);
		thirdRule.Setup(r => r.Process(It.IsAny<int>())).Returns("factor of seven");
		var processor = new FizzBuzzProcessor([firstRule.Object, secondRule.Object, thirdRule.Object]);

		var result = processor.GenerateResult(input);

		Assert.Equal(expected, result);
	}
}