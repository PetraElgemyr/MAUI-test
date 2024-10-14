using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Shared.Models;
using System.Collections.ObjectModel;

namespace MainApp.MVVM.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<TodoItem> _todos = [];

    [ObservableProperty]
    private TodoItem _currentItem = new();


    [RelayCommand]
    public void Save()
    {
        try
        {
            if (!string.IsNullOrWhiteSpace(CurrentItem.TodoName))
            {
                Todos.Add(CurrentItem);

                CurrentItem = new TodoItem();   
            }
        }
        catch (Exception ex)
        {
        }
    }

    [RelayCommand]
    public void Delete(TodoItem item)
    {
        try
        {
            Todos.Remove(item);
        }
        catch (Exception ex)
        {
        }
    }

}
