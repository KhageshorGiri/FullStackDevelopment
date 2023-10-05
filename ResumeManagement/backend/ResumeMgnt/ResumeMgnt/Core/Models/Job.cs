using Microsoft.Extensions.Logging;
using ResumeMgnt.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace ResumeMgnt.Core.Models
{
    public class Job : BaseEntity
    {
        [Key]
        public Guid JobId { get; set; } = Guid.NewGuid();
        public string? Title { get; set; }
        public JobLevel? Level { get; set; }

        // Relations
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }

        public virtual ICollection<Candidate>? Candidates { get; set; }
    }
}
