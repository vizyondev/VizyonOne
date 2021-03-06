﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizyonOne.Models
{
    public class Child
    {
        private const string _nameOfDefaultRecord = "Child";
        private const string _typeOfParentRecord = "Parent";

        public string MetaDataForRecord { get; set; }
        public string PrimaryHiddenIdForRecord { get; set; }
        public string IdForRecord { get; set; }
        public string IdOfParentRecord { get; set; }

        public string NameOfDefaultRecord { get { return _nameOfDefaultRecord; } }
        public string NameOfThisRecord { get; set; }
        public string NumberOfChildren { get; set; }
        public string NumberOfStuff { get; set; }

        public bool IsRecordABarcode { get; set; }
        public bool IsRecordAnRfid { get; set; }
        public bool IsRecordDeleted { get; set; }
        public bool IsRecordRestoredFromDelete { get; set; }
        public bool IsRecordVisible { get; set; }
        public bool IsRecordAParent { get; set; }
        public bool IsRecordAChild { get; set; }
        public bool IsRecordAGrandChild { get; set; }
        public bool IsRecordAGreatGrandChild { get; set; }
        public bool IsRecordAGreatGreatGrandChild { get; set; }
    }
}
