using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunwoody_residency
{
    class Worker:Resident
    {                                                              // no amount of hours was given, so I made the hours to 80, 4 hours a day
        private const int FEE = 685; // Formula: 1245((p * n) / 2)     p = 14 (pay), n = numbers of monthly hours worked

        public Worker(string firstname, string lastname, int id, string residentType, double monthlyFee, int floor, int dorm)
            : base(firstname, lastname, id, residentType, monthlyFee, floor, dorm)
        {
            FirstName = firstname;
            LastName = lastname;
            ID = id;
            ResidentType = residentType;
            MonthlyFee = monthlyFee;
            setMonthlyFee();
            Floor = floor;
            Dorm = dorm;
        }

        void setMonthlyFee()
        {
            MonthlyFee = FEE;
        }

    }
}
