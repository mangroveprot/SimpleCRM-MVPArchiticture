using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleCRM.Models._models
{
    public class ProductModel
    {
        private int productId;
        private string productName;
        private string description;
        private decimal price;
        private int stockQuantity;

        [DisplayName("Product ID")]
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Product Name must be between 2 and 100 characters")]
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        [DisplayName("Description")]
        [MaxLength(int.MaxValue, ErrorMessage = "Description is too long")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Price is required")]
        [Range(0, 1000000.00, ErrorMessage = "Price must be zero or more")]
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        [DisplayName("Stock Quantity")]
        [Required(ErrorMessage = "Stock Quantity is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock Quantity must be zero or greater")]
        public int StockQuantity
        {
            get { return stockQuantity; }
            set { stockQuantity = value; }
        }
    }
}
