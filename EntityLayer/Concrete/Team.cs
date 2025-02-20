namespace EntityLayer.Concrete {
    public class Team {
        public int TeamId { get; set; }
        public string PersonName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public string? FacebookUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? TwitterUrl { get; set; }
    }
}