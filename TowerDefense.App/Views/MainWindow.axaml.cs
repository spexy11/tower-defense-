using Avalonia.Controls;
using CommunityToolkit.Mvvm.Messaging;
using TowerDefense.App.ViewModels;

namespace TowerDefense.App.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        DataContext = new MainWindowViewModel(WeakReferenceMessenger.Default);
    }
}