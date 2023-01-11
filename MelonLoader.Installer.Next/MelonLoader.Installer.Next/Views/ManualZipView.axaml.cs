using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MelonLoader.Installer.Next.Views;

public partial class ManualZipView : UserControl
{
    public ManualZipView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}