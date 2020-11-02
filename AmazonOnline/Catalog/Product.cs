

namespace Catalog
{
   public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public float Quantity { get; set; }
        public Product() { }
        public Product(int id,string title,string description, float unitPrice,float quantity)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;

        }
        public override string ToString()
        {
            return this.Id + " " + this.Title + " " + this.Description + " " + this.UnitPrice + " " + this.Quantity;
        }

    }
}
