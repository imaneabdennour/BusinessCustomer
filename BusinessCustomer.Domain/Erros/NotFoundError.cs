﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessCustomer.Domain.Erros
{
    /// <summary>
    /// Error : Not Found
    /// </summary>
    public class NotFoundError
    {
        /// <summary>
        /// 
        /// </summary>
        public JsonResult Result { get; set; }

        /// <summary>
        /// Constructing a NotFound Error with message
        /// </summary>
        /// <param name="msg"></param>
        public NotFoundError(string msg)
        {
            Result = new JsonResult(msg)
            {
                StatusCode = StatusCodes.Status404NotFound,
                Value = new { message = msg }
            };
        }
    }
}
