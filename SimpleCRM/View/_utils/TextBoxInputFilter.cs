using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRM.View._utils
{
    public class TextBoxInputFilter
    {
        public static void AllowOnlyDecimal(TextBox textBox)
        {
            textBox.KeyPress += (s, e) =>
            {
                char c = e.KeyChar;

                if (char.IsControl(c)) return;
                if (char.IsDigit(c)) return;

                if (c == '.' && !textBox.Text.Contains(".")) return;

                e.Handled = true;
            };
        }

        public static void AllowOnlyInteger(TextBox textBox) {

            textBox.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            };
        }
    }
}
