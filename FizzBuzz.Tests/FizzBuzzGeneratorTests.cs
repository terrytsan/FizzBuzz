using Moq;
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

	[Theory]
	[InlineData(1, 100, 100)]
	[InlineData(-100, 100, 201)]
	public void GenerateResults_CallsProcessorMethodToRetrieveResults(int lowerBound, int upperBound, int expectedCalls)
	{
		var processor = new Mock<IFizzBuzzProcessor>([]);
		IFizzBuzzGenerator generator = new FizzBuzzGenerator(processor.Object);

		_ = generator.GenerateResults(lowerBound, upperBound);

		processor.Verify(p => p.GenerateResult(It.IsAny<int>()), Times.Exactly(expectedCalls));
	}
}