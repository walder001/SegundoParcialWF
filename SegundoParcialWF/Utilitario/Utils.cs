﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace SegundoParcialWF.Utilitario
{
    public static class Utils
    {

        public static int ToInt(string valor)
        {
            int retorno = 0;
            int.TryParse(valor, out retorno);
            return retorno;

        }

        public static decimal ToDecimal(string valor)
        {
            decimal retorno = 0;
            decimal.TryParse(valor, out retorno);
            return retorno;
        }

        public static DateTime ToDateTime(string valor)
        {
            DateTime retorno = DateTime.Now;
            DateTime.TryParse(valor, out retorno);

            return retorno;
        }

        public static void ShowToastr(this Page page, string message, string title, string type = "info")
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "toastr_message",
                string.Format("toastr.{0}('{1}', {2});", type.ToLower(), message, title), addScriptTags: true);


        }

    }
}