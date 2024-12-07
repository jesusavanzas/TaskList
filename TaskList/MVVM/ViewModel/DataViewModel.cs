using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TaskList.MVVM.Models;

namespace TaskList.MVVM.ViewModel
{
    public class DataViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Tarea> Tareas { get; set; } = new();

        private string? _nuevaTareaNombre;
        public string? NuevaTareaNombre
        {
            get => _nuevaTareaNombre;
            set
            {
                if (_nuevaTareaNombre != value)
                {
                    _nuevaTareaNombre = value;
                    OnPropertyChanged();
                }
            }
        }

        private Tarea? _tareaSeleccionada;
        public Tarea? TareaSeleccionada
        {
            get => _tareaSeleccionada;
            set
            {
                if (_tareaSeleccionada != value)
                {
                    _tareaSeleccionada = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand AgregarTareaCommand { get; }
        public ICommand EliminarTareaCommand { get; }
        public ICommand EditarTareaCommand { get; }
        public ICommand GuardarCambiosCommand { get; }

        public DataViewModel()
        {
            AgregarTareaCommand = new Command(AgregarTarea);
            EliminarTareaCommand = new Command(EliminarTarea);
            EditarTareaCommand = new Command(EditarTarea);
            GuardarCambiosCommand = new Command(GuardarCambios);
        }

        private void AgregarTarea()
        {
            if (!string.IsNullOrWhiteSpace(NuevaTareaNombre))
            {
                Tareas.Add(new Tarea { Nombre = NuevaTareaNombre, Completada = false });
                NuevaTareaNombre = string.Empty; 
            }
        }

        private void EliminarTarea()
        {
            if (TareaSeleccionada != null && Tareas.Contains(TareaSeleccionada))
            {
                Tareas.Remove(TareaSeleccionada);
                TareaSeleccionada = null; 
            }
        }

        private async void EditarTarea()
        {
            if (TareaSeleccionada != null)
            {
                await Shell.Current.GoToAsync("///PantallaDetalle");
            }
        }

        private async void GuardarCambios()
        {
            
            await Shell.Current.GoToAsync("///MainPage");
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


