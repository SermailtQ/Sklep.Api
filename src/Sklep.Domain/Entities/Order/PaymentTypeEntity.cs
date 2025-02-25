namespace Sklep.Domain.Entities
{
    public class PaymentTypeEntity : BaseEntity
    {
        public required int Name { get; set; }

        public virtual required List<PaymentEntity> Payments { get; set; }
    }
}
