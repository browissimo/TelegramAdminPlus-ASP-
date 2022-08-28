namespace TelegramAdminPlus_ASP_.Models
{
    public class LikeActivityBindingModel
    {
        public string? ChannelName { get; set; }
        public string? InitialMessage { get; set; }
        public string? FinalMessage { get; set; }
        public int Step { get; set; }
        public string? FolderPath { get; set; }
        public bool TimeRadio { get; set; }
        public bool CountRadio { get; set; }
        public int maxMinutes { get; set; }
        public int MaxPosts { get; set; }

    }
}
