using CommunityToolkit.Mvvm.ComponentModel;
using BuggyTasks.Models;
using BuggyTasks.Services;
using System.Collections.ObjectModel;

namespace BuggyTasks.ViewModels;

public partial class TaskListViewModel : ObservableObject
{
    private readonly TaskService taskService;

    public ObservableCollection<TaskItem> Tasks => taskService.Tasks;

    public TaskListViewModel(TaskService service)
    {
        taskService = service;
    }
}