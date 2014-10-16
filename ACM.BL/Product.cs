using System;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {
            
        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            return new Product();
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates the product data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = !string.IsNullOrWhiteSpace(ProductName);
            if (CurrentPrice == null)
                isValid = false;
            return isValid;
        }
    }
}
