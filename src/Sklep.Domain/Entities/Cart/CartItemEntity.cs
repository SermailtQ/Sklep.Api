namespace Sklep.Domain.Entities
{
    public class CartItemEntity : BaseEntity
    {
        public required Guid UserId { get; set; }
        public required Guid PriceId { get; set; }
        public required Guid ProductId { get; set; }
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;

        #region Relationships
        public virtual required UserEntity User { get; set; }
        public virtual required PriceEntity Price { get; set; }
        public virtual required ProductEntity Product { get; set; }

        #endregion

    }
}
