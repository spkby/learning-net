using System;

namespace Matrixs
{
    [Serializable()]
    class MatrixRowsNotEqualColumnsException : ApplicationException
    {
        public MatrixRowsNotEqualColumnsException() : base() { }
        public MatrixRowsNotEqualColumnsException(string message) : base(message) { }
        public MatrixRowsNotEqualColumnsException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected MatrixRowsNotEqualColumnsException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
