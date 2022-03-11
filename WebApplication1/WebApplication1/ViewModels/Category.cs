using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int? ParentId { get; set; }
        
    }
}
