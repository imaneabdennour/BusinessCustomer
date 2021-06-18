using System;
using System.Runtime.Serialization;

namespace BusinessCustomer.Domain.Exceptions
{
    /// <summary>
    /// BadRequets Exception
    /// </summary>
    [Serializable]
#pragma warning disable S3925 // "ISerializable" should be implemented correctly
    public class BadRequestException : Exception
#pragma warning restore S3925 // "ISerializable" should be implemented correctly
    {
        /// <summary>
        /// 
        /// </summary>
        public BadRequestException() : base() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public BadRequestException(string message)
            : base(message) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public BadRequestException(string message, Exception innerException)
            : base(message, innerException)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected BadRequestException(SerializationInfo info, StreamingContext context)
       : base(info, context) { }
    }
}
