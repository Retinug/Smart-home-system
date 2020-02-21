using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    static class Console
    {
        public static TextBox TextBox { get; set; }
        static public void Write(string message)
        {
            TextBox.AppendText(message);
        }

        static public void WriteLine(string message)
        {
            TextBox.AppendText(message + Environment.NewLine);
        }
    }
}
