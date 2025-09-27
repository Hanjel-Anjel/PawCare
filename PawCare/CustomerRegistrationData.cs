using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawCare
{
    public class CustomerRegistrationData
    {
        // Customer Info
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }

        // Address Info
        public string Region { get; set; }
        public string MunicipalityCity { get; set; }
        public string Barangay { get; set; }
        public string HouseNo { get; set; }
        public string LotBlock { get; set; }

        // Pet info 
        public string PetName { get; set; }
        public string PetType { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
