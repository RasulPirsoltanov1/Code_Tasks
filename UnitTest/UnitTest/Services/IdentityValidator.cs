using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Services
{
    public class IdentityValidator : IIdentityValidator
    {
        public bool isValid(string identityNumber)
        {
            return true;
        }
    }
}
