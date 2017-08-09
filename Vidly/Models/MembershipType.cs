using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [StringLength(255)]
        [Display(Name = "Membership Type")]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public  byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        
    }
}