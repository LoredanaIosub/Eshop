using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Contact 
    {
        [Key] //Id declarat ca cheie primara
        public int Id_Contact { get; set; }

        [Required]//Necesar
        [StringLength(15,ErrorMessage = "FirstName must be 15 characters or less", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "LastName must be 15 characters or less", MinimumLength = 3)]
        public string LastName { get; set; }

        [Range(0,10)]
        public int Phone { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Email must be 40 characters or less", MinimumLength = 5)]
        public string Email { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "Message must be 300 characters or less", MinimumLength = 3)]
        public string Message { get; set; }
    }
}