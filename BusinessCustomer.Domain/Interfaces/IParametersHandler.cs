using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessCustomer.Domain
{
    /// <summary>
    /// Validation of input data
    /// </summary>
    public interface IParametersHandler
    {
        /// <summary>
        /// Validation for parameter : siret
        /// </summary>
        /// <param name="siret"></param>
        /// <returns> True if siret is valid, false otherwise </returns>
        public bool Validate(string siret);
        /// <summary>
        /// Validation for parameters : socialreason and zipcode
        /// </summary>
        /// <param name="socialreason"></param>
        /// <param name="zipcode"></param>
        /// <returns> True if socialreason and zipcode are valid, false otherwise </returns>
        public bool Validate(string socialreason, string zipcode);

    }
}
