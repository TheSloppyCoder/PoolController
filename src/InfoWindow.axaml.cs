using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace PoolController;

public partial class InfoWindow : Window
{
    public InfoWindow()
    {
        InitializeComponent();
    }

    private void BtnInfoExit_OnClick(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}