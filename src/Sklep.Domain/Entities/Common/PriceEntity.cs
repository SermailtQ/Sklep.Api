namespace Sklep.Domain.Entities
{
    public class PriceEntity : BaseEntity
    {
        public required Decimal UnitPrice { get; set; }
        public required Guid Quantity { get; set; }
        public required Guid DiscountPerUnit { get; set; }
        public required decimal TotalPrice { get; set; }

        #region Relationships

        public virtual required List<ProductEntity> Product { get; set; }
        public virtual required List<OrderItemEntity> OrderItems { get; set; }
        public virtual required List<CartItemEntity> Carts { get; set; }
        #endregion
    }
}
