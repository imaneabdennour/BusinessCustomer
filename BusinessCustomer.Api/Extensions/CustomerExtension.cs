using BusinessCustomer.Api.ViewModels;
using BusinessCustomer.Infrastructure.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace BusinessCustomer.Api.Extensions
{
    public static class CustomerExtension
    {
        /// <summary>
        /// Converts from DTO to ViewModel - for single search
        /// </summary>
        /// <param name="businessCustomer"></param>
        public static SingleCustomerViewModel ToViewModel(this CustomerSingleSearchDto businessCustomer)
        {
            if (businessCustomer != null)
            {
                return new SingleCustomerViewModel
                {
                    Name = businessCustomer.Name,
                    Adress = businessCustomer.Adress,
                    Siret = businessCustomer.Siret,
                    NafCode = businessCustomer.NafCode,
                    Phone = businessCustomer.Phone,
                    ZipCode = businessCustomer.ZipCode,
                    City = businessCustomer.SocialReason,
                    Civility = businessCustomer.Civility,
                    SocialReason = businessCustomer.SocialReason
                };
            }
            return null;
        }

        /// <summary>
        /// Converts from list of DTO to list of ViewModel - for multiple search
        /// </summary>
        /// <param name="businessCustomers"></param>
        public static IEnumerable<MultipleCustomersViewModel> ToViewModel(this IEnumerable<CustomerMultipleSearchDto> businessCustomers)
        {
            if (businessCustomers != null)
            {
                List<MultipleCustomersViewModel> list = businessCustomers.Select(e => ToViewModel(e)).ToList();
                return list;
            }
            return new List<MultipleCustomersViewModel>();
        }

        /// <summary>
        /// Converts from single DTO to single ViewModel - for multiple search
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private static MultipleCustomersViewModel ToViewModel(this CustomerMultipleSearchDto e)
        {
            if (e != null)
            {
                return new MultipleCustomersViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Adress = e.Adress,
                    SocialReason = e.SocialReason,
                };
            }
            return null;

        }
    }
}
