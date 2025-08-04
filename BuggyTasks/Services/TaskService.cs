using System.Collections.ObjectModel;
using BuggyTasks.Models;

namespace BuggyTasks.Services;

public class TaskService
{
    public ObservableCollection<TaskItem> Tasks { get; } = new ObservableCollection<TaskItem>
    {
        new TaskItem { Title = "Test Task 1" },
        new TaskItem { Title = "Test Task 2" }
    };

    public void AddTask(string title)
    {
        if (!string.IsNullOrWhiteSpace(title))
            Tasks.Add(new TaskItem { Title = title });
    }
}