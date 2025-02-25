namespace Sklep.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public DateTime RegisterAt { get; set; } = DateTime.UtcNow;
        public DateTime LastLogin { get; set; } = DateTime.UtcNow;
        public required DateTime DateOfBirth { get; set; }
        public bool EmailVerified { get; set; } = false;
        public bool Deactivated { get; set; } = false;
        public required Guid AdressId { get; set; }

        #region Relationships
        public virtual required List<MessageEntity> Messages { get; set; }
        public virtual required List<MessageReactionsEntity> MessageReactions { get; set; }
        public virtual required AdressEntity Adress { get; set; }
        public virtual required List<ProductReviewEntity> ProductReviews { get; set; }
        public virtual required List<ProductEntity> Products { get; set; }
        public virtual required List<ChatParticipants> ChatParticipants { get; set; }
        public virtual required List<ChatEntity> Chats { get; set; }
        public virtual required List<CartItemEntity> CartItems { get; set; }
        public virtual required List<PaymentEntity> Payments { get; set; }
        public virtual required List<ShippingEntity> Shippings { get; set; }
        public virtual required List<RoleClaimEntity> RoleClaims { get; set; }  
        public virtual required List<FileEntity> Files { get; set; }
        public virtual required List<OrderEntity> Orders { get; set; }
        #endregion
    }
}
