using CommunityToolkit.Mvvm.Messaging;

namespace TowerDefense.App.ViewModels;

// Logique de l'écran de menu principal.
public partial class MenuViewModel : ViewModelBase
{
    private readonly IMessenger _messenger;

    public string Title => "Tower Defense";

    public MenuViewModel(IMessenger messenger)
    {
        _messenger = messenger;
    }
}