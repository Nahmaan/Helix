using System.IO;
using HelixDataAccess.Interfaces;
using HelixDataAccess.Models;
using Newtonsoft.Json;

namespace HelixDataAccess.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        public Patient GetPatientData()
        {
            using var reader = new StreamReader("data.json");
            var json = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<Patient>(json);
        }
    }
}
