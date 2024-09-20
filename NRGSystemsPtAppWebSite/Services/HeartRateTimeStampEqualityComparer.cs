using NRGSystemsPtAppWebSite.Models;

namespace NRGSystemsPtAppWebSite.Services
{

    public class HeartRateTimeStampEqualityComparer : IEqualityComparer<HeartRateStorage>
    {
        public bool Equals(HeartRateStorage x, HeartRateStorage y)
        {
            return x.HeartRateTimeStamp == y.HeartRateTimeStamp;
        }

        public int GetHashCode(HeartRateStorage obj)
        {
            return obj.HeartRateTimeStamp.GetHashCode();
        }
    }
}
