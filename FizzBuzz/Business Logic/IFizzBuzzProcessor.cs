namespace FizzBuzz.Business_Logic;

public interface IFizzBuzzProcessor
{
	/**
	* Returns result after applying appropriate FizzBuzz Rules
	*/
	string GenerateResult(int number);
}