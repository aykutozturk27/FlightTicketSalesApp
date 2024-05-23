using Newtonsoft.Json;

namespace FlightTicketSalesApp.MvcWebUI.Extensions
{
    public static class SessionExtensions
    {
        public static void SetObject(this ISession session, string sessionname, object value)
        {
            session.SetString(sessionname, JsonConvert.SerializeObject(value));
        }

        public static T? GetObject<T>(this ISession session, string sessionname)
        {
            var value = session.GetString(sessionname);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
