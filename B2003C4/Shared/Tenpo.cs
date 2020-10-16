using System.ComponentModel.DataAnnotations;

namespace B2003C4.Shared
{
    public class Tenpo
    {
        [Key]
        [Required]
        public int No { get; set; }

        [Required]
        public string TenpoName { get; set; }
    }
}
