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
    public class SizeController : ControllerBase
    {

        EcommerceContext _ecommerceDbContext;
        public SizeController(EcommerceContext ecommerceDbContext)
        {
            _ecommerceDbContext = ecommerceDbContext;
        }
        [HttpGet]
        public IEnumerable<TblSize> GetSizes()
        {
            return _ecommerceDbContext.TblSizes.ToList();


        }
    }
}
