using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRM.View._interface
{
    public interface ISignUpView
    {
        string Username { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string FullName { get; set; }
        string Role { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler ShowLoginView;
        event EventHandler CancelEvent;
        event EventHandler SignUpEvent;
    }
}
