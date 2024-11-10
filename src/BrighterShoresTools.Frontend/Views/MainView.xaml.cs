using BrighterShoresTools.Frontend.ViewModels;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace BrighterShoresTools.Frontend;

public partial class MainView : Window
{
    public MainView(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }

    private void TextBox_GotFocus(object sender, RoutedEventArgs e)
    {
        SelectAll(sender);
    }

    private void SelectAll(object sender)
    {
        if (sender is not TextBox tb)
        {
            return;
        }

        tb.SelectAll();
    }

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        Process.Start(new ProcessStartInfo()
        {
            UseShellExecute = true,
            FileName = e.Uri.AbsoluteUri,
        });

        e.Handled = true;
    }
}