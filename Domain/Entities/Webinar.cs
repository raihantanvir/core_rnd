namespace Domain.Entities
{
    public class Webinar : BaseEntity
    {
        public string? Name { get; set; }
        public DateTime ScheduledOn { get; set; }
        public bool IsActive { get; set; }
    }
}