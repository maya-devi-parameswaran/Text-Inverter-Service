using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;

namespace WebApplication4
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string InvertText(string text)
        {
            var invertedText = string.Concat(
                                            Regex.Split(text, @"(\W+)").Select(let => let.Length > 0 && char.IsLetter(let[0])
                                                                  ? string.Concat(let.Reverse()) : let)
                                            );


            return invertedText;
        }
    }
}