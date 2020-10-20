using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


/* 画面で必要な項目
* キーモバイルNo      ：KeyMobileNo  ：String
* 順番                ：Idx  　      ：String
* 有効期限 　　　     ：ValidTerm    ：String
* モーバイル数        ：MobileCnt    ：String (牛？）
* 処理日付け          ：SyoriYMD     ：String 
*/

namespace B2003C4.Shared
{
    [Table("TakeOutCount")]
    public class TakeOutCount
    {
        /*  Settingにて入手済みのため
            [Key]
            [Display(Name = "キーモバイルNo")]
            [Required(ErrorMessage = "モバイルキーナンバーを入力してください。")]
            public string KeyMobileNo { get; set; }
        */

            [Key]
            [Display(Name = "順番")]
            public string Idx { get; set; }

            [Display(Name = "有効期限")]
            public string ValidTerm { get; set; }

            [Display(Name = "モーバイル数")]
            public string MobileCnt { get; set; }

            [Display(Name = "処理日付け")]
            public string SyoriYMD { get; set; }
    }
}
