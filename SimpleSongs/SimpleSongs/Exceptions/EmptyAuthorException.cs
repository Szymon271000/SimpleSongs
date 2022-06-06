using System.Runtime.Serialization;

namespace SimpleSongsController.Factory
{
    [Serializable]
    internal class EmptyAuthorException : Exception
    {
        public EmptyAuthorException()
        {
        }

        public EmptyAuthorException(string? message) : base(message)
        {
        }

        public EmptyAuthorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmptyAuthorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}