using System.ComponentModel;
using System.Runtime.CompilerServices;
using TecnologicoApp.Model;

namespace TecnologicoApp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        #region "Properties"

        public UsuarioRegistro Usuario { get; set; }

        public Command LoginCommand { get; set; }

        #endregion

        public MainPageViewModel()
        {
            LoginCommand = new Command(Login);
        }

        #region "Logic"

        private void Login()
        {
            // implement your logic here
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
