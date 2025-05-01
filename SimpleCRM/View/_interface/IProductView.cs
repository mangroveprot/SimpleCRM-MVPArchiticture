using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRM.View._interface
{
    public interface IProductView
    {
        //fields
        string ProductId { get; set; }
        string ProductName { get; set; }
        string Description { get; set; }
        string Price { get; set; }
        string StockQuantity { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }


        //events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //methods
        void SetCustomerBindingSource(BindingSource customerList);
        void Show();

    }
}
