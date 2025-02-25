namespace Sklep.Domain.Entities
{
    public class ShippingStatusEntity : BaseEntity
    {
        public required string Name { get; set; }

        public virtual required List<ShippingEntity> Shippings { get; set; }
    }
}
