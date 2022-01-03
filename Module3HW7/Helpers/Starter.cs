using Microsoft.Extensions.DependencyInjection;
using Module3HW7.Services;
using Module3HW7.Services.Abstractions;

namespace Module3HW7.Helpers
{
    public class Starter
    {
        public void Run()
        {
            var starter = new ServiceCollection()
                .AddSingleton<ILoggerService, LoggerService>()
                .AddSingleton<IBackupService, BackupService>()
                .AddSingleton<IFileService, FileService>()
                .AddSingleton<IJsonService, JsonService>()
                .AddSingleton<IConfigService, ConfigService>()
                .AddScoped<Application>()
                .BuildServiceProvider();
            var app = starter.GetService<Application>();
            app.Run();
            starter.Dispose();
        }
    }
}
