using FizzBuzz.Rules;
using Xunit;

namespace FizzBuzz.Tests.Rules;

public class BuzzRuleTests
{
	private readonly BuzzRule _buzzRule = new();

	[Theory]
	[InlineData(120000)]
	[InlineData(50)]
	[InlineData(-5)]
	public void IsApplicable_ShouldReturnTrueIfNumberIsAFactor(int number)
	{
		Assert.True(_buzzRule.IsApplicable(number));
	}

	[Theory]
	[InlineData(72)]
	[InlineData(11)]
	[InlineData(-524123)]
	public void IsApplicable_ShouldReturnFalseIfNumberIsNotAFactor(int number)
	{
		Assert.False(_buzzRule.IsApplicable(number));
	}

	[Theory]
	[InlineData(50)]
	[InlineData(72)]
	[InlineData(-524123)]
	public void Convert_ReturnsBuzzRegardlessOfNumber(int number)
	{
		Assert.Equal("Buzz", _buzzRule.Process(number));
	}
}