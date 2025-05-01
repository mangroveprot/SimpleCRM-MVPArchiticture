using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRM.View._interface
{
    public interface IOrderView
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public string ProductId { get; set; }
        public string Quantity { get; set; }
        public string TotalAmount { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        public string SearchValue { get; set; }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        //events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //methods
        void SetOrderBindingSource(BindingSource customerList);
        void Show();
    }
}
