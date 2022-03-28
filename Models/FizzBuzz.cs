using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {

        [Required, StringLength(maximumLength: 100, ErrorMessage = "Zbyt długie imie")]
        public string? Name { get; set; }

        [Required, Range(1899, 2022, ErrorMessage =" ")]
        public int? Number { get; set; }


        public string Wynik()
        {
            if (this.Number == null)
            {
                return " ";
            }
            else
            if (this.Number % 400 == 0)
            {
                return "przestępny";
            }
            else
            {
                if (this.Number % 4 == 0 && this.Number % 100 != 0)
                {
                    return "przestępny";
                }
                else
                {
                    return "nieprzestępny";
                }

            }
        }

    }
}

