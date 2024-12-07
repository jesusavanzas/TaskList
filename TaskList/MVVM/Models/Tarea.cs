using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TaskList.MVVM.Models
{
    public class Tarea : INotifyPropertyChanged
    {
        private string _nombre = string.Empty;
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _completada;
        public bool Completada
        {
            get => _completada;
            set
            {
                if (_completada != value)
                {
                    _completada = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
