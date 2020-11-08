using System.Collections.Generic;

namespace ShoppingCart
{
   public class Cart
    {

        private List<Item> list = new List<Item>();
        public List<Item> Items { 
            get { return list; }
            set { list = value; }
        }
    
        public Cart() {
           
        }

        public Cart(List<Item> list)
        {
            this.list = list;
        }
        
        public void AddtoCart(Item item)
        {
            list.Add(item);
        }
        public void RemoveFromCart(Item item)
        {
            list.Remove(item);
        }

      public List<Item> getAll()
        {
            return Items;
        }
    }


}
