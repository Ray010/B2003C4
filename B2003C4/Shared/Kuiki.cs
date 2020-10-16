using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B2003C4.Shared
{

    /* 画面で必要な項目
    * 区域番号            ：kuiki     ：Double
    * 区域名              ：name      ：String
    */





    [Table("Kuiki")]
    public class Kuiki
    {

        [Key]
        [Display(Name = "区域番号")]
        public double? kuiki { get; set; }

        [Display(Name = "区域名")]
        public string name { get; set; }



    }
}
