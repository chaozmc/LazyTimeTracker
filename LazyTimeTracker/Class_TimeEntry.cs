using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyTimeTracker
{
    public class TimeEntry
    {
        private DateTime startTime;
        private DateTime endTime;
        private BookingElement bookingElement;
        private string invoice;
        private string description;

        public TimeEntry(DateTime STime, DateTime ETime, BookingElement OBookingElement, string SInvoice, string SDescription)
        {
            this.startTime = STime;
            this.endTime = ETime;
            this.bookingElement = OBookingElement;
            this.invoice = SInvoice;
            this.description = SDescription;
        }

        public TimeEntry()
        {
            this.startTime = DateTime.MinValue;
            this.endTime = DateTime.MaxValue;
            this.bookingElement = new BookingElement();
            this.invoice = "";
            this.description = ""; 
        }


        public DateTime StartTime { get => this.startTime; set => this.startTime = value; }
        public DateTime EndTime { get => this.endTime; set => this.endTime = value; }
        public BookingElement BookingElement { get => this.bookingElement; set => this.bookingElement = value; }
        public string Invoice { get => this.invoice; set => this.invoice = value; }
        public string Description { get => this.description; set => this.description = value; }
        public string HRElement { get => this.bookingElement.HRElement; set => this.bookingElement.HRElement = value; }
        public string TimeElement { get => this.bookingElement.TimeElement; set => this.bookingElement.TimeElement = value; }
    }

    public class BookingElement
    {
        private string displayName;
        private string timeElement;
        private string hrElement;

        public BookingElement()
        {
            this.displayName = "";
            this.timeElement = "";
            this.hrElement = "";
        }

        public BookingElement(string SDisplayName, string STimeElement, string SHrElement)
        {
            this.displayName = SDisplayName;
            this.timeElement = STimeElement;
            this.hrElement = SHrElement;
        }

        public string TimeElement { get => this.timeElement; set => this.timeElement = value; }
        public string HRElement { get => this.hrElement; set => this.hrElement = value; }
        public string DisplayName { get => this.displayName; set => this.displayName = value; }


        public override string ToString()
        {
            return this.DisplayName + " <" + this.timeElement + " | " + this.hrElement + ">";
        }

    }

    public class Settings
    {
        public IList<BookingElement> bookingElements;
        public IList<string> Einkaufsbelege;

        public Settings ()
        {
            bookingElements = new System.ComponentModel.BindingList<BookingElement>();
            Einkaufsbelege = new System.ComponentModel.BindingList<string>();
        }
    }
    
}
