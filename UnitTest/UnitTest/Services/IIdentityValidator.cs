﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Services
{
    public interface IIdentityValidator
    {
        bool isValid(string identityNumber);
    }
}
