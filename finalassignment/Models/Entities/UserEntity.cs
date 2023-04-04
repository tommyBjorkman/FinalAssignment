namespace finalassignment.Models.Entities
{
    internal class UserEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<CaseEntity> Cases { get; set; } = new List<CaseEntity>();
    }
}
