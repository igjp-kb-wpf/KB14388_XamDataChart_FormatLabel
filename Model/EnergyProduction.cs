using KB14388_XamDataChart_FormatLabel.Infrastructure;

namespace KB14388_XamDataChart_FormatLabel.Model;
internal class EnergyProduction : ObservableObject
{
    private int _year;
    public int Year
    {
        get { return _year; }
        set
        {
            _year = value;
            OnPropertyChanged();
        }
    }
    private double _sampleData;
    public double SampleData
    {
        get { return _sampleData; }
        set
        {
            _sampleData = value;
            OnPropertyChanged();
        }
    }
    public EnergyProduction()
    {
    }
}