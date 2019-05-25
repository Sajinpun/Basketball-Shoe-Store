using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bshoestore.Models
{
    public class Parts
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Size { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
    }
}