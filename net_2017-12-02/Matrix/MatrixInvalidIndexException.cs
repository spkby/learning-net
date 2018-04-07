using System;

namespace Matrixs
{
    [Serializable()]
    class MatrixInvalidIndexException : ApplicationException
    {
        public MatrixInvalidIndexException() : base() { }
        public MatrixInvalidIndexException(string message) : base(message) { }
        public MatrixInvalidIndexException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected MatrixInvalidIndexException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
