using Avalonia.Controls;
using Avalonia.Interactivity;

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

    private void OnSubmit(object? sender, RoutedEventArgs e)
    {
        DisplayTaskName.Text = InputTaskName.Text;
    }
}