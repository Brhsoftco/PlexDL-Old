namespace PlexDL.Common
{
    public class AppOptions
    {
        public string Token { get; set; } = "";
        public string ServerAddress { get; set; } = "127.0.0.1";
        public int ServerPort { get; set; } = 32400;
        public string DownloadDirectory { get; set; } = "";

        public int AnimationSpeed = 10;

        public bool EnableXMLTransactionLogging { get; set; } = true;
        public bool EnableGenericLogDel { get; set; } = true;
        public decimal SkipForwardInterval { get; set; } = 30;
        public decimal SkipBackwardInterval { get; set; } = 10;
        public decimal DefaultFPSMath { get; set; } = 24;
        public int DefaultStringLength { get; set; } = 64;
        public bool PlayNextTitleAutomatically { get; set; } = true;

        public bool ShowConnectionSuccess { get; set; } = false;

        public int DownloadLayoutDefinition { get; set; } = 0;
    }
}