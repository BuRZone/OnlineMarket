using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineMarket.BLL.ViewModels.Category
{
    internal class CategoryVM
    {
        public int Id { get; set; }
        [Display(Name = "Название категории")]
        [Required(ErrorMessage = "Введите название")]
        public string CategoryName { get; set; }
        public IFormFile? CategoryformFile { get; set; }
        public byte[]? CategoryPhoto { get; set; }
    }
}
