using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abc.Nrtwnd.WebUI.Models.Category
{
    public class CategoryListViewModal
    {
        public List<Entities.Concrete.Category> Categories { get; set; }
        public int CurrenCategory { get; set; }
    }
}