using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helix.ViewModels;
using HelixService.Interfaces;

namespace Helix.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IPatientService _patientService;

        public HomeController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        public IActionResult Index()
        {
            var patient = _patientService.GetAllPatients();
            //Add patient data to view model to show age.
            PatientViewModel model;
            if (patient == null)
                model = new PatientViewModel();
            

            model = new PatientViewModel
            {
                RecordId = patient.RecordId,
                Forename = patient.Forename,
                Surname = patient.Surname,
                DateOfBirth = patient.DateOfBirth,
                Age = CalculateAge(patient.DateOfBirth),
                Address = patient.Address,
                HospitalNo = patient.HospitalNo,
                NhsNo = patient.NhsNo,
                Clinician = patient.Clinician,
                Source = patient.Source,
                SampleDate = patient.SampleDate,
                RequestDate = patient.RequestDate,
                OrderNo = patient.OrderNo,
                CerebroData = patient.CerebroData
            };
            

            return View(model);
        }

        private string CalculateAge(string dob)
        {
            if (string.IsNullOrEmpty(dob))
                return string.Empty;

            var dateOfBirth = DateTime.Parse(dob);
            var age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.Year < dateOfBirth.DayOfYear)
                age -= 1;

            return age.ToString();
        }
    }
}
