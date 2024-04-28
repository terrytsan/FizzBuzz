namespace FizzBuzz;

public class App : IApp
{
	private readonly IFizzBuzzGenerator _fizzBuzzGenerator;

	public App(IFizzBuzzGenerator fizzBuzzGenerator)
	{
		_fizzBuzzGenerator = fizzBuzzGenerator;
	}

	public void Run(string[] args)
	{
		var results = _fizzBuzzGenerator.GenerateResults(1, 100);

		foreach (var result in results)
		{
			Console.WriteLine(result);
		}
	}
}