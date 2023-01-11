using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MelonLoader.Installer.Next.Views;

public partial class AutoInstallView : UserControl
{
    public AutoInstallView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}