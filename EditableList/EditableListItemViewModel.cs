using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ErisToolkit.Biomer.EditableList;

public partial class EditableListItemViewModel : ObservableObject
{
    [ObservableProperty] private string _name;
}
