using SeaisWeb.Client.Core.Providers;

namespace SeaisWeb.Client.Core.Loggers;

public class DbLogger: ILogger
{

    private readonly string _categoryName;

    public DbLogger(string categoryName )
    {

        this._categoryName = categoryName;
    }

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return default!;
    }


    public bool IsEnabled(LogLevel logLevel)
    {
        return logLevel >= LogLevel.Warning;
    }

    public async void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
     
        
         
        if (!IsEnabled(logLevel)) return;// do nothing if not enabled;

        
        try
        {
           
        }
        catch (Exception)
        {

        }
    }
}
