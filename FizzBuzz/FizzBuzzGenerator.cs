namespace FizzBuzz;

public class FizzBuzzGenerator : IFizzBuzzGenerator
{
	private readonly IFizzBuzzProcessor _fizzBuzzProcessor;

	public FizzBuzzGenerator(IFizzBuzzProcessor fizzBuzzProcessor)
	{
		_fizzBuzzProcessor = fizzBuzzProcessor;
	}

	public List<string> GenerateResults(int lowerBound, int upperBound)
	{
		var results = new List<string>();

		for (var i = lowerBound; i <= upperBound; i++)
		{
			results.Add(_fizzBuzzProcessor.GenerateResult(i));
		}

		return results;
	}
}