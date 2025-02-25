namespace Sklep.Domain.Entities
{
    public class ShippingEntity : BaseEntity
    {
        public required Guid UserId { get; set; }
        public required Guid OrderId { get; set; }
        public required string FullName { get; set; }
        public required Guid StatusId { get; set; }
        public required Guid AdressId { get; set; }

        #region Relationships
        public virtual required UserEntity User { get; set; } 
        public virtual required OrderEntity Order { get; set; }
        public virtual required ShippingStatusEntity Status { get; set; }
        public virtual required AdressEntity Adress { get; set; }

        #endregion

    }
}
