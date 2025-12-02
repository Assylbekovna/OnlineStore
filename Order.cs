namespace OnlineOrderSystem.Models
{
    public class Order
    {
        public Cart Cart { get; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public bool IsPaid { get; set; }

        public Order(Cart cart)
        {
            Cart = cart;
        }
    }
}
