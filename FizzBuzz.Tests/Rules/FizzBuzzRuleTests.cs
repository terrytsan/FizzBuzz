using FizzBuzz.Rules;
using Xunit;

namespace FizzBuzz.Tests.Rules;

public class FizzBuzzRuleTests
{
	private readonly FizzBuzzRule _fizzBuzzRule = new();

	[Theory]
	[InlineData(300000)]
	[InlineData(15)]
	[InlineData(-30)]
	public void IsApplicable_ShouldReturnTrueIfNumberIsAFactor(int number)
	{
		Assert.True(_fizzBuzzRule.IsApplicable(number));
	}

	[Theory]
	[InlineData(72)]
	[InlineData(50)]
	[InlineData(-524123)]
	public void IsApplicable_ShouldReturnFalseIfNumberIsNotAFactor(int number)
	{
		Assert.False(_fizzBuzzRule.IsApplicable(number));
	}

	[Theory]
	[InlineData(50)]
	[InlineData(72)]
	[InlineData(-524123)]
	public void Convert_ReturnsFizzBuzzRegardlessOfNumber(int number)
	{
		Assert.Equal("FizzBuzz", _fizzBuzzRule.Process(number));
	}
}