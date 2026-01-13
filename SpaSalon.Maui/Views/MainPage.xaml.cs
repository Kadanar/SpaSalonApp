using SpaSalon.Maui.ViewModels;

namespace SpaSalon.Maui.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
