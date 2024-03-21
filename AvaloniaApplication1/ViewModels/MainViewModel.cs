using System;

namespace AvaloniaApplication1.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    public TimeSpan Time => TimeSpan.FromMilliseconds(10);
}
