namespace Sklep.Domain.Entities
{
    public class ProductCategoryEntity : BaseEntity
    {
        public required string Name { get; set; }
        public required string Description { get; set; }

        #region Relationships
        public virtual required List<ProductEntity> Product { get; set; }
        #endregion

    }
}
