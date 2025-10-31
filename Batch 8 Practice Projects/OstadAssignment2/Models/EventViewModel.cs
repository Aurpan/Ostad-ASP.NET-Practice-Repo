namespace OstadAssignment2.Models
{
    public class EventViewModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public string? Address { get; set; }
        public UserViewModel? AssignedUser { get; set; }
    }
}
