namespace FizzBuzz;

public class MessageWriter : IMessageWriter
{
	public void WriteMessage(string message)
	{
		Console.WriteLine(message);
	}
}