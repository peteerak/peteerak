namespace kafer_house.Helper
{
    public class Alert
    {
        public const string TempDataKey = "TempDataAlert";
        public string AlertStyle { get; set; }
        public string Message { get; set; }
        public bool Dismissable { get; set; }
        
    }

    public static class AlertStyles 
    {
        public const string Success = "success";
        public const string Information = "info";
        public const string Warning = "warning";
        public const string Danger = "danger";
        
    }
}