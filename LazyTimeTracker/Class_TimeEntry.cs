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
        private bool vortag;
        private BookingElement bookingElement;
        private string abAnArt;
        private string invoice;
        private string description;

        public TimeEntry(DateTime STime, DateTime ETime, BookingElement OBookingElement, string SInvoice, string SDescription)
        {
            this.startTime = STime;
            this.endTime = ETime;
            this.bookingElement = OBookingElement;
            this.invoice = SInvoice;
            this.description = SDescription;
            this.vortag = false;
            this.abAnArt = "Ist-Zeit";
        }

        public TimeEntry()
        {
            this.startTime = DateTime.MinValue;
            this.endTime = DateTime.MaxValue;
            this.bookingElement = new BookingElement();
            this.invoice = "";
            this.description = "";
            this.vortag = false;
            this.abAnArt = "Ist-Zeit";
        }


        public string StartTime { get => this.startTime.ToShortTimeString(); set => this.startTime = DateTime.Parse(value); }
        public string EndTime { get => this.endTime.ToShortTimeString(); set => this.endTime = DateTime.Parse(value); }
        public string Vortag { get => ""; }
        public string AbAnArt { get => this.abAnArt; }
        public string TimeElement { get => this.bookingElement.TimeElement; set => this.bookingElement.TimeElement = value; }
        public string Auftragsbezeichnung { get => this.bookingElement.Auftragsbezeichnung; set => this.bookingElement.Auftragsbezeichnung = value; }
        public string LstArt { get => this.bookingElement.LstArt; set => this.bookingElement.LstArt = value; }
        public string Leistungsart { get => this.bookingElement.Leistungsart; set => this.bookingElement.Leistungsart = value; }
        public string Invoice { get => this.invoice; set => this.invoice = value; }
        public string Description { get => this.description; set => this.description = value; }
        public BookingElement BookingElement { get => this.bookingElement; set => this.bookingElement = value; }
    }

    public class BookingElement
    {
        private string auftragsbezeichnung;
        private string auftrag;
        private string lstArt;
        private string leistungsart;

        public BookingElement()
        {
            this.auftragsbezeichnung = "";
            this.auftrag = "";
            this.lstArt = "";
            this.leistungsart = "";
        }

        public BookingElement(string SDisplayName, string STimeElement, string SHrElement)
        {
            this.auftragsbezeichnung = SDisplayName;
            this.auftrag = STimeElement;
            this.lstArt = SHrElement;
            this.leistungsart = "";
        }

        public string TimeElement { get => this.auftrag; set => this.auftrag = value; }
        public string LstArt { get => this.lstArt; set => this.lstArt = value; }
        public string Auftragsbezeichnung { get => this.auftragsbezeichnung; set => this.auftragsbezeichnung = value; }
        public string Leistungsart { get => this.leistungsart; set => this.leistungsart = value; }


        public override string ToString()
        {
            return this.Auftragsbezeichnung;
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
