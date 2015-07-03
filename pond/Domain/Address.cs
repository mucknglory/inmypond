using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Pond.Web.Domain
{
    [ComplexType]
    public class Address
    {
        public Address()
        {
            //AvailableCountries = new List<SelectListItem>();
            //AvailableStates = new List<SelectListItem>();
            //CustomAddressAttributes = new List<AddressAttributeModel>();
        }

        [Display(Name = "House Name")]
        public string HouseName { get; set; }

        [Display(Name ="House Number")]
        public string HouseNumber { get; set; }
        [Display(Name = "Street")]
        public string StreetName { get; set; }
        [Display(Name = "Address Line 1")]
        public string Address1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }
        public string City { get; set; }
        [Display(Name = "County")]
        public string StateProvinceName { get; set; }
        [Display(Name = "Postcode")]
        public string ZipPostalCode { get; set; }

        //public int CountryID { get; set; }
        [Display(Name="Country")]
        public string CountryName { get; set; }

        //public IList<SelectListItem> AvailableCountries { get; set; }
        //public IList<SelectListItem> AvailableStates { get; set; }


        //public string FormattedCustomAddressAttributes { get; set; }
        //public IList<AddressAttributeModel> CustomAddressAttributes { get; set; }

    }
}