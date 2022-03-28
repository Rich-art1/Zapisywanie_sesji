using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {

        public string response { get; set; }
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }
        public List<FizzBuzz> fizzBuzzes { get; set; }
        public Lista_user Lista_user = new Lista_user();

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var Number = HttpContext.Session.GetString("Number");
            if (Number != null)
            {
                Lista_user = JsonConvert.DeserializeObject<Lista_user>(Number);
            }
                
        }
        public string Alert_wiek;
        public IActionResult OnPost()
        {
            

            var Number = HttpContext.Session.GetString("Number");
            if (Number != null)
            {
                Lista_user = JsonConvert.DeserializeObject<Lista_user>(Number);
            }
            if (ModelState.IsValid)
            {

                Lista_user.user.Add(FizzBuzz);

                HttpContext.Session.SetString("Number",
                JsonConvert.SerializeObject(Lista_user));
               // return RedirectToPage("./SavedInSession");
            }
            if (!ModelState.IsValid)
            {
                Alert_wiek = "Błąd! Wybierz liczbę z zakresu 1899-2022";
                return Page();
            }
            response = $"{FizzBuzz.Name}, {FizzBuzz.Number}, {FizzBuzz.Wynik()}";
            return Page();
        }

    }
}
