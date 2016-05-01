using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using VizyonOne.Views;
using Xamarin.Forms;

namespace VizyonOne.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _title = "Vizyon Login";
        public string Title { get { return _title; } }
        private string _version = "Version 1.0";
        public string Version { get { return _version; } }

        #region Public Properties & Private Field Backers
        private string _Header;
        public const string HeaderPropertyName = "Header";
        public string Header
        {
            get { return _Header; }
            set
            {
                _Header = value;
                OnPropertyChanged(HeaderPropertyName);
            }
        }

        private string _emailAddress;
        public const string EmailAddressPropertyName = "EmailAddress";
        public string EmailAddress
        {
            get { return _emailAddress; }
            set
            {
                _emailAddress = value;
                OnPropertyChanged(EmailAddressPropertyName);
            }
        }

        private string _password;
        public const string PasswordPropertyName = "Password";
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(PasswordPropertyName);
            }
        }

        private bool _isBusy;
        public const string IsBusyPropertyName = "IsBusy";
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged(IsBusyPropertyName);
                OnPropertyChanged(IsNotBusyPropertyName);
            }
        }

        // This updates whenever IsBusy gets updated
        private bool _isNotBusy;
        public const string IsNotBusyPropertyName = "IsNotBusy";
        public bool IsNotBusy { get { return !IsBusy; } }
        #endregion

        public ICommand SayHelloCommand { get; set; }
        public ICommand GetWidgetCommand { get; set; }


        public LoginViewModel()
        {
            Header = "Vizyon Welcomes You!";
            EmailAddress = "email@email.com";
            Password = "password";

            SayHelloCommand = new Command(SayHello);
            GetWidgetCommand = new Command(GetWidget);
        }

        public void SayHello()
        {
            Header = string.Format("Hi {0}, welcome to Vizyon Mobile!", EmailAddress);
        }

        public async void GetWidget()
        {
            IsBusy = true;
            await Task.Delay(3000);
            IsBusy = false;
        }


        #region INotifyPropertyChanged
        // When a property has changed raise the PropertyChanged event and pass in the property as a parameter
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // All controls will subscribe to this event handler
        public event PropertyChangedEventHandler PropertyChanged; 
        #endregion
    }
}
