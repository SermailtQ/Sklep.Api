namespace Sklep.Domain.Entities
{
    public class ChatTypeEntity : BaseEntity
    {
        public required string Name { get; set; }

        #region Relationships

        public virtual required List<ChatEntity> Chats { get; set; }

        #endregion
    }
}
