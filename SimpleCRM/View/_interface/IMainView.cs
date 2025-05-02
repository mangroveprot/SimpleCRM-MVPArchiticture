using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRM.View._interface
{
    public interface IMainView
    {
        event EventHandler ShowUserView;
        event EventHandler ShowCustomerView;
        event EventHandler ShowProductView;
        event EventHandler ShowOrderView;
        event EventHandler LogoutEvent;
    }
}
