using TaskList.MVVM.ViewModel;

namespace TaskList.MVVM.Views;

public partial class MainPage : ContentPage
{
    public MainPage(DataViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
