using NRGSystemsPtAppWebSite.Models;

namespace NRGSystemsPtAppWebSite.Services
{
    public class CalendarFunctionServices : ICalendarFunctionServices
    {

        readonly HttpClient _functionClient;
        readonly HttpClient _localClient;

        public CalendarFunctionServices()
        {
            _functionClient = new HttpClient
            {
                BaseAddress = new Uri("https://exercisefunction.azurewebsites.net/")
            };
            _localClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:7074/")
            };
        }

        public async Task<bool> CreateACalendarEvent(CalendarEvents calendarEvents)
        {
            try
            {
                var a = await _functionClient.GetFromJsonAsync<bool>(
                //var a = await _localClient.GetFromJsonAsync<bool>(
                    $"api/CreateACalendarEvent?NumberOfEvents={calendarEvents.NumberOfEvents}&" +
                    $"IsEmpty={calendarEvents.IsEmpty}&" +
                    $"DateBookingMade={calendarEvents.DateBookingMade}&" +
                    $"BookingDate={calendarEvents.BookingDate}&" +
                    $"StartTime={calendarEvents.StartTime}&" +
                    $"Duration={calendarEvents.Duration}&" +
                    $"Goal={calendarEvents.Goal}&" +
                    $"BookingClient={calendarEvents.BookingClientId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
                return false;
            }
            return true;
        }

        public async Task<string> EditACalendarEvent(CalendarEvents calendarEvents)
        {
            //string query = await _localClient.GetFromJsonAsync<string>(
            string query = await _functionClient.GetFromJsonAsync<string>(
                    $"api/CreateACalendarEvent?NumberOfEvents={calendarEvents.NumberOfEvents}&" +
                    $"IsEmpty={calendarEvents.IsEmpty}&" +
                    $"DateBookingMade={calendarEvents.DateBookingMade}&" +
                    $"BookingDate={calendarEvents.BookingDate}&" +
                    $"StartTime={calendarEvents.StartTime}&" +
                    $"Duration={calendarEvents.Duration}&" +
                    $"Goal={calendarEvents.Goal}&" +
                    $"BookingClient={calendarEvents.BookingClientId}");

            try
            {
                await _functionClient.GetFromJsonAsync<bool>(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
                return ex.Message;
            }

            return "OK";
        }

        public async Task<List<CalendarEvents>> GetAllCalendarEvent()
        {
            var calendarEvents = new List<CalendarEvents>();
            try
            {
                var iffycalendarEvents = await _functionClient.GetFromJsonAsync<List<NewCalendarEvents>>("api/GetAllCalendarEvent");
               // var iffycalendarEvents = await _localClient.GetFromJsonAsync<List<NewCalendarEvents>>("api/GetAllCalendarEvent");

                foreach (var ifs in iffycalendarEvents)
                {
                    CalendarEvents ifEv = new()
                    {
                        BookingClientId = ifs.BookingClientId,
                        BookingDate = ifs.BookingDate,
                        CalendarEventId = ifs.CalendarEventId,
                        DateBookingMade = ifs.DateBookingMade,
                        Duration = ifs.Duration,
                        Goal = ifs.Goal,
                        IsEmpty = ifs.IsEmpty,
                        NumberOfEvents = ifs.NumberOfEvents,
                        StartTime = ifs.StartTime
                    };
                    calendarEvents.Add(ifEv);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return calendarEvents;
        }

        public async Task<CalendarEvents> GetACalendarEvent(DateTime bookingDate)
        {
            try
            {
                //return await _localClient.GetFromJsonAsync<CalendarEvents>(
                return await _functionClient.GetFromJsonAsync<CalendarEvents>(
                    $"api/GetACalendarEvent?BookingDate={bookingDate}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new CalendarEvents();
            }
        }

        public async Task<string> DeleteACalendarEvent(int CalendarEventId)
        {
            try
            {
                //await _localClient.GetFromJsonAsync<string>(
                await _functionClient.GetFromJsonAsync<string>(
                    $"api/DeleteACalendarEvent?CalendarEventId={CalendarEventId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
                return ex.Message;
            }
            return "OK";
        }

        public async Task<CalendarEvents> GetClientsCalendarEvents(int BookingClientsId)
        {
            try
            {
                return await _functionClient.GetFromJsonAsync<CalendarEvents>(
                    $"api/GetClientsCalendarEvents?BookingClientId={BookingClientsId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new CalendarEvents();
            }
        }
    }
}


