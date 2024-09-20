namespace NRGSystemsPtAppWebSite.Services
{
    public interface IAppDownloadService
    {
        Task<object> GetApp(string url);
    }
}
