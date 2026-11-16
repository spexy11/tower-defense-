using CommunityToolkit.Mvvm.Messaging.Messages;
using TowerDefense.App.ViewModels;

namespace TowerDefense.App.Messages;

// Message envoyé par un écran pour demander d'afficher un autre écran.
public class NavigationMessage : ValueChangedMessage<ViewModelBase>
{
    public NavigationMessage(ViewModelBase viewModel) : base(viewModel)
    {
    }
}