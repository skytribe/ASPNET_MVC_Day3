using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3_ModelState.Helpers
{
    public static class CustomMarqueeHelper
    {

        public static MvcHtmlString Marquee(this System.Web.Mvc.ModelStateDictionary ms)
        {
            string retString = "";

            ////Validate
            if (!ms.IsValid)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (var item in ms)
                {
                    if (item.Value.Errors.Count > 0)
                    {
                        sb.AppendLine("\n[" + item.Key + "]: ");
                        foreach (var err in item.Value.Errors)
                        {
                            sb.AppendLine(err.ErrorMessage + "  ");


                        }
                    }
                }

                retString = "<marquee behavior=\"scroll\" direction=\"up\" >" + sb.ToString() + "</marquee>";           
            }
            return new MvcHtmlString(retString);
        }
    }
}




