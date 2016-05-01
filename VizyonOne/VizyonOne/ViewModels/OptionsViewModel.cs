
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace VizyonOne.ViewModels
{
    public class OptionsViewModel : INotifyPropertyChanged
    {
        private string _title = "Options";
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

        #endregion

        public ICommand SayHelloCommand { get; set; }


        public OptionsViewModel()
        {
            Header = "Choose Your Options";

            SayHelloCommand = new Command(SayHello);
        }


        public void SayHello()
        {
            Header = string.Format("You got options!");
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
