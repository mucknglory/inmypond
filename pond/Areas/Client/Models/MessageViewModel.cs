using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pond.Web.Areas.Common.Models
{

    public class Message
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public int FromMemberId { get; set; }

        public string FromMemberName { get; set; }

        [ScaffoldColumn(false)]
        public int ToMemberId { get; set; }
        public string ToMemberName { get; set; }

        [Required]
        public string Subject { get; set; }
        [Display(Name = "Message Body")]
        [DataType(DataType.Text)]
        [StringLength(255, ErrorMessage = "Please enter a subject for this message of up to 255 characters")]
        public string MessageBody { get; set; }

        [Display(Name = "Date Sent")]
        [ScaffoldColumn(false)]
        public DateTime SendDate { get; set; }

        [ScaffoldColumn(false)]
        public bool IsRead { get; set; }
        [ScaffoldColumn(false)]
        public bool HasAttachments { get; set; }

    }
}