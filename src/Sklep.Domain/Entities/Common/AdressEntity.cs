namespace Sklep.Domain.Entities
{
    public class AdressEntity : BaseEntity
    {
        public required string Country { get; set; }
        public required string City { get; set; }
        public required string Adress { get; set; }
        public required string PostalCode { get; set; }

        #region Relationships

        public virtual required List<UserEntity> User { get; set; }
        public virtual required List<ShippingEntity> Shippings { get; set; }
        public virtual required List<ProductEntity> Products { get; set; }

        #endregion
    }
}
