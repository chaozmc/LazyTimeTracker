using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    public class TimeEntry
    {
        private DateTime startTime;
        private DateTime endTime;
        private BookingElement bookingElement;
        private string invoice;

        public TimeEntry(DateTime STime, DateTime ETime, string TimeElement, BookingElement OBookingElement )
        {
            this.StartTime = STime;
            this.EndTime = ETime;
            this.bookingElement = OBookingElement;
        }


        public DateTime StartTime { get => this.startTime; set => this.startTime = value; }
        public DateTime EndTime { get => this.endTime; set => this.endTime = value; }
        public BookingElement BookingElement { get => this.bookingElement; set => this.bookingElement = value; }
        public string Invoice { get => this.invoice; set => this.invoice = value; }
    }

    public class BookingElement
    {
        private string timeElement;
        private string hrElement;
        

        public BookingElement(string STimeElement, string SHrElement)
        {
            this.timeElement = STimeElement;
            this.hrElement = SHrElement;
        }

        public string TimeElement { get => this.timeElement; set => this.timeElement = value; }
        public string HRElement { get => this.hrElement; set => this.hrElement = value; }
    }
}
