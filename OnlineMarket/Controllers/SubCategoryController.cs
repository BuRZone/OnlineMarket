using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Category;
using OnlineMarket.BLL.ViewModels.Product;
using OnlineMarket.Models;

namespace OnlineMarket.Controllers
{
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryService _subCategoryService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public SubCategoryController(ISubCategoryService subCategoryService, ICategoryService categoryService, IProductService productService)
        {
            _subCategoryService = subCategoryService;
            _categoryService = categoryService;
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSubCategory(int? id, int? scrolled, int pageNumber = 1)
        {

            const int PageSize = 12;
            int recsCount = _productService.GetAsync().Where(x => x.SubCategory.CategoryId == id).Count();
            var pager = new Pager(recsCount, pageNumber, PageSize * 2);
            this.ViewBag.Pager = pager;

            int scrollPage = scrolled ?? 0;
            int itemsToSkip = (pageNumber - 1) * PageSize;
            

            var category = _categoryService.GetAsync().FirstOrDefault(x => x.Id == id);

            ViewData["Category"] = category.CategoryName;

            var subCatVMList = new List<SubCategoryVM>();
            var productVMList = new List<ProductVM>();
            this.ViewBag.ProductVM = productVMList;

            var categoryQ = await _categoryService.GetAsync().Include(x => x.SubCategory).
                FirstOrDefaultAsync(x => x.Id == id);

            foreach (var subCat in categoryQ.SubCategory)
            {
                SubCategoryVM subCategoryVM = new SubCategoryVM()
                {
                    Id = subCat.Id,
                    CategoryName = subCat.CategoryName
                };
                subCatVMList.Add(subCategoryVM);
            }

            if (scrollPage < 2 && pageNumber == 1)
            {
                itemsToSkip = scrollPage * PageSize;
                var productQ = await _productService.GetAsync().Where(x => x.SubCategory.CategoryId == id).OrderBy(x => x.Id).Skip(itemsToSkip).Take(PageSize).ToListAsync();

                foreach (var product in productQ)
                {
                    ProductVM productVM = new ProductVM();

                    productVM.ProductName = product.ProductName;
                    productVM.ProductDescription = product.ProductDescription;
                    productVM.Price = product.Price;
                    productVM.ProductPhoto = product.ProductPhoto;
                    productVM.SubCategoryId = product.SubCategoryId;
                    productVM.Id = product.Id;
                    productVM.Quantity = product.Quantity;
                    productVMList.Add(productVM);
                }
                return View(subCatVMList);
            }

            else if (scrollPage < 2 && pageNumber != 1)
            {

                scrollPage = scrolled == null ? 0 : PageSize;
                var i = pageNumber;


                itemsToSkip = scrollPage + 2 * PageSize * (i - 1);
                var productQ = await _productService.GetAsync().Where(x => x.SubCategory.CategoryId == id).OrderBy(x => x.Id).Skip(itemsToSkip).Take(PageSize).ToListAsync();
                foreach (var product in productQ)
                {
                    ProductVM productVM = new ProductVM();

                    productVM.ProductName = product.ProductName;
                    productVM.ProductDescription = product.ProductDescription;
                    productVM.Price = product.Price;
                    productVM.ProductPhoto = product.ProductPhoto;
                    productVM.SubCategoryId = product.SubCategoryId;
                    productVM.Id = product.Id;
                    productVM.Quantity = product.Quantity;
                    productVMList.Add(productVM);

                }
                return View(subCatVMList);
            }
            else return View();
        }


        public async Task<IActionResult> GetProductsFromSubCategory(int? id, int? scrolled, int pageNumber = 1)
        {
            const int PageSize = 12;
            int recsCount = _productService.GetAsync().Where(x => x.SubCategoryId == id).Count();
            var pager = new Pager(recsCount, pageNumber, PageSize * 2);
            this.ViewBag.Pager = pager;
            var productVMList = new List<ProductVM>();
            int scrollPage = scrolled ?? 0;
            int itemsToSkip = (pageNumber - 1) * PageSize;

            var category = await _categoryService.GetAsync().Include(x => x.SubCategory).FirstOrDefaultAsync(x => x.SubCategory.Any(x => x.Id == id));
            ViewData["Category"] = category;
            var sub = category.SubCategory.Where(x => x.Id == id).FirstOrDefault();
            ViewData["SubCategory"] = sub.CategoryName;


            if (scrollPage < 2 && pageNumber == 1)
            {
                itemsToSkip = scrollPage * PageSize;
                var productQ = await _productService.GetAsync().Where(x => x.SubCategoryId == id).OrderBy(x => x.Id).Skip(itemsToSkip).Take(PageSize).ToListAsync();
                

                foreach (var product in productQ)
                {
                    ProductVM productVM = new ProductVM();
                    productVM.ProductName = product.ProductName;
                    productVM.ProductDescription = product.ProductDescription;
                    productVM.Price = product.Price;
                    productVM.ProductPhoto = product.ProductPhoto;
                    productVM.SubCategoryId = product.SubCategoryId;
                    productVM.Id = product.Id;
                    productVM.Quantity = product.Quantity;
                    productVMList.Add(productVM);
                }

                return View(productVMList);
            }
            else if (scrollPage < 2 && pageNumber != 1)
            {

                scrollPage = scrolled == null ? 0 : PageSize;
                var i = pageNumber;


                itemsToSkip = scrollPage + 2 * PageSize * (i - 1);
                var productQ = await _productService.GetAsync().Where(x => x.SubCategoryId == id).OrderBy(x => x.Id).Skip(itemsToSkip).Take(PageSize).ToListAsync();

                foreach (var product in productQ)
                {
                    ProductVM productVM = new ProductVM();
                    productVM.ProductName = product.ProductName;
                    productVM.ProductDescription = product.ProductDescription;
                    productVM.Price = product.Price;
                    productVM.ProductPhoto = product.ProductPhoto;
                    productVM.SubCategoryId = product.SubCategoryId;
                    productVM.Id = product.Id;
                    productVM.Quantity = product.Quantity;
                    productVMList.Add(productVM);
                }

                return View(productVMList);
            }
            return View();

        }

    }
}
