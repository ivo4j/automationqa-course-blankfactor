﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp7.Classes
{
    internal class InsufficientFundsException: Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }
}
