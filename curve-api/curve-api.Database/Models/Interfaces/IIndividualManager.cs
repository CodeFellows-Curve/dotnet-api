using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Database.Models.Interfaces
{
    interface IIndividualManager
    {
        Task<Individual> GetIndividualByIndividualID(int id);

        Task<Individual> GetIndividualByName(string name);

        Task<List<Individual>> GetAllIndividuals();

        Task CreateIndividual(Individual individual);

        Task UpdateIndividual(Individual individual);

        Task DeleteIndividual(int id);
    }
}
