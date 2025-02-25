namespace Sklep.Domain.Entities
{
    public class ChatEntity : BaseEntity
    {
        public required Guid ChatTypeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public required Guid CreatedById { get; set; }

        #region Relationships

        public required virtual ChatTypeEntity ChatType { get; set; }
        public required virtual List<ChatParticipants> ChatParticipants { get; set; }
        public required virtual UserEntity User { get; set; }
        public virtual required List<MessageEntity> Message { get; set; }
        #endregion
    }
}
