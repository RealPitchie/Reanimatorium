using Microsoft.EntityFrameworkCore;
using Re.Core.Models;

namespace Re.Data.Repo
{
    public class DrugRepo : IRepo<Patient>, IRepo<Syndrom>, IRepo<PrescribedMedication>
    {
        DataContext _context;
        public DrugRepo(DataContext context)
        {
            _context = context;
        }

        public Task<List<Patient>> GetAsync()
        {
            throw new NotImplementedException();
        }
        public Task<List<Patient>> GetAsync(Type type)
        {
            throw new NotImplementedException();
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
 

        Task<List<Patient>> IRepo<Patient>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<List<Syndrom>> IRepo<Syndrom>.GetAsync(Type type)
        {
            throw new NotImplementedException();
        }

        Task<List<PrescribedMedication>> IRepo<PrescribedMedication>.GetAsync()
        {
            throw new NotImplementedException();
        }
        Task<List<PrescribedMedication>> IRepo<PrescribedMedication>.GetAsync(Type type)
        {
            throw new NotImplementedException();
        }

        Task<List<Syndrom>> IRepo<Syndrom>.GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
