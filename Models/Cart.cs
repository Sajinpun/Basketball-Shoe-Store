using System.Collections.Generic;
using System.Linq;

namespace bshoestore.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public void AddItem(Product product, int quantity)
        {
            CartLine line = lineCollection.Where(p => p.Product.ProductId == product.ProductId)
                .FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(
                    new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveItem(Product product)
        {
            lineCollection.RemoveAll(p => p.Product.ProductId == product.ProductId);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(p => p.Product.Price * p.Quantity);
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }

        public void Clear()
        {
            lineCollection.Clear();
        }


        [HttpPost]
        public ActionResult AddToCart(int ID)


        {
            Product product = db.Products.Find(ID);
            Cart basket = new Cart();
            basket.AddItem(new Parts
            {
                Name = ((product.Model)),
                Size = ((product.Size)),
                Description = ((product.Description)),
                Price = (product.Price),

                Id = IdSetter.setId()
            });
            basket.DisplayFor(IdSetter.setId());
            IdSetter.incrementId();
            //seed++;
            return RedirectToAction("Index");
        }
    }
}
}
