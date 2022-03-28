using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace FizzBuzzWeb.Pages
{
    public class SavedInSessionModel : PageModel
    {
        public FizzBuzz FizzBuzz { get; set; }
        public Lista_user Lista_user = new Lista_user();
        public void OnGet()
        {
            var Number = HttpContext.Session.GetString("Number");
            if (Number != null)
                Lista_user =
                JsonConvert.DeserializeObject<Lista_user>(Number);

            HttpContext.Session.SetString("Number",
               JsonConvert.SerializeObject(Lista_user));
        }
    }
}

