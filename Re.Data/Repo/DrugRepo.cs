using Re.Core.Models;

namespace Re.Data.Repo
{
    internal class DrugRepo : IRepo<Patient>, IRepo<Syndrom>, IRepo<PrescribedMedication>
    {
        DataContext _context;
        public DrugRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<Patient> SaveAsync(Patient patient)
        {
            await _context.Patients.AddAsync(patient);
            await _context.SaveChangesAsync();

            return patient;
        }

        public async Task<Syndrom> SaveAsync(Syndrom syndrom)
        {
            await _context.Syndroms.AddAsync(syndrom);
            await _context.SaveChangesAsync();

            return syndrom;
        }

        public async Task<PrescribedMedication> SaveAsync(PrescribedMedication medication)
        {
            await _context.Medications.AddAsync(medication);
            await _context.SaveChangesAsync();

            return medication;
        }
    }
}
