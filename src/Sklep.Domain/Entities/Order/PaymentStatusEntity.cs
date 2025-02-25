namespace Sklep.Domain.Entities
{
    public class PaymentStatusEntity : BaseEntity
    {
        public required int Name { get; set; }
        public virtual required List<PaymentEntity> Payments { get; set; }
    }
}
