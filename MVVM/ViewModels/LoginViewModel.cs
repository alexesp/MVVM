using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVM.ViewModels
{
    //Sin community toolkit----------------------------------------------
    // class LoginViewModel: INotifyPropertyChanged
    //Con community toolkit -------------------------------------------------
    internal partial class LoginViewModel : ObservableObject
    {
        //Con community toolkit -------------------------------------------------
        [ObservableProperty]
        string username;
        [RelayCommand]
        private void Login()
        {
           
        }


        //Sin community toolkit----------------------------------------------

        //public Command SignInCommand { get; set; }
        //private string username;

        //public event PropertyChangedEventHandler? PropertyChanged;

        //public string UserName
        //{
        //    get { return username; }
        //    set
        //    {
        //        username = value;
        //        OnPropertyChanged("UserName");
        //    }
        //}
        //public LoginViewModel()
        //{
        //    SignInCommand = new Command(SignIn);
        //}
        //private void SignIn(object obj)
        //{
        //    var user = UserName;
        //}
        //void OnPropertyChanged(string name)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}




    }
}
