using System;
using System.Collections.Generic;
using System.Text;

namespace CardApplication.BLL.Exceptions
{

    [Serializable]
    public class CardNotExistsException : Exception
    {
        public CardNotExistsException() { }
        public CardNotExistsException(string message) : base(message) { }
        public CardNotExistsException(string message, Exception inner) : base(message, inner) { }
        protected CardNotExistsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
