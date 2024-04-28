namespace FizzBuzz.Rules;

public class DefaultRule : Rule
{
	public override int Divisor => 1;
	public override string Process(int number) => number.ToString();
}