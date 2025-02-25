using System.Text.Json;

namespace Sklep.Domain.Entities
    {
        public class ProductEntity :BaseEntity
        {
            public required string Name { get; set; }
            public required JsonDocument Description { get; set; }
            public required Guid PriceId { get; set; }
            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
            public required Guid CategoryId { get; set; }
            public required Guid UserId { get; set; }
            public required Guid AdressId { get; set; }

        #region Relationships

        public virtual required PriceEntity Price { get; set; }
        public virtual required ProductCategoryEntity ProductCategory { get; set; }
        public virtual required AdressEntity Adress { get; set; }
        public virtual required UserEntity User { get; set; }
        public virtual required List<ProductReviewEntity> ProductReview { get; set; }
        public virtual required List<OrderItemEntity> OrderItems { get; set; }
        public virtual required List<FileEntity> Images { get; set; }
        public virtual required List<CartItemEntity> CartItems { get; set; }

        #endregion
    }
}
