using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ToDoApp2.ViewModel
{
    class LoginViewModel : BaseViewModel
    {
        private string _username;
        public string Username {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    LoginCommand.ChangeCanExecute();
                }
            }
        }

        private string _password;
        public string Password {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    LoginCommand.ChangeCanExecute();
                }
            }
        }


        public Command LoginCommand;

        public LoginViewModel()
        {
            LoginCommand = new Command(LoginExecute, CanLogin);
        }

        private bool CanLogin()
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }

        private void LoginExecute()
        {

        }
    }
}
