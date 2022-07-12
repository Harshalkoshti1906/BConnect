using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bconnect.data.Entity
{
    public class BusinessCard: BaseClass
    {
        public string CompanyName { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string TelContact { get; set; }
        public string MobileNo { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
    }
}
