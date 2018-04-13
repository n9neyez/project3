using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunwoody_residency
{
    class Scholarships:Resident
    {
        private const int FEE = 100; // Scholarship residents pay 100 monthly

        public Scholarships(string firstname, string lastname, int id, string residentType, double monthlyFee, int floor, int dorm)
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
