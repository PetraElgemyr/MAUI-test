using MainApp.Models;
using System.Collections.ObjectModel;

namespace MainApp;

public partial class MainPage : ContentPage
{
    private ObservableCollection<TodoItem> _todos = [];
    public MainPage()
    {
        InitializeComponent();
        CvTodos.ItemsSource = _todos;
    }

    private void BtnSave_Clicked(object sender, EventArgs e)
    {

        try
        {
            if (!string.IsNullOrWhiteSpace(InputTodo.Text))
            {
                _todos.Add(new TodoItem { TodoName = InputTodo.Text });
                InputTodo.Text = "";
            }
        }
        catch (Exception ex) { }

    }

    private void BtnDelete_Clicked(object sender, EventArgs e)
    {
        try
        {
            var button = (Button)sender;
            var context = button.BindingContext;
            var todoItem = (TodoItem)context;
            _todos.Remove(todoItem);
        }
        catch (Exception ex)
        { }
    }
}
