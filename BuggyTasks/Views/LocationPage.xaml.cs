using Microsoft.Maui.Controls;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Devices.Sensors;

namespace BuggyTasks.Views;

public partial class LocationPage : ContentPage
{
    public LocationPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await GetLocation();
    }

    async Task GetLocation()
    {
        try
        {
            var location = await Geolocation.GetLastKnownLocationAsync();

            if (location != null)
            {
                LatLabel.Text = $"Latitude: {location.Latitude}";
                LongLabel.Text = $"Longitude: {location.Longitude}";
            }
            else
            {
                LatLabel.Text = "Latitude: (not available)";
                LongLabel.Text = "Longitude: (not available)";
            }
        }
        catch (Exception ex)
        {
            LatLabel.Text = "Error retrieving location";
            LongLabel.Text = ex.Message;
        }
    }
}