using Xunit;

namespace FizzBuzz.Tests;

public class FizzBuzzGeneratorTests
{
	[Theory]
	[InlineData(1, 100, 100)]
	public void GenerateResults_ReturnsAllResultsInGivenRange(int lowerBound, int upperBound, int expected)
	{
		IFizzBuzzProcessor processor = new FizzBuzzProcessor([]);
		IFizzBuzzGenerator generator = new FizzBuzzGenerator(processor);

		var results = generator.GenerateResults(lowerBound, upperBound);

		Assert.Equal(expected, results.Count);
	}
}