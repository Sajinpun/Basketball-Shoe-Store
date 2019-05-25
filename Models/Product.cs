using System;
using System.Collections.Generic;


namespace bshoestore.Models {
    public partial class Product
    {
        public int ProductId { get; set; }
        public Nullable<int> CatID { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public decimal Size { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Id { get; set; }

        public virtual Category Category1 { get; set; }
    }

}