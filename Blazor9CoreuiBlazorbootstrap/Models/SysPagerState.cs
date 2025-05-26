namespace Blazor9CoreuiBlazorbootstrap.Models
{
    public class SysPagerState
    {
        public int SkipValue { get; set; } = 0;
        public int TakeValue { get; set; } = 10;
        public int TotalItemCount { get; set; } = 0;
        // public int PageSize { get; set; } = 10;
        public int CurrPageNumber { get; set; } = 1;

        public string Filter { get; set; } = "";

        public int TotalPages
        {
            get
            {
                if (TotalItemCount < TakeValue)
                    return 1;

                if (TotalItemCount % TakeValue == 0)
                    return ((TotalItemCount) / TakeValue);

                return ((TotalItemCount + 1) / TakeValue);
            }
        }

    }
}
