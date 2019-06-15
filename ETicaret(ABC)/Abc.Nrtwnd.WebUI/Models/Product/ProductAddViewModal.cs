using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abc.Nrtwnd.WebUI.Models.Product
{
    public class ProductAddViewModal
    {
        public Entities.Concrete.Product Product { get; set; }
        public List<Entities.Concrete.Category> Categories { get; set; }
    }
}