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
}