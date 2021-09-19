namespace Models
{
    public class LineItem
    {
        public LineItem(Product product, int quantity)
        {
            this.Item = product;
            this.Quantity = quantity;
        }

        public Product Item {get; set;}

        public int Quantity {get; set;}

        public override string ToString()
        {
            return $"Product Name: {this.Item.Name}, Quantity: {this.Quantity}\n";
        }
    }
}