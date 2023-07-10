using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineMarket.BLL.ViewModels.Product
{
    internal class ProductVM
    {
        public int Id { get; set; }
        [Display(Name = "Название товара")]
        [Required(ErrorMessage = "Введите название товара")]
        public string ProductName { get; set; }
        [Display(Name = "Описание товара")]
        [Required(ErrorMessage = "Введите описание товара")]
        public string ProductDescription { get; set; }
        [Display(Name = "Стоимость")]
        [Required(ErrorMessage = "Укажите стоимость")]
        public decimal Price { get; set; }
        [Display(Name = "Количество")]
        [Required(ErrorMessage = "Укажите количество")]
        public int Quantity { get; set; }
        public IFormFile? ProductformFile { get; set; }
        public byte[]? ProductPhoto { get; set; }
    }
}
