namespace FizzBuzz.Rules;

public class FizzRule : Rule
{
	public override int Divisor => 3;
	public override string Process(int number) => "Fizz";
}