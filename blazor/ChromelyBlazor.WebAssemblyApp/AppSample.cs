using Chromely;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ChromelyBlazor.WebAssemblyApp;

public class AppSample : ChromelyBasicApp
{
	public override void ConfigureServices(IServiceCollection services)
	{
		base.ConfigureServices(services);
		services.AddLogging(configure => configure.AddConsole());
		services.AddLogging(configure => configure.AddFile("Logs/serilog-{Date}.txt"));
	}
}
