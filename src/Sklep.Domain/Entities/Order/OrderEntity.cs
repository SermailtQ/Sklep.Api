namespace Sklep.Domain.Entities
{
    public class OrderEntity : BaseEntity
    {
        public required int UserId { get; set; }
        public required Decimal Amount { get; set; }

        #region Relationships
        public virtual required List<OrderItemEntity> OrderItems { get; set; }
        public virtual required List<PaymentEntity> Payments { get; set; }
        public virtual required List<ShippingEntity> Shippings { get; set; }
        public virtual required UserEntity User { get; set; }
        #endregion

    }
}
