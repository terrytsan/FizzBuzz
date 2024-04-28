using FizzBuzz.Rules;

namespace FizzBuzz.Business_Logic;

public class FizzBuzzProcessor : IFizzBuzzProcessor
{
	private readonly IEnumerable<Rule> _rules;

	public FizzBuzzProcessor(IEnumerable<Rule> rules)
	{
		_rules = rules.OrderByDescending(r => r.Divisor);
	}

	public string GenerateResult(int number)
	{
		var rule = GetApplicableRule(number);
		return rule is null ? number.ToString() : rule.Process(number);
	}

	private Rule? GetApplicableRule(int number)
	{
		foreach (var rule in _rules)
		{
			if (rule.IsApplicable(number))
			{
				return rule;
			}
		}

		return null;
	}
}