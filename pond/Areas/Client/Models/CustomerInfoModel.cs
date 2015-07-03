using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pond.Web.Models.Customer
{
    public class CustomerInfoModel
    {
        public CustomerInfoModel()
        {
            //this.AvailableTimeZones = new List<SelectListItem>();
            //this.AvailableCountries = new List<SelectListItem>();
            //this.AvailableStates = new List<SelectListItem>();
            //this.AssociatedExternalAuthRecords = new List<AssociatedExternalAuthModel>();
            //this.CustomerAttributes = new List<CustomerAttributeModel>();
        }

        //[NopResourceDisplayName("Account.Fields.Email")]
        //[AllowHtml]
        public string Email { get; set; }

        public bool CheckUsernameAvailabilityEnabled { get; set; }
        public bool AllowUsersToChangeUsernames { get; set; }
        public bool UsernamesEnabled { get; set; }
        //[NopResourceDisplayName("Account.Fields.Username")]
        //[AllowHtml]
        public string Username { get; set; }

        //form fields & properties
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? DateOfBirthDay { get; set; }
        public int? DateOfBirthMonth { get; set; }
        public int? DateOfBirthYear { get; set; }
        public DateTime? ParseDateOfBirth()
        {
            if (!DateOfBirthYear.HasValue || !DateOfBirthMonth.HasValue || !DateOfBirthDay.HasValue)
                return null;

            DateTime? dateOfBirth = null;
            try
            {
                dateOfBirth = new DateTime(DateOfBirthYear.Value, DateOfBirthMonth.Value, DateOfBirthDay.Value);
            }
            catch { }
            return dateOfBirth;
        }

        public string Phone { get; set; }

        public bool Newsletter { get; set; }

    }
}