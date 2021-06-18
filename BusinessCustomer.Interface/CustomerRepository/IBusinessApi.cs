using BusinessCustomer.Infrastructure.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCustomer.Infrastructure.CustomerRepository
{
    /// <summary>
    /// Interface for Service api 
    /// </summary>
    public interface IBusinessApi
    {
        /// <summary>
        /// Gets list of Customer information by criteria : social reason + zip code
        /// </summary>
        /// <param name="socialReason"></param>
        /// <param name="zipCode"></param>
        /// <returns></returns>
        Task<List<CustomerMultipleSearchDto>> GetInfosByCriteria(string socialReason, string zipCode);

        /// <summary>
        /// Gets Customer information by criteria : id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CustomerSingleSearchDto> GetInfosById(string id);

        /// <summary>
        /// Gets Customer information by criteria : siret
        /// </summary>
        /// <param name="siret"></param>
        /// <returns></returns>
        Task<CustomerSingleSearchDto> GetInfosBySiret(string siret);
    }
}
