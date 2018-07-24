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
        public int Id { get; set; }

        [Required]//Necesar
        [MaxLength(15, ErrorMessage = "FirstName must be 15 characters or less"), MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "LastName must be 15 characters or less"), MinLength(2)]
        public string LastName { get; set; }

        [MaxLength(10, ErrorMessage = "Phone must have 10 numbers"), MinLength(10)]
        public int Phone { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Email must be 15 characters or less"), MinLength(2)]
        public string Email { get; set; }

        [Required] 
        [MaxLength(300, ErrorMessage = "Message must be minimum 20 characters."), MinLength(20)]
        public string Message { get; set; }
    }
}