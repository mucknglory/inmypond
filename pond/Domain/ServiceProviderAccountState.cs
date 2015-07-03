using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Pond.Web.Domain
{
    public enum ServiceProviderAccountStateValues {
        AwaitingRegConfirmation = 1,
        Registered,
        Suspended,
        Cancelled}

    public class ServiceProviderAccountState
    {
        public ServiceProviderAccountState()
        {
            // Set the default values
            IsSystem = false;
            IsActive = true;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Required, MaxLength(50, ErrorMessage ="Description must be 20 characters or less")]
        public string Description { get; set; }
        
        public bool IsSystem { get; set; }

        public bool IsActive { get; set; }

    }
}