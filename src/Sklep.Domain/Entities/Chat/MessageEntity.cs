namespace Sklep.Domain.Entities
{
    public class MessageEntity : BaseEntity
    {
        public required Guid ChatId { get; set; }
        public required Guid SenderId { get; set; }
        public required string Content { get; set; }
        public DateTime SentAt { get; set; } = DateTime.UtcNow;
        public bool isRead { get; set; } = false;

        #region Relationships
        public virtual required List<MessageReactionsEntity> Message { get; set; }
        public virtual required UserEntity Sender { get; set; }
        public virtual required ChatEntity Chat { get; set; }
        public virtual required List<FileEntity> Files { get; set; }
        #endregion
    }
}
