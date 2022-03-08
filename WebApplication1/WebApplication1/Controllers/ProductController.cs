using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        EcommerceContext _ecommerceContext;
        public ProductController(EcommerceContext ecommerceDbContext)
        {
            _ecommerceContext = ecommerceDbContext;
        }
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            //var productData = _ecommerceDbContext.TblProducts.ToList();
            var productData = from P in _ecommerceContext.TblProducts
                              join PSC in _ecommerceContext.TblProductSizeColors
                              on P.Id equals PSC.ProductId
                              join S in _ecommerceContext.TblSizes
                              on PSC.SizeId equals S.Id
                              join C in _ecommerceContext.TblColors
                              on PSC.ColorId equals C.Id
                              join Cat in _ecommerceContext.TblCategories
                              on PSC.CatId equals Cat.Id
                              select new
                              {
                                  P.Id,
                                  P.ProductName,
                                  P.VendorName,
                                  P.Mrp,
                                  P.Discount,
                                  P.FinalPrice,
                                  P.Description,
                                  S.SizeName,
                                  C.ColorName,
                                  Cat.CategoryName
                              };

            var productList = new List<Product>();
            foreach (var item in productData)
            {
                var product = new Product();
                product.ProductId = item.Id;
                product.ProductName = item.ProductName;
                product.Vendor = item.VendorName;
                product.ProductSize = item.SizeName;
                product.ProductColor = item.ColorName;
                product.ProductDescription = item.Description;
                product.Category = item.CategoryName;
                product.Mrp = item.Mrp;
                product.Discount = item.Discount;
                product.FinalPrice = item.FinalPrice;
                productList.Add(product);
            }
            return productList;
        }
    }
}
