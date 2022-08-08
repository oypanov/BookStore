/*using System;
using System.Runtime.Serialization;

namespace Acme.BookStore.Authors
{
    [Serializable]
    internal class AuthorAlreadyExistsException : Exception
    {
        public AuthorAlreadyExistsException()
        {
        }

        public AuthorAlreadyExistsException(string message) : base(message)
        {
        }

        public AuthorAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AuthorAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}*/
using Volo.Abp;

namespace Acme.BookStore.Authors
{
    public class AuthorAlreadyExistsException : BusinessException
    {
        public AuthorAlreadyExistsException(string name)
            : base(BookStoreDomainErrorCodes.AuthorAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
