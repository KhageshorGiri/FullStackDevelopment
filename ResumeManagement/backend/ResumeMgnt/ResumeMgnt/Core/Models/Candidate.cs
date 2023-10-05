using System.ComponentModel.DataAnnotations;

namespace ResumeMgnt.Core.Models
{
    public class Candidate : BaseEntity
    {
        [Key]
        public Guid CandidateId { get; set; } = Guid.NewGuid();
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? Phone { get; set; } = string.Empty;
        public string? CoverLetter { get; set; } = string.Empty;
        public string? ResumeUrl { get; set; } = string.Empty;

        // Relations
        public Guid JobId { get; set; }
        public Job? Job { get; set; }
    }
}
