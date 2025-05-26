namespace Blazor9CoreuiBlazorbootstrap.Services
{
    public class MainLayoutBreadcrumbService
    {
        public event Action<List<Models.BreadcrumbItem>>? OnValueChanged;

        public void SetValue(List<Models.BreadcrumbItem> value)
        {
            OnValueChanged?.Invoke(value);
        }
    }
}
