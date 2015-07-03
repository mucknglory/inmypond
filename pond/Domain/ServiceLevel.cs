using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pond.Web.Domain
{
    public enum FeeFrequencies
    {
        weekly = 1,
        monthly,
        annual
    }

    public class ServiceLevel
    {
        [ScaffoldColumn(false)]
        public string ID { get; set; }

        [Required, DataType(DataType.Text), StringLength(50, ErrorMessage = "Please enter a maximum of 50 characters")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal Fee { get; set; }

        [ScaffoldColumn(false)]
        public FeeFrequencies FeeFrequency { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ValidFromDate { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ValidToDate { get; set; }

    }

}
