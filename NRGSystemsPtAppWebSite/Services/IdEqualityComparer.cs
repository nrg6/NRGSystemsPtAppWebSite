using NRGSystemsPtAppWebSite.Models;

namespace NRGSystemsPtAppWebSite.Services
{

    public class IdEqualityComparer : IEqualityComparer<ClientsProgram>
    {
        public bool Equals(ClientsProgram x, ClientsProgram y)
        {
            return x.ProgramTitle == y.ProgramTitle;
        }

        public int GetHashCode(ClientsProgram obj)
        {
            return obj.ProgramTitle.GetHashCode();
        }
    }
}
