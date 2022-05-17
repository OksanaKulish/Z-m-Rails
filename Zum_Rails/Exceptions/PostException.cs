using System;

namespace Zum_Rails.Exceptions
{
    [Serializable]
    public class PostException : Exception
    {
        public PostException(){ }

        public PostException(string message)
        : base(message) { }

        public PostException(string message, Exception inner)
            : base(message, inner) { }
    }
}
