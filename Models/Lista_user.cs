using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzWeb.Models
{
    public class Lista_user
    {
        public List<FizzBuzz> user { get; set; }
        public Lista_user()
        {
            user = new List<FizzBuzz>();
        }
    }
}
