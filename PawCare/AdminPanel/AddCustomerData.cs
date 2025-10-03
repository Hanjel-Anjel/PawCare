using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawCare.AdminPanel
{
    public class AddCustomerData
    {
        // Customer Info
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Suffix { get; set; }

        // Address Info
        public string? Region { get; set; }
        public string? MunicipalityCity { get; set; }
        public string? Barangay { get; set; }
        public string? HouseNo { get; set; }
        public string? LotBlock { get; set; }

        //Contact Info
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
    }
}
