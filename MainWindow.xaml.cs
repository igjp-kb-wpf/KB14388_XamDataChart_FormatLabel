using System.Windows;

namespace KB14388_XamDataChart_FormatLabel;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private string YAxis_FormatLabel(object sender, object item)
    {
        double value = (double)item;
        string unit;
        double displayValue;

        if (value >= 1)
        {
            unit = "m";
            displayValue = value;
        }
        else 
        {
            unit = "mm";
            displayValue = value * 1000;
        }

        return $"{displayValue} {unit}";
    }
}
