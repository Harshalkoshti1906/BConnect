using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bconnect.service.ViewModel
{
    public class BusinessCardViewModel
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string TelContact { get; set; }
        public string MobileNo { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
