using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalAgency.Exceptions
{
    class ControlExceptionCarRental : ApplicationException
    {
        internal ControlExceptionCarRental(string message) : base(message) { }
    }
}
