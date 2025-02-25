namespace Sklep.Domain.Entities
{
    public class FileTypeEntity : BaseEntity
    {
        public required string Name { get; set; }

        public virtual required List<FileEntity> Files { get; set; }
    }
}
