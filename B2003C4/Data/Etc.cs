using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B2003C4.Data
{
    [Table("TenpoInfo", Schema = "dbo")]
    public class TenpoInfo
    {
        
        [Key]
        [Column("Tenpo")]
        public int Tenpo { get; set; }

        //Junro
        [Column("TenpoName")]
        public string TenpoName { get; set; }

    }





    public class Etc
    {
    }
}
