using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B2003C4.Shared
{
    [Table("Nengetu")]
    public class Nengetu
    {

        [Key]
        public double? no { get; set; }

        public double? nengetu { get; set; }
        
        public string name { get; set; }

    }
}
