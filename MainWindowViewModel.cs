using KB14388_XamDataChart_FormatLabel.Infrastructure;
using KB14388_XamDataChart_FormatLabel.Model;
using System.Collections.ObjectModel;

namespace KB14388_XamDataChart_FormatLabel;
internal class MainWindowViewModel : ObservableObject
{
    public ObservableCollection<EnergyProduction> EnergyProductions { get; set; }

    public MainWindowViewModel()
    {
        EnergyProductions = [
            new () { Year = 2010, SampleData = 0.58 },
            new () { Year = 2011, SampleData = 0.72 },
            new () { Year = 2012, SampleData = 0.90 },
            new () { Year = 2013, SampleData = 0.61 },
            new () { Year = 2014, SampleData = 0.53 },
            new () { Year = 2015, SampleData = 0.62 },
            new () { Year = 2016, SampleData = 0.77 },
            new () { Year = 2017, SampleData = 0.86 },
            new () { Year = 2018, SampleData = 0.72 },
            new () { Year = 2019, SampleData = 1.05 },
            new () { Year = 2020, SampleData = 1.01 },
            new () { Year = 2021, SampleData = 1.28 },
            new () { Year = 2022, SampleData = 1.32 },
            new () { Year = 2023, SampleData = 1.41 },
            new () { Year = 2024, SampleData = 1.25 },
        ];
    }
}