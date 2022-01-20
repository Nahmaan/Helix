using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HelixDataAccess.Models
{
    public class Patient
    {
        [JsonProperty("RecordId")]
        public string RecordId { get; set; }
        [JsonProperty("Forename")]
        public string Forename { get; set; }
        [JsonProperty("Surname")]
        public string Surname { get; set; }
        [JsonProperty("DateOfBirth")]
        public string DateOfBirth { get; set; }
        [JsonProperty("Address")]
        public Address Address { get; set; }
        [JsonProperty("HospitalNo")]
        public string HospitalNo { get; set; }
        [JsonProperty("NhsNo")]
        public string NhsNo { get; set; }
        [JsonProperty("Clinician")]
        public string Clinician { get; set; }
        [JsonProperty("Source")]
        public string Source { get; set; }
        [JsonProperty("SampleDate")]
        public string SampleDate { get; set; }
        [JsonProperty("RequestDate")]
        public string RequestDate { get; set; }
        [JsonProperty("OrderNo")]
        public string OrderNo { get; set; }
        [JsonProperty("CerebroData")]
        public CerebroData CerebroData { get; set; }
    }
}
