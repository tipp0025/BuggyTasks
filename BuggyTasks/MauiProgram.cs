using BuggyTasks.Services;
using BuggyTasks.ViewModels;
using Microsoft.Extensions.Logging;

namespace BuggyTasks;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        
        builder.Services.AddSingleton<TaskService>();
        builder.Services.AddTransient<TaskListViewModel>();
        builder.Services.AddTransient<NewTaskViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}