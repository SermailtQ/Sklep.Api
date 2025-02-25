namespace Sklep.Domain.Entities
{
    public class EmojiEntity : BaseEntity
    {
        public required string Emoji { get; set; }
        public virtual required List<MessageReactionsEntity> Message { get; set; }
    }
}
