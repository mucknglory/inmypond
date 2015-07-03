using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Pond.Web.Domain;

namespace Pond.Web.Areas.Admin.Models
{
    public class ServiceProvider
    {
        [ScaffoldColumn(false)]
        public virtual string ID { get; set; }

        [Required, Display(Name = "Organization Name"), DataType(DataType.Text), StringLength(255,ErrorMessage ="Please enter a maximum of 255 characters")]
        public virtual string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public virtual string Description { get; set; }

        public int PrimaryServiceCategoryID { get; set; }

        [Display(Name = "Work Telephone Number"), DataType(DataType.PhoneNumber), Phone]
        public virtual string WorkTelephone { get; set; }

        [Display(Name = "Mobile Telephone Number"), DataType(DataType.PhoneNumber), Phone]
        public virtual string MobileTelephone { get; set; }

        [Display(Name = "Website Address"), DataType(DataType.Url)]
        public virtual string URL { get; set; }

        [Display(Name = "Email Address"), DataType(DataType.EmailAddress)]
        public virtual string EmailAddress { get; set; }

        [Range(0,5,ErrorMessage="Must be a number between 0 and 5")]
        public virtual double Rating { get; set; }

        [Display(Name = "Primary Contact Name")]
        public string PrimaryContactName { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RegistrationDate { get; set; }

        public Address BusinessAddress { get; set; }

        public Address BillingAddress { get; set; }

        public virtual ServiceCategory ServiceCategory { get; set; }

        [Editable(false)]
        public virtual ICollection<Service> Services { get; set; }



    }

}
