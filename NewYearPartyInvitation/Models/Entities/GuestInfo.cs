using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewYearPartyInvitation.Models.Entities
{
    public class GuestInfo
    {
        public int GuestInfoID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
       
        [Required]
        public string Mobile { get; set; }
        
        [Range(18, 40)]
        public int Age { get; set; }
        
        [Required]
        [Display(Name = "Covid Test Status")]
        public string CovidTestStatus { get; set; }
    }
}