using Microsoft.EntityFrameworkCore;
using Sklep.Domain.Entities;

namespace Sklep.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        DbSet<UserEntity> Users { get; set; }
        DbSet<RoleClaimEntity> RoleClaims { get; set; }
        DbSet<RoleEntity> Roles { get; set; }
        DbSet<ShippingEntity> Shippings { get; set; }
        DbSet<ProductCategoryEntity> ProductCategories { get; set; }
        DbSet<ProductEntity> Products { get; set; }
        DbSet<ProductImageEntity> ProductImages { get; set; }
        DbSet<ProductReviewEntity> ProductReviews { get; set; }
        DbSet<OrderEntity> Orders { get; set; }
        DbSet<OrderItemEntity> OrderItems { get; set; }
        DbSet<PaymentEntity> Payments { get; set; }
        DbSet<PaymentStatusEntity> PaymentStatuses { get; set; }
        DbSet<PaymentTypeEntity> PaymentTypes { get; set; }
        DbSet<AdressEntity> Adresses { get; set; }
        DbSet<FileEntity> Files { get; set; }
        DbSet<FileTypeEntity> FileTypes { get; set; }
        DbSet<PriceEntity> PriceEntities { get; set; }
        DbSet<ChatEntity> ChatEntities { get; set; }
        DbSet<ChatParticipants> ChatParticipants { get; set; }
        DbSet<ChatTypeEntity> ChatTypeEntities { get; set; }
        DbSet<EmojiEntity> EmojiEntities { get; set; }
        DbSet<FileMessageEntity> FileMessageEntities { get; set; }
        DbSet<MessageEntity> Messages { get; set; }
        DbSet<MessageReactionsEntity> MessageReactions { get; set; }
        DbSet<CartItemEntity> CartItems { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);




        }

    }
}
