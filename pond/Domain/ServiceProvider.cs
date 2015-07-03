using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pond.Web.Domain
{
    public class ServiceProvider
    {
        //protected ServiceProvider()
        //{
        //    ServiceProviderAccountStateID = 0;
        //}

        public int ID { get; set; }

        [Required, Display(Name = "Organization Name"), DataType(DataType.Text), StringLength(255, ErrorMessage = "Please enter a maximum of 255 characters")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required, Display(Name = "Primary Category")]
        public int PrimaryServiceCategoryID { get; set; }

        [Display(Name = "Work Telephone Number"), DataType(DataType.PhoneNumber), Phone]
        public string WorkTelephone { get; set; }

        [Display(Name = "Mobile Telephone Number"), DataType(DataType.PhoneNumber), Phone]
        public string MobileTelephone { get; set; }

        [Display(Name = "Website Address"), DataType(DataType.Url)]
        public string WebsiteURL { get; set; }

        [Display(Name = "Email Address"), DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Range(0, 5, ErrorMessage = "Must be a number between 0 and 5")]
        [ScaffoldColumn(false)]
        public double? Rating { get; set; }

        [Required, Display(Name = "Primary Contact Name")]
        public string PrimaryContactName { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        [Required, Display(Name = "Date Registered")]
        public DateTime RegistrationDate { get; set; }
        
        [Display(Name = "House Name")]
        public string BusinessAddress_HouseName { get; set; }

        [Display(Name = "House Number")]
        public string BusinessAddress_HouseNumber { get; set; }
        [Display(Name = "Street")]
        public string BusinessAddress_StreetName { get; set; }
        [Display(Name = "Address Line 1")]
        public string BusinessAddress_Address1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string BusinessAddress_Address2 { get; set; }
        [Display(Name = "City")]
        public string BusinessAddress_City { get; set; }
        [Display(Name = "County")]
        public string BusinessAddress_StateProvinceName { get; set; }
        [Display(Name = "Postcode")]
        public string BusinessAddress_ZipPostalCode { get; set; }

        //public int CountryID { get; set; }
        [Display(Name = "Country")]
        public string BusinessAddress_CountryName { get; set; }

        [Required, Display(Name = "Registration Status")]
        public int ServiceProviderAccountStateID { get; set; }

        [Display(Name = "Primary Category")]
        public ServiceCategory PrimaryServiceCategory { get; set; }
        public ServiceProviderAccountState ServiceProviderAccountState { get; set; }

        [Display(Name = "Other Categories")]
        public virtual IEnumerable<ServiceCategory> ServiceCategories { get; set; }
        [Display(Name = "Registration States")]
        public virtual IEnumerable<ServiceProviderAccountState> ServiceProviderAccountStates { get; set; }
        //[Display(Name = "Services Offered")]
        //public virtual IEnumerable<Service> Services { get; set; }



    }

}
