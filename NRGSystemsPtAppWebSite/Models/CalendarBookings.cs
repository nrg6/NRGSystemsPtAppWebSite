namespace NRGSystemsPtAppWebSite.Models
{
    public class CalendarBookings
    {
        public int DayNumber { get; set; }
        public DateTime Date { get; set; }
        public bool IsEmpty { get; set; }
        public List<CalendarEvents> BookingEvents { get; set; }
    }
}
