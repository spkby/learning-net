using System;

namespace Matrixs
{
    [Serializable()]
    class MatrixsDifferentSizes : ApplicationException
    {
        public MatrixsDifferentSizes() : base() { }
        public MatrixsDifferentSizes(string message) : base(message) { }
        public MatrixsDifferentSizes(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected MatrixsDifferentSizes(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
