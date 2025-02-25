namespace Sklep.Domain.Entities
{
    public class RoleEntity : BaseEntity
    {
        public required string Name { get; set; }

        public virtual required List<RoleClaimEntity> RoleClaims { get; set; }
    }
}
