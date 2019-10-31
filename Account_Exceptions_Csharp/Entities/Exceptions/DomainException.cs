using System;
using System.Collections.Generic;
using System.Text;

namespace Account_Exceptions_Csharp.Entities.Exceptions {
    class DomainException : ApplicationException {
        public DomainException(string message) : base(message) { }
    }
}
