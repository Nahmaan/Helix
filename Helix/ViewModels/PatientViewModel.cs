using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelixDataAccess.Models;

namespace Helix.ViewModels
{
    public class PatientViewModel
    {
        public string RecordId { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public string Age { get; set; }
        public Address Address { get; set; }
        public string HospitalNo { get; set; }
        public string NhsNo { get; set; }
        public string Clinician { get; set; }
        public string Source { get; set; }
        public string SampleDate { get; set; }
        public string RequestDate { get; set; }
        public string OrderNo { get; set; }
        public CerebroData CerebroData { get; set; }
    }
}
