using BrighterShoresTools.Frontend.ViewModels;
using System.Windows;
using System.Windows.Controls;

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
}