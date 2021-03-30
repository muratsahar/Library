using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libray.Entities
{
    public class MembershipFeePayment
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public DateTime Month { get; set; }
        public bool Paid { get; set; }
    }
}
