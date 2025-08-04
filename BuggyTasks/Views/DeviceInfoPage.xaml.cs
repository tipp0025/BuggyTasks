using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace BuggyTasks.Views;

public partial class DeviceInfoPage : ContentPage
{
    public DeviceInfoPage()
    {
        InitializeComponent();

        // Get device info
        string model = DeviceInfo.Model;
        string platform = DeviceInfo.Platform.ToString();

        // Display it in the UI
        ModelLabel.Text = $"Model: {model}";
        PlatformLabel.Text = $"Platform: {platform}";
    }
}