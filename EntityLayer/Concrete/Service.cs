namespace EntityLayer.Concrete {
    public class Service {
        public int ServiceId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}