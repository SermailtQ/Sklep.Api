namespace Sklep.Domain.Entities
{
    public class ProductReviewEntity : BaseEntity
    {
        public required Guid UserId { get; set; }
        public required Guid ProductId { get; set; }
        public required string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public required double Stars { get; set; }

        #region Relationships
        public virtual required ProductEntity Product { get; set; }
        public virtual required UserEntity User { get; set; }
        #endregion
    }
}
