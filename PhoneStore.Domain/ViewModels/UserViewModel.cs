using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhoneStore.Domain.ViewModels
{
    public class UserViewModel
    {
      

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Укажите Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Укажите пароль")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}
