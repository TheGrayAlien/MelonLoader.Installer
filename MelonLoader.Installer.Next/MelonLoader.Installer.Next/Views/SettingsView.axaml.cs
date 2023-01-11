using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using MelonLoader.Installer.Next.ViewModels;

namespace MelonLoader.Installer.Next.Views;

public partial class SettingsView : UserControl
{
    public SettingsView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public static bool IsDark = true;
    
    private void ThemeBoxChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (sender is not ComboBox { SelectedItem: ComboBoxItem { Content: string theme } })
            return;
        
        var assets = AvaloniaLocator.Current.GetService<IAssetLoader>();


        switch (theme)
        {
            case "Light":
                IsDark = false;
                App.ThemeManager?.Switch(0);
                MainView.Instance.GithubImage.Source = new Bitmap(assets.Open(new Uri("avares://MelonLoader.Installer.Next/Assets/GitHub_Light.png")));
                MainView.Instance.Background = MainViewModel.White;
                break;
            case "Dark":
                IsDark = true;
                App.ThemeManager?.Switch(1);
                MainView.Instance.GithubImage.Source = new Bitmap(assets.Open(new Uri("avares://MelonLoader.Installer.Next/Assets/GitHub_Dark.png")));
                MainView.Instance.Background = MainViewModel.Black;
                break;
        }
    }
}