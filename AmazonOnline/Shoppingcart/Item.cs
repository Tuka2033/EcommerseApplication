﻿using Catalog;
namespace ShoppingCart
{
    public class Item
    {
        public Product theProduct { get; set; }
        public int Quantity { get; set; }
        public Item(Product product, int quantity)
        {
            theProduct = product;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return this.theProduct+" "+this.Quantity;
        }
    }
}
