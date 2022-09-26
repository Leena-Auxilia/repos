using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace Enable_Session_Core_Razor.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            //Set value in Session object.
            HttpContext.Session.SetString("Person", "Mudassar");
        }

        public void OnPostSubmit(string sessionName)
        {
            //Get value from Session object.
            ViewData["Message"] = HttpContext.Session.GetString(sessionName);
        }
    }
}