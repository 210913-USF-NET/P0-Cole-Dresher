using System.Collections.Generic;

namespace Models
{
    public class Order
    {

        //Orders need a date for history

        public List<LineItem> LineItems {get; set;}

        public StoreFront Location {get; set;}

        public decimal Total {get; set;}

        //public Customer Owner {get; set;}

        public override string ToString(){
            string displayString = $"Your order from {this.Location.Name}: \n";
            foreach (LineItem lineItem in this.LineItems)
            {
                displayString += $"{lineItem.ToString()}\n";
            }

            displayString += $"Your subtotal is: {this.Total}\n";
            return displayString;

        }

        public void addProduct(Product product, int quantity){

            LineItem x = new LineItem(product, quantity);
            this.LineItems.Add(x);
            this.Total += (product.Price * quantity);
        }
    }
}