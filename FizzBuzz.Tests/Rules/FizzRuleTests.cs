using FizzBuzz.Rules;
using Xunit;

namespace FizzBuzz.Tests.Rules;

public class FizzRuleTests
{
	private readonly FizzRule _fizzRule = new();

	[Theory]
	[InlineData(120000)]
	[InlineData(-30)]
	[InlineData(3)]
	public void IsApplicable_ShouldReturnTrueIfNumberIsAFactor(int number)
	{
		Assert.True(_fizzRule.IsApplicable(number));
	}

	[Theory]
	[InlineData(82)]
	[InlineData(14)]
	[InlineData(-524123)]
	public void IsApplicable_ShouldReturnFalseIfNumberIsNotAFactor(int number)
	{
		Assert.False(_fizzRule.IsApplicable(number));
	}

	[Theory]
	[InlineData(50)]
	[InlineData(72)]
	[InlineData(-524123)]
	public void Convert_ReturnsFizzRegardlessOfNumber(int number)
	{
		Assert.Equal("Fizz", _fizzRule.Process(number));
	}
}