using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pond.Web.Areas.Common.Models
{
    public class Member
    {
        [ScaffoldColumn(false)]
        public virtual string ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name(s)")]
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Home Telephone Number"), DataType(DataType.PhoneNumber), Phone]
        public virtual string HomeTelephone { get; set; }

        [Display(Name = "Mobile Telephone Number"), DataType(DataType.PhoneNumber), Phone]
        public virtual string MobileTelephone { get; set; }

        [Display(Name = "Work Telephone Number"), DataType(DataType.PhoneNumber), Phone]
        public virtual string WorkTelephone { get; set; }

        [Required]
        [Display(Name = "Email Address"), DataType(DataType.EmailAddress)]
        public virtual string EmailAddress { get; set; }

        public Address Address { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RegistrationDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

    }

}
