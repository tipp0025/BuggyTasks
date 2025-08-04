using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using BuggyTasks.Services;

namespace BuggyTasks.ViewModels;

public partial class NewTaskViewModel : ObservableObject
{
    [ObservableProperty]
    string newTaskTitle = string.Empty;

    private readonly TaskService taskService;

    public NewTaskViewModel(TaskService service)
    {
        taskService = service;
    }

    [RelayCommand]
    void AddTask()
    {
        taskService.AddTask(NewTaskTitle);
        NewTaskTitle = string.Empty; // clear input
    }
}