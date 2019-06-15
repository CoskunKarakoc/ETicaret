using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Abc.Nrtwnd.WebUI.TagHelpers
{

    public static class PagingTagHelper
    {
        public static MvcHtmlString CustomPage(this HtmlHelper htmlHelper, int PageSize, int PageCount, int CurrentCategory,
            int CurrenPage)
        {
            var tagBuilder = new TagBuilder("nav");
            tagBuilder.MergeAttribute("aria-label", "Page navigation example");
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<ul class='pagination'>");
            for (int i = 1; i <= PageCount; i++)
            {
                stringBuilder.AppendFormat("<li class='page-item {0}'>", i == CurrenPage ? "active" : "");
                stringBuilder.AppendFormat("<a class='page-link' href='/product/index?page={0}&category={1}'>{2}</a>", i, CurrentCategory,
                    i);
                stringBuilder.Append("</li>");
            }

            stringBuilder.Append("</ul>");
            tagBuilder.InnerHtml = stringBuilder.ToString();
            return MvcHtmlString.Create(tagBuilder.ToString());
        }
    }
}