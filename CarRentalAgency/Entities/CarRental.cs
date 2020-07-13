using CarRentalAgency.Exceptions;
using System;

namespace CarRentalAgency.Entities
{
    class CarRental
    {
        internal DateTime Start { get; set; }
        internal DateTime Finish { get; set; }

        internal Vehicle Vehicle { get; set; }
        internal Invoice Invoice { get; set; }

        internal CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            if (start < DateTime.Now)
            {
                throw new ControlExceptionCarRental("An error occurred\n");
            }
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }
    }
}
