using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using VizyonOne.Models;
using Xamarin.Forms;

namespace VizyonOne.ViewModels
{
    public class ProgressViewModel
    {
    private string _title = "Progress";
    public string Title { get { return _title; } }
    private string _version = "Version 1.0";
    public string Version { get { return _version; } }
    private string _Header = "Vizyon";
    public string Header { get { return _Header; } }

    #region Public Properties & Private Field Backers

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


    public List<Person> People { get; set; }

    public ICommand SavePersonCommand { get; set; }

    public ProgressViewModel()
    {
        #region Add People

        People = new List<Person>();
        for (int i = 0; i < 10000; i++)
        {
            People.Add(new Person
            {
                Name = $"{i} Name",
                Password = $"{i} Password",
                Title = $"{i} Title",
                Language = $"{i} Language",
                AddressStreet = $"{i} AddressStreet",
                AddressPoBox = $"{i} AddressPoBox",
                AddressCity = $"{i} AddressCity",
                AddressCounty = $"{i} AddressCounty",
                AddressState = $"{i} AddressState",
                AddressZip = $"{i} AddressZip",
                TimeZone = $"{i} TimeZone",
                HireDate = $"{i} HireDate"
            });
        }
                    
        #endregion

        SavePersonCommand = new Command(SavePerson);
    }

        public void SavePerson()
    {

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
