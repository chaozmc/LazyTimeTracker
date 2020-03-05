using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyTimeTracker
{
    static class Program
    {
        public static IList<TimeEntry> timeEntries = new System.ComponentModel.BindingList<TimeEntry>();
        public static IList<BookingElement> bookingElements = new System.ComponentModel.BindingList<BookingElement>();
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LazyTimeTracker());
        }
    }
}
