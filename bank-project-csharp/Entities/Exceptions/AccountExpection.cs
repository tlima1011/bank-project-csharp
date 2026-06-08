using System;
using System.Collections.Generic;
using System.Text;

namespace bank_project_csharp.Entities.Exceptions
{
    internal class AccountExpection : Exception
    {
        public AccountExpection(string? message) : base(message)
        {
        }
    }
}
