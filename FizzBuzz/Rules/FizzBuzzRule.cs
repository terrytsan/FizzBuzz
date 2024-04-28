namespace FizzBuzz.Rules;

public class FizzBuzzRule : Rule
{
	public override int Divisor => 15;
	public override string Process(int number) => "FizzBuzz";
}