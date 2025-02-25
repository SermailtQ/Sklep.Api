namespace Sklep.Domain.Entities
{
    public class MessageReactionsEntity : BaseEntity
    {
        public required Guid MessageID { get; set; }
        public required Guid UserId { get; set; }
        public required Guid EmojiId { get; set; }

        #region Relationships

        public virtual required MessageEntity Message {  get; set; }
        public virtual required UserEntity User {  get; set; }
        public virtual required EmojiEntity Emoji {  get; set; }

        #endregion

    }
}
