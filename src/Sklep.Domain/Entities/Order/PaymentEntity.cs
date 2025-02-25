namespace Sklep.Domain.Entities
{
    public class PaymentEntity : BaseEntity
    {
        public required Guid OrderId { get; set; }
        public required Guid UserId { get; set; }
        public required decimal Amount { get; set; }
        public required Guid PaymentTypeId { get; set; }
        public required Guid PaymentStatusId { get; set; }
        public required DateTime CraetedAt { get; set; } = DateTime.UtcNow;

        #region Relationships

        public virtual required UserEntity User { get; set; }
        public virtual required OrderEntity Order { get; set; }
        public virtual required PaymentStatusEntity PaymentStatus { get; set; }
        public virtual required PaymentTypeEntity PaymentType { get; set; }

        #endregion
    }
}
