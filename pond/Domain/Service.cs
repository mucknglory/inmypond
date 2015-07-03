using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pond.Web.Domain
{
    public class Service
    {
        public int ID { get; set; }

        //public int ServiceProviderID { get; set; }
        public int ServiceCategoryID { get; set; }
        [Required]
        [Display(Name = "Service Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Service Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Rating")]
        public double Rating
        {
            get
            {
                return 4.5;
            }
        }
        public int? likeCount { get; set; }

        public virtual ServiceCategory ServiceCategory { get; set; }
        //public virtual ServiceProvider ServiceProvider { get; set; }

    }

}