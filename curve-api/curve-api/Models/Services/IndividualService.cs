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

        /// <summary>
        /// Creates an Individual Entity in the database.
        /// </summary>
        /// <param name="individual">The Individual being added</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task<Individual> CreateIndividual(Individual individual)
        {
            _context.Add(individual);
            await _context.SaveChangesAsync();
            return individual;
        }

        /// <summary>
        /// Deletes an Individual Entity from the database.
        /// </summary>
        /// <param name="id">The id of the Individual being deleted</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task DeleteIndividual(int id)
        {
            Individual ind = await _context.Individuals.FindAsync(id);
            if (ind != null)
            {
                _context.Remove(ind);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Gets all Individuals in the database
        /// </summary>
        /// <returns>A List of all Individuals in the database</returns>
        public async Task<List<Individual>> GetAllIndividuals()
        {
            return await _context.Individuals.ToListAsync();
        }

        /// <summary>
        /// Gets Individual by individual Email
        /// </summary>
        /// <param name="email">The email of the given individual</param>
        /// <returns>An Individual Entity</returns>
        public async Task<Individual> GetIndividualByEmail(string email)
        {
            return await _context.Individuals.FindAsync(email);
        }

        /// <summary>
        /// Gets Individual by individual Id
        /// </summary>
        /// <param name="id">The id of the given individual</param>
        /// <returns>An Individual Entity</returns>
        public async Task<Individual> GetIndividualByIndividualID(int id)
        {
            return await _context.Individuals.FindAsync(id);
        }

        /// <summary>
        /// Gets Individual by name
        /// </summary>
        /// <param name="name">the name of the given Individual</param>
        /// <returns>An Individual Entity</returns>
        public async Task<Individual> GetIndividualByName(string name)
        {
            return await _context.Individuals.Where(ind => ind.Name == name).FirstOrDefaultAsync();
        }
        
        // <summary>
        /// Updates a specific Individual Entity in the database
        /// </summary>
        /// <param name="individual">The Individual being updated</param>
        /// <returns>An Asynchronous Task</returns>
        public async Task<Individual> UpdateIndividual(Individual individual)
        {
            _context.Update(individual);
            await _context.SaveChangesAsync();
            return individual;
        }
    }
}
