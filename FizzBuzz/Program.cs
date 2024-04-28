using System.Reflection;
using FizzBuzz;
using FizzBuzz.Rules;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder(args).ConfigureServices((_, services) =>
{
	services.AddSingleton<IApp, App>();
	services.AddSingleton<IMessageWriter, MessageWriter>();
	services.AddSingleton<IFizzBuzzGenerator, FizzBuzzGenerator>();
	services.AddSingleton<IFizzBuzzProcessor, FizzBuzzProcessor>(_ =>
	{
		var rules = Assembly.GetExecutingAssembly().GetTypes()
							.Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(Rule)))
							.Select(t => (Rule)Activator.CreateInstance(t)!)
							.OrderByDescending(c => c.Divisor)
							.ToList();
		return new FizzBuzzProcessor(rules);
	});
}).Build();

using var scope = host.Services.CreateScope();

try
{
	scope.ServiceProvider.GetRequiredService<IApp>().Run(args);
}
catch (Exception ex)
{
	Console.WriteLine($"Unexpected error occurred.{ex}");
}