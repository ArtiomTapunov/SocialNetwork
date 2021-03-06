﻿using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace SN.WEB.HtmlHelpers
{
    public static class HelperUI
    {
        public static MvcHtmlString CheckBoxSimple(this HtmlHelper htmlHelper, string name, object htmlAttributes)
        {
            string checkBoxWithHidden = htmlHelper.CheckBox(name, htmlAttributes).ToHtmlString().Trim();
            string pureCheckBox = checkBoxWithHidden.Substring(0, checkBoxWithHidden.IndexOf("<input", 1));
            return new MvcHtmlString(pureCheckBox);
        }
    }
}