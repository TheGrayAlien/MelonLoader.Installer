using Avalonia.Controls;
using Avalonia.Media;
using MelonLoader.Installer.Next.Views;

namespace MelonLoader.Installer.Next.ViewModels;

public class MainViewModel : ViewModelBase
{
    #region Links
    
    public static string DiscordLink => "https://discord.gg/2Wn3N2P";
    public static string TwitterLink => "https://twitter.com/lava_gang";
    public static string GithubLink => "https://github.com/LavaGang";
    public static string WikiLink => "https://melonwiki.xyz";
    public static string UpdateLink => "https://github.com/LavaGang/MelonLoader.Installer/releases/latest";
    
    #endregion
    
    #region Properties
    public static string JoinDiscord => "Join the MelonLoader Discord";
    public static string FollowTwitter => "Follow LavaGang on Twitter";
    public static string CheckGithub => "Check out our Github";
    public static string CheckWiki => "Read the MelonLoader Wiki";
    
    #endregion

    #region Pages

    public static UserControl AutoInstallPage => new AutoInstallView();
    
    public static UserControl ManualInstallPage => new ManualZipView();

    public static UserControl SettingsPage => new SettingsView();

    #endregion
    
    #region Colors
    
    public static SolidColorBrush White => new SolidColorBrush(Color.FromRgb(255, 255, 255));
    public static SolidColorBrush Black => new SolidColorBrush(Color.FromRgb(20, 20, 20));
    public static SolidColorBrush Green => new SolidColorBrush(Color.FromRgb(120, 248, 99));
    public static SolidColorBrush Red => new SolidColorBrush(Color.FromRgb(250, 69, 112));
    
    #endregion
}