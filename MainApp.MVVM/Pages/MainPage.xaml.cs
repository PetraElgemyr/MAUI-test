using MainApp.MVVM.ViewModels;

namespace MainApp.MVVM.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}