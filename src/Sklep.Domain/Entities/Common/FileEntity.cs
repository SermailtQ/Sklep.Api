namespace Sklep.Domain.Entities
{
    public class FileEntity
    {
        public required string FileUrl { get; set; }
        public required int Size { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public required Guid FileTypeId { get; set; }
        public required Guid UserId { get; set; }
        #region Relationships

        public virtual required FileTypeEntity FileType { get; set; }
        public virtual required List<MessageEntity> Messages { get; set; }

        public virtual required UserEntity User { get; set; }

        public virtual required List<ProductEntity> Products { get; set; }

        #endregion
    }
}
