using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    class LoginViewModel: INotifyPropertyChanged
    {
        public Command SignInCommand { get; set; }
        private string username;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string UserName
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged("UserName");
            }
        }


        public LoginViewModel()
        {
            SignInCommand = new Command(SignIn);
        }

        private void SignIn(object obj)
        {
            var user = UserName;
        }

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
