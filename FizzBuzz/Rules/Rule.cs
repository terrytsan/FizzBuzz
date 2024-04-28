namespace FizzBuzz.Rules;

public abstract class Rule
{
	public abstract int Divisor { get; }
	public virtual bool IsApplicable(int number) => number % Divisor == 0;
	public abstract string Process(int number);
}