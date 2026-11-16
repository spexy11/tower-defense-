using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using TowerDefense.App.Messages;

namespace TowerDefense.App.ViewModels;

// Décide quel écran est affiché dans la fenêtre principale.
public partial class MainWindowViewModel : ViewModelBase, IRecipient<NavigationMessage>
{
    [ObservableProperty]
    private ViewModelBase _currentViewModel;

    public MainWindowViewModel(IMessenger messenger)
    {
        messenger.Register<NavigationMessage>(this); // s'abonner aux messages de navigation
        _currentViewModel = new MenuViewModel(messenger); // écran de départ
    }

    // Appelée automatiquement quand un écran envoie un NavigationMessage.
    public void Receive(NavigationMessage message)
    {
        CurrentViewModel = message.Value;
    }
}