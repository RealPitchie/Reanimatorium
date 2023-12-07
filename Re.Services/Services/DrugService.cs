using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Re.Core.Models;
using Re.Data.Repo;
using Re.Services.Interfaces;

namespace Re.Services.Services
{
    public class DrugService : IDrugService
    {
        private readonly IRepo<Patient> _PatinetRepo = null!;
        private readonly IRepo<PrescribedMedication> _MedicationRepo = null!;
        private readonly IRepo<Syndrom> _SyndromRepo = null!;
        public DrugService(IRepo<Patient> PatientRepo)
        {
            _PatinetRepo = PatientRepo;
        }
        public DrugService(IRepo<PrescribedMedication> MeicationtRepo)
        {
            _MedicationRepo = MeicationtRepo;
        }
        public DrugService(IRepo<Syndrom> SyndromRepo)
        {
            _SyndromRepo = SyndromRepo;
        }
        public async Task<Patient> SavePatientAsync(Patient patient)
        {
            return await _PatinetRepo.SaveAsync(patient);
        }

        public async Task<PrescribedMedication> SaveMedicationAsync(PrescribedMedication medication)
        {
            return await _MedicationRepo.SaveAsync(medication);
        }

        public async Task<Syndrom> SaveSyndromAsync(Syndrom syndrom)
        {
            return await _SyndromRepo.SaveAsync(syndrom);
        }
    }
}