

namespace School.Domain.Entities
{
    public abstract class AuditableEntity
    {

        public DateTime CreationDate { get; set; }

        public DateTime CreationUser { get; set; }

        public int UserMod { get; set; }

    }
}
