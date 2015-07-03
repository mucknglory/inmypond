using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pond.Web.Domain
{
    /// <summary>
    /// A ServiceCategory is a defined grouping of related services
    /// </summary>
    public class ServiceCategory
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        /// <summary>
        /// Optional parent category to allow for nesting
        /// </summary>
        [Display(Name = "Parent Category")]
        public int? parentCategoryID { get; set; }
    }
}