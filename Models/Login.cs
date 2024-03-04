using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gestionale_Spedizioni.Models
{
    public class Login
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}