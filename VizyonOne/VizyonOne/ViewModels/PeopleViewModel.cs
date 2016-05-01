using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VizyonOne.Models;
using VizyonOne.Views;
using Xamarin.Forms;

namespace VizyonOne.ViewModels
{
    public delegate void EventHandler();

    public class PeopleViewModel
    {
        private string _title = "People";
        public string Title { get { return _title; } }
        private string _version = "Version 1.0";
        public string Version { get { return _version; } }
        private string _Header = "What's Up People";
        public string Header { get { return _Header; } }

        public static event EventHandler _search;

        public ICommand SearchForPeopleCommand { get; set; }

        public ObservableCollection<Person> People = new ObservableCollection<Person>();
        // Holds a full list of all people, 
        // Binding to this list is displayed in the view
        // This is also what we search to get records in the list
        public ObservableCollection<Person> PeopleList = new ObservableCollection<Person>();

        #region Public Properties & Private Field Backers

        private bool _isBusy;
        public const string IsBusyPropertyName = "IsBusy";
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                _isNotBusy = !value;
                OnPropertyChanged(IsBusyPropertyName);
                OnPropertyChanged(IsNotBusyPropertyName);
            }
        }

        // This updates whenever IsBusy gets updated
        private bool _isNotBusy;
        public const string IsNotBusyPropertyName = "IsNotBusy";
        public bool IsNotBusy { get { return _isNotBusy; } }
        #endregion

        // The View Model        
        public PeopleViewModel()
        {
            // Return a list of people
            PeopleList = GetPeopleList();

            // Add Event Handler to show event
            //_search += new EventHandler(OnSearchTapped);

            Command SearchTappedCommand = new Command(OnSearchTapped);
        }

        private ObservableCollection<Person> GetPeopleList()
        {
            for (int i = 0; i < 10; i++)
            {
                People.Add(new Person
                {
                    PhotoOfPerson = "vizyon_logo.png",
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

            return People;
        }


        //public async Task<Person[]> SearchForPeople(string personProperty, string searchTerm)
        public void OnSearchTapped()
        {
            IsBusy = true;

            PeopleList.Clear();
            foreach (var item in People)
            {
                if (item.Name.ToLower().Equals("8 Name".ToLower()))
                {
                    PeopleList.Add(item);
                }
            }

            if (PeopleList == null)
            {
                PeopleList = People;
            }

            IsBusy = false;
        }

        public static void SearchForPerson()
        {
            // This is running
        }

        public class SearchButtonClicked : ICommand
        {
            public event System.EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                throw new NotImplementedException();
            }
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
