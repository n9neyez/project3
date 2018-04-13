using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunwoody_residency
{
    class Athlete:Resident
    {
        private const int FEE = 1200; // Athlete's pay 1200 monthly

        public Athlete(string firstname, string lastname, int id, string residentType, double monthlyFee, int floor, int dorm)
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
