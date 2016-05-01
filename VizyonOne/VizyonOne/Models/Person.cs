using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizyonOne.Models
{
    public class Person
    {
        private const string _nameOfDefaultRecord = "Person";
        private const string _typeOfParentRecord = null;

        public string MetaDataForRecord { get; set; }
        public string PrimaryHiddenIdForRecord { get; set; }
        public string IdForRecord { get; set; }
        public string IdOfParentRecord { get; set; }

        public string NameOfDefaultRecord { get { return _nameOfDefaultRecord; } }
        public string NameOfThisRecord { get; set; }
        public string NumberOfChildren { get; set; }
        public string NumberOfStuff { get; set; }
        public string Status { get; set; }
        // ListView stuff to display
        public string Id { get; set; }
        public string PhotoOfPerson { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string Assignments { get; set; }
        public string Role { get; set; }
        public string DeviceAssignment { get; set; }// PPC Assignment
        public string GroupAssignment { get; set; }// Shared Assignment
        public string UserAssignment { get; set; }

        public string DateOfBirth { get; set; }
        public string AddressStreet { get; set; }
        public string AddressPoBox { get; set; }
        public string AddressCity { get; set; }
        public string AddressCounty { get; set; }
        public string AddressState { get; set; }
        public string AddressZip { get; set; }
        public string TimeZone { get; set; }
        public string HireDate { get; set; }
        public string WorkShiftSchedule { get; set; } // Availability
        public string StartWorkTime { get; set; }
        public string BreakStartTime { get; set; }
        public string BreakEndTime { get; set; }
        public string StopTime { get; set; }
        public string HoursWorkedThisWeek { get; set; }
        public string HoursWorkedThisMonth { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string OtherPhone { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string EmailPrimary { get; set; }
        public string EmailSecondary { get; set; }
        public string MyManagerPrimary { get; set; }
        public string MyManagerSecondary { get; set; }
        // true or false
        public string IsRecordABarcode { get; set; }
        public string IsRecordAnRfid { get; set; }
        public string IsRecordDeleted { get; set; }
        public string IsRecordRestoredFromDelete { get; set; }
        public string IsRecordVisible { get; set; }
        public string IsRecordAParent { get; set; }
        public string IsRecordAChild { get; set; }
        public string IsRecordAGrandChild { get; set; }
        public string IsRecordAGreatGrandChild { get; set; }
        public string IsRecordAGreatGreatGrandChild { get; set; }

        public List<string> Links { get; set; }
        public List<string> Notes { get; set; }
        public List<string> Documents { get; set; }
        public List<string> Procedures { get; set; }
        public List<string> OtherStuff { get; set; }
    }
}
