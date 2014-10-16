namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Retrieve one order item
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        /// <summary>
        /// Saves the current order item
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderQuantity <= 0)
                return false;          
            if (ProductId <= 0)
                isValid = false;
            if (PurchasePrice == null)
                isValid = false;

            return isValid;
        }
    }
}
