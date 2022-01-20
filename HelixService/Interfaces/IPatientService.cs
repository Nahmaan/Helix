using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelixDataAccess.Models;

namespace HelixService.Interfaces
{
    public interface IPatientService
    {
        Patient GetAllPatients();
    }
}
