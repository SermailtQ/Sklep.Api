namespace Sklep.Domain.Entities
{
    public class ChatParticipants : BaseEntity
    {
        public required Guid UserId { get; set; }
        public required Guid ChatId { get; set; }
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        #region Relationships
        public virtual required UserEntity User { get; set; }
        public virtual required ChatEntity Chat { get; set; }
        #endregion

    }
}
