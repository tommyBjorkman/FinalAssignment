namespace finalassignment.Models.Entities
{
    internal class CaseEntity
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerEmail { get; set; } = null!;
        public string? CustomerPhone { get; set; }
        public string? CustomerCompany { get; set; }
        public int StatusId { get; set; }
        public StatusEntity Status { get; set; } = null!;
        public int UserID { get; set; }
        public UserEntity User { get; set; } = null!;
    }
}
