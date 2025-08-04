using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BuggyTasks.ViewModels;

namespace BuggyTasks.Views;

public partial class TaskListPage : ContentPage
{
    public TaskListPage(TaskListViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}