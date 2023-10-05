using ResumeMgnt.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace ResumeMgnt.Core.Models
{
    public class Company : BaseEntity
    {
        [Key]
        public Guid CompanyId { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public CompanySize? Size { get; set; }

        // Relations
        public virtual ICollection<Job>? Jobs { get; set; }
    }
}
