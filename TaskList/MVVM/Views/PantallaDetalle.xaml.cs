using TaskList.MVVM.ViewModel;

namespace TaskList.MVVM.Views;

public partial class PantallaDetalle : ContentPage
{
    public PantallaDetalle(DataViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}


