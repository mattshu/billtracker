using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillTracker
{
    internal class ErrorHandler
    {
        public static DialogResult ErrorYesNo(string msg)
        {
            var result = MessageBox.Show(msg, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            Console.Error.WriteLine($"Error: {msg} -- user specified {result}");
            return result;
        }
        public static void Error(string msg)
        {
            Console.Error.WriteLine($"Error: {msg}");
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
