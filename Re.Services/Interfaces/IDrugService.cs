using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Re.Core.Models;

namespace Re.Services.Interfaces
{
    public interface IDrugService
    { 
        Task<Patient> SavePatientAsync(Patient patient);
        Task<PrescribedMedication> SaveMedicationAsync(PrescribedMedication medication);
        Task<Syndrom> SaveSyndromAsync(Syndrom syndrom);
        Task<List<Patient>> GetAllPatientsAsync();
        Task<List<Syndrom>> GetAllSyndromAsync();
        Task<List<PrescribedMedication>> GetAllMedicationAsync();
        IEnumerable<string> GetPropertyPatientNames();
        IEnumerable<string> GetPropertyMedicationNames();
        IEnumerable<string> GetPropertySyndromNames();
    }
}