using CommunityToolkit.Mvvm.ComponentModel;

namespace Foreweather.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string _greeting = "Welcome to Avalonia!";
}