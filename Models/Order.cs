using System.Collections.Generic;

namespace Models
{
    public class Order
    {
        public List<LineItem> LineItems
        {get; set;}

        public decimal Total {get; set;}

        // public Customer Owner {get; set;}

        public override string ToString(){
            string displayString = "";
            foreach (LineItem lineItem in this.LineItems)
            {
                displayString += $"{lineItem.ToString()}\n"
            }

            displayString += $"Your subtotal is: {this.Total}\n"
            return displayString;

        }

        public void addProduct(Product product, int quantity){

        }
    }
}