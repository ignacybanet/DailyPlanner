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

    private void DeleteTask1(object? sender, RoutedEventArgs e)
    {
        DisplayTaskName1.IsVisible = false;
        PlannerComboBox1.IsVisible = false;
        PlannerCheckbox1.IsVisible = false;
        PlannerButton1.IsVisible = false;
    }

    private void DeleteTask2(object? sender, RoutedEventArgs e)
    {
        DisplayTaskName2.IsVisible = false;
        PlannerComboBox2.IsVisible = false;
        PlannerCheckbox2.IsVisible = false;
        PlannerButton2.IsVisible = false;
    }

    private void DeleteTask3(object? sender, RoutedEventArgs e)
    {
        DisplayTaskName3.IsVisible = false;
        PlannerComboBox3.IsVisible = false;
        PlannerCheckbox3.IsVisible = false;
        PlannerButton3.IsVisible = false;
    }

    private void DeleteTask4(object? sender, RoutedEventArgs e)
    {
        DisplayTaskName4.IsVisible = false;
        PlannerComboBox4.IsVisible = false;
        PlannerCheckbox4.IsVisible = false;
        PlannerButton4.IsVisible = false;
    }

    int SelectedCount = 0;
    
    private void OnCheck1(object? sender, RoutedEventArgs e)
    { 
        SelectedCount++;
        CompletedTasks.Text = SelectedCount.ToString();
    }
    private void OnCheck2(object? sender, RoutedEventArgs e)
    {
        SelectedCount++;
        CompletedTasks.Text = SelectedCount.ToString();
    }
    private void OnCheck3(object? sender, RoutedEventArgs e)
    {
        SelectedCount++;
        CompletedTasks.Text = SelectedCount.ToString();
    }
    private void OnCheck4(object? sender, RoutedEventArgs e)
    {
        SelectedCount++;
        CompletedTasks.Text = SelectedCount.ToString();
    }
    
    
    private void OnUncheck1(object? sender, RoutedEventArgs e)
    {
        SelectedCount--;
        CompletedTasks.Text = SelectedCount.ToString();
    }
    private void OnUncheck2(object? sender, RoutedEventArgs e)
    {
        SelectedCount--;
        CompletedTasks.Text = SelectedCount.ToString();
    }
    private void OnUncheck3(object? sender, RoutedEventArgs e)
    {
        SelectedCount--;
        CompletedTasks.Text = SelectedCount.ToString();
    }
    private void OnUncheck4(object? sender, RoutedEventArgs e)
    {
        SelectedCount--;
        CompletedTasks.Text = SelectedCount.ToString();
    }
}