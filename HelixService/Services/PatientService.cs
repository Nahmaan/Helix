using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelixDataAccess.Interfaces;
using HelixDataAccess.Models;
using HelixDataAccess.Repositories;
using HelixService.Interfaces;

namespace HelixService.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository ?? new PatientRepository();
        }
        
        public Patient GetAllPatients()
        {
            return _patientRepository.GetPatientData();
        }
    }
}
