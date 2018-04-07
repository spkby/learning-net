using System;

namespace Matrixs
{
    [Serializable()]
    class MatrixSizeException : ApplicationException
    {
        public MatrixSizeException() : base() { }
        public MatrixSizeException(string message) : base(message) { }
        public MatrixSizeException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected MatrixSizeException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
