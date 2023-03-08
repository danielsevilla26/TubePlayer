namespace TubePlayer.Models
{
    public static class Constants
    {
        public static string ApplicationName = "Tube Player";
        public static string EmailAddress = @"HERE_YOUR_EMAIL_ADDRESS";
        public static string ApplicationId = "HERE_YOUR_APPLICATION_ID";
        public static string ApiServiceURL = @"https://youtube.googleapis.com/youtube/v3/";
        public static string ApiKey = @"HERE_YOUR_API_KEY";


        public static uint MicroDuration { get; set; } = 100;
        public static uint SmallDuration { get; set; } = 300;
        public static uint MediumDuration { get; set; } = 600;
        public static uint LongDuration { get; set; } = 1200;
        public static uint ExtraLongDuration { get; set; } = 1800;
    }
}
