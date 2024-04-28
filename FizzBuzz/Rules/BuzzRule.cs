namespace FizzBuzz.Rules;

public class BuzzRule : Rule
{
	public override int Divisor => 5;
	public override string Process(int number) => "Buzz";
}