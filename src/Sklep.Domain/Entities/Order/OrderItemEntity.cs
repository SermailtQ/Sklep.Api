namespace Sklep.Domain.Entities
{
    public class OrderItemEntity : BaseEntity
    {
        public required Guid ProductId { get; set; }
        public required Guid OrderId { get; set; }
        public required Guid PriceId { get; set; }

        #region Relationships

        public virtual required ProductEntity Product { get; set; }
        public virtual required OrderEntity Order { get; set; }
        public virtual required PriceEntity Price { get; set; }

        #endregion

    }
}
