using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Queue_New.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "ФИО")]
        public string Name { get; set; }

        [Display(Name = "Номер телефона")]
        public int PhoneNumber { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
