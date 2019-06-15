using System.Collections.Generic;
using Abc.Nrtwnd.Entities.Concrete;

namespace Abc.Nrtwnd.WebUI.Models.Product
{
    public class ProductUpdateViewModel
    {
        public Entities.Concrete.Product Product { get; set; }
        public List<Entities.Concrete.Category> Categories { get; set; }
    }
}