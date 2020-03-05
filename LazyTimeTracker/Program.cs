using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    static class Program
    {
        public static IList<TimeEntry> timeEntries = new List<TimeEntry>();
        public static IList<BookingElement> bookingElements = new List<BookingElement>();
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
