using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunwoody_residency
{
    public abstract class Resident
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public string ResidentType { get; set; }
        public double MonthlyFee { get; set; }
        public int Floor { get; set; }
        public int Dorm { get; set; }

        // constructor
        public Resident(string firstname, string lastname, int id, string residentType, double monthlyFee, int floor, int dorm)
        {
            FirstName = firstname;
            LastName = lastname;
            ID = id;
            ResidentType = residentType;
            MonthlyFee = monthlyFee;
            Floor = floor;
            Dorm = dorm;
        }

    }

}
