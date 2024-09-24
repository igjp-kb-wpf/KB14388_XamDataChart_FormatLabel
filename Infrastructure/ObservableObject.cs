using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KB14388_XamDataChart_FormatLabel.Infrastructure;
internal abstract class ObservableObject : INotifyPropertyChanged
{
    protected ObservableObject()
    {
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] String? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}