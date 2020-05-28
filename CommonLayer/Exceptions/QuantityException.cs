using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Exceptions
{
    /// <summary>
    /// Class For Handlling Custom Exception.
    /// </summary>
    public class QuantityException : Exception
    {
        /// <summary>
        /// Enum For Exception Types.
        /// </summary>
        public enum ExceptionType
        { 
            NULL_FIELD_EXCEPTION,
            INVALID_FIELD_EXCEPTION
        }

        /// <summary>
        /// Exception type Reference.
        /// </summary>
        ExceptionType type;

        /// <summary>
        /// Parameter Constructor For Throwing Exception.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public QuantityException(QuantityException.ExceptionType type,string message) : base(message)
        {
            this.type = type;
        }
    }
}
