using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace curve_api.Models.Interfaces
{
    public interface IIndividualManager
    {
        Task<Individual> GetIndividualByIndividualID(int id);

        Task<Individual> GetIndividualByName(string name);

        Task<Individual> GetIndividualByEmail(string email);

        Task<List<Individual>> GetAllIndividuals();

        Task<Individual> CreateIndividual(Individual individual);

        Task<Individual> UpdateIndividual(Individual individual);

        // TODO: Find out and impliment the return type that GraphQL needs for delete mutation
        Task DeleteIndividual(int id);
    }
}
