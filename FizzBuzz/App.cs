namespace FizzBuzz;

public class App : IApp
{
	private readonly IFizzBuzzGenerator _fizzBuzzGenerator;
	private readonly IMessageWriter _messageWriter;

	public App(IFizzBuzzGenerator fizzBuzzGenerator, IMessageWriter messageWriter)
	{
		_fizzBuzzGenerator = fizzBuzzGenerator;
		_messageWriter = messageWriter;
	}

	public void Run(string[] args)
	{
		var results = _fizzBuzzGenerator.GenerateResults(1, 100);

		foreach (var result in results)
		{
			_messageWriter.WriteMessage(result);
		}
	}
}