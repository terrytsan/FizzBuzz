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
		throw new NotImplementedException();
	}
}