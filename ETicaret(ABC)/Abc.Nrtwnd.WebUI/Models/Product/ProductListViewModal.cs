using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.Nrtwnd.WebUI.Models.Product
{
    public class ProductListViewModal
    {
        public List<Entities.Concrete.Product> Products { get; internal set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public int CurrenCategory { get; internal set; }
        public int CurrenPage { get; internal set; }
    }
}