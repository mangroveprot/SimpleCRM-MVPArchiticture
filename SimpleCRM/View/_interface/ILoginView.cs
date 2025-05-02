using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRM.View._interface
{
    public interface ILoginView
    {
        string Username { get; set; }
        string Password { get; set; }

        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler LoginEvent;
        event EventHandler CancelEvent;
    }
}
