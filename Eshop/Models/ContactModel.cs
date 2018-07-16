using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    [Table("Contacts")]
    public class ContactModel
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int NumarTelefon { get; set; }
        public string Email { get; set; }
        public string Mesaj { get; set; }
    }
}