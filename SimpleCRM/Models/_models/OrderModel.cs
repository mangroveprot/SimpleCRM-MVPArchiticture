using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleCRM.Models._models
{
    public class OrderModel
    {
        // Fields
        private int orderId;
        private int customerId;
        private int? productId;
        private int quantity;
        private decimal totalAmount;
        private string status;
        private DateTime date;

        // Properties
        [DisplayName("Order ID")]
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        [DisplayName("Customer ID")]
        [Required(ErrorMessage = "Customer ID is required")]
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        [DisplayName("Product ID")]
        [Required(ErrorMessage = "Customer ID is required")]
        public int? ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        [DisplayName("Quantity")]
        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        [DisplayName("Total Amount")]
        [Required(ErrorMessage = "Total Amount is required")]
        [Range(0.01, 999999.99, ErrorMessage = "Total Amount must be greater than 0")]
        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        [DisplayName("Status")]
        [Required(ErrorMessage = "Status is required")]
        [StringLength(10, ErrorMessage = "Status must be between 1 and 20 characters")]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        [DisplayName("Order Date")]
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
