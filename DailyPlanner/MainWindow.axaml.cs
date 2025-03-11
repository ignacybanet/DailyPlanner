using Avalonia.Controls;

namespace DailyPlanner;

class Zadanie
{
    public Zadanie()
    {
        string Nazwa;
        string Kategoria;
        bool CzyUkonczone;
    }
}

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
}