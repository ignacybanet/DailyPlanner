using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace DailyPlanner;


public partial class MainWindow : Window
{
    List<Zadanie> listaZadan = new ();
    
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnSubmit(object? sender, RoutedEventArgs e)
    {
        var noweZadanie = new Zadanie(InputTaskName.Text, "feefwf");
    }
}