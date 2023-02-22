using Microsoft.Extensions.Options;
using SeaisWeb.Client.Core.Loggers;
using System.ComponentModel.Design;

namespace SeaisWeb.Client.Core.Providers;

public class DbLoggerProvider : ILoggerProvider
{
    private readonly IOptions<DbLoggerProvider> _options;
    private readonly IServiceProvider _isp;
    private readonly HttpClient _httpService;

    public DbLoggerProvider(IOptions<DbLoggerProvider> options, IServiceProvider isp)
    {
        _options = options;
        _isp = isp;
        _httpService = _isp.CreateScope().ServiceProvider.GetRequiredService<HttpClient>();
    }




    // private readonly GSPService gsp;

    public ILogger CreateLogger(string categoryName)
    {
        return new DbLogger( categoryName);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        //throw new NotImplementedException();
    }
}
