﻿using System;
using System.Runtime.Serialization;

namespace BusinessCustomer.Domain.Exceptions
{
    /// <summary>
    /// NotFound Exception
    /// </summary>
    [Serializable]
    public class NotFoundException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public NotFoundException() : base() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public NotFoundException(string message)
            : base(message) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public NotFoundException(string message, Exception innerException)
            : base(message, innerException)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected NotFoundException(SerializationInfo info, StreamingContext context)
       : base(info, context) { }
    }
}
