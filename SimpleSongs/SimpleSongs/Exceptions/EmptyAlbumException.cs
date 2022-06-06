using System.Runtime.Serialization;

namespace SimpleSongsController.Factory
{
    [Serializable]
    internal class EmptyAlbumException : Exception
    {
        public EmptyAlbumException()
        {
        }

        public EmptyAlbumException(string? message) : base(message)
        {
        }

        public EmptyAlbumException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmptyAlbumException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}