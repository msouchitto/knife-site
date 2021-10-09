using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class Knife
    {

        public int Id { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string steel { get; set; }
        public double price { get; set; }
        public double bladeLength { get; set; }

        public Knife()
        {

        }
    }
}
