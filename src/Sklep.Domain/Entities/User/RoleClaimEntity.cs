namespace Sklep.Domain.Entities
{
    public class RoleClaimEntity
    {
        public required Guid UserId { get; set; }
        public required Guid RoleId { get; set; }

        public virtual required UserEntity User { get; set; }
        public virtual required RoleEntity Role { get; set; }
    }
}
