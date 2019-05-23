using curve_api.Data;
using curve_api.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Models.Services
{
    public class IndividualService : IIndividualManager
    {
        private readonly CurveDBContext _context;

        public IndividualService(CurveDBContext context)
        {
            _context = context;
        }

        public async Task<Individual> CreateIndividual(Individual individual)
        {
            _context.Add(individual);
            await _context.SaveChangesAsync();
            return individual;
        }

        public async Task DeleteIndividual(int id)
        {
            Individual ind = await _context.Individuals.FindAsync(id);
            if (ind != null)
            {
                _context.Remove(ind);
                _context.SaveChanges();
            }
        }

        public async Task<List<Individual>> GetAllIndividuals()
        {
            return await _context.Individuals.ToListAsync();
        }

        public async Task<Individual> GetIndividualByIndividualID(int id)
        {
            return await _context.Individuals.FindAsync(id);
        }

        public async Task<Individual> GetIndividualByName(string name)
        {
            return await _context.Individuals.Where(ind => ind.Name == name).FirstOrDefaultAsync();
        }

        public async Task<Individual> UpdateIndividual(Individual individual)
        {
            _context.Update(individual);
            await _context.SaveChangesAsync();
            return individual;
        }
    }
}
