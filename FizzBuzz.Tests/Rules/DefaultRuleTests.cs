using FizzBuzz.Rules;
using Xunit;

namespace FizzBuzz.Tests.Rules;

public class DefaultRuleTests
{
	private readonly DefaultRule _defaultRule = new();

	[Theory]
	[InlineData(1241987)]
	[InlineData(5)]
	[InlineData(-10)]
	public void IsApplicable_ShouldReturnTrueForAnyInteger(int number)
	{
		Assert.True(_defaultRule.IsApplicable(number));
	}

	[Theory]
	[InlineData(50)]
	[InlineData(72)]
	[InlineData(-524123)]
	public void Convert_ReturnsBuzzRegardlessOfNumber(int number)
	{
		Assert.Equal(number.ToString(), _defaultRule.Process(number));
	}
}