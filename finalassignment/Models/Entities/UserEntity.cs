namespace finalassignment.Models.Entities
{
    internal class UserEntity
    {
        public ICollection<CaseEntity> Cases { get; set; } = new List<CaseEntity>();
    }
}
