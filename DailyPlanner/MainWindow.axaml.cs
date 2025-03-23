using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace DailyPlanner;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnSubmit(object? sender, RoutedEventArgs e)
    {
        int taskNumber = Convert.ToInt32(InputNumerZadaniaDoEdycji.Text);

        switch (taskNumber)
        {
            case 1:
                DisplayTaskName1.Text = InputNazwaZadania.Text;
                break;
            case 2:
                DisplayTaskName2.Text = InputNazwaZadania.Text;
                break;
            case 3:
                DisplayTaskName3.Text = InputNazwaZadania.Text;
                break;
            case 4:
                DisplayTaskName4.Text = InputNazwaZadania.Text;
                break;
        }
    }
}