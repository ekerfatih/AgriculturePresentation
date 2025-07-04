namespace EntityLayer.Concrete {
    public class Announcement {
        public int AnnouncementId { get; set; }
        public string Title { get; set; } =null!;
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}