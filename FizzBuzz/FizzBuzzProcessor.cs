using FizzBuzz.Rules;

namespace FizzBuzz;

public class FizzBuzzProcessor : IFizzBuzzProcessor
{
	private readonly IEnumerable<Rule> _rules;

	public FizzBuzzProcessor(IEnumerable<Rule> rules)
	{
		_rules = rules;
	}

	public string GenerateResult(int number)
	{
		return number.ToString();
	}
}