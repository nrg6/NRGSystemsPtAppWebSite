namespace NRGSystemsPtAppWebSite.Handlers;
public class AppStateService
{
    private bool _isLoaded;

    public event Action? LoadStateChanged;

    public bool IsLoaded
    {
        get => _isLoaded;
        set
        {
            if (_isLoaded != value)
            {
                _isLoaded = value;
                LoadStateChanged?.Invoke();
            }
        }
    }
}
