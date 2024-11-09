using BrighterShoresTools.Frontend.ViewModels;
using System.Windows;

namespace BrighterShoresTools.Frontend;

public partial class MainView : Window
{
    public MainView(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}