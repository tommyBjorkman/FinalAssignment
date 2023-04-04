namespace finalassignment.Models.Entities
{
    internal class CaseEntity
    {
        public int StatusId { get; set; }
        public StatusEntity Status { get; set; } = null!;
    }
}
