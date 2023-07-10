using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineMarket.BLL.ViewModels.Account
{
    public class ChangePasswordVM
    {
        [Required(ErrorMessage = "Укажите имя")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [MinLength(6, ErrorMessage = "Пароль должен быть больше или равен 5 символов")]
        public string NewPassword { get; set; }
    }
}
