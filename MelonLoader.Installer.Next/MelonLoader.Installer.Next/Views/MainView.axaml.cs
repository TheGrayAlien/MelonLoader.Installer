using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.Themes.Fluent;
using DynamicData.Binding;
using MelonLoader.Installer.Next.Classes;
using MelonLoader.Installer.Next.ViewModels;

namespace MelonLoader.Installer.Next.Views;

public partial class MainView : UserControl
{
    public static MainView Instance { get; private set; } = null!;
    public MainView()
    {
        InitializeComponent();
        Instance = this;
        Background = SettingsView.IsDark ? MainViewModel.Black : MainViewModel.White;
    }

    private void JoinDiscordClicked(object? sender, PointerReleasedEventArgs e) => Utils.OpenUrl(MainViewModel.DiscordLink);
    private void FollowTwitterClicked(object? sender, PointerReleasedEventArgs e) => Utils.OpenUrl(MainViewModel.TwitterLink);
    private void OpenGithubClicked(object? sender, PointerReleasedEventArgs e) => Utils.OpenUrl(MainViewModel.GithubLink);
    private void ReadWikiClicked(object? sender, PointerReleasedEventArgs e) => Utils.OpenUrl(MainViewModel.WikiLink);

    private void HandleButton(object? sender, RoutedEventArgs e)
    {
        if (sender is not Button button) return;

        switch (button.Content as string)
        {
            case "Automated":
                PageContent.Content = MainViewModel.AutoInstallPage;
                AutoInstallBorder.Background = MainViewModel.Red;
                ManualInstallBorder.Background = Brushes.Gray;
                SettingsBorder.Background = Brushes.Gray;
                break;
            case "Manual Zip":
                PageContent.Content = MainViewModel.ManualInstallPage;
                ManualInstallBorder.Background = MainViewModel.Red;
                AutoInstallBorder.Background = Brushes.Gray;
                SettingsBorder.Background = Brushes.Gray;
                break;
            case "Settings":
                PageContent.Content = MainViewModel.SettingsPage;
                SettingsBorder.Background = MainViewModel.Red;
                AutoInstallBorder.Background = Brushes.Gray;
                ManualInstallBorder.Background = Brushes.Gray;
                break;
        }
    }
}