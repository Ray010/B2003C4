using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B2003C4.Shared
{
    /* 画面で必要な項目
    * 顧客No              ：CustomerNo   ：String
    * キーモバイルNo      ：KeyMobileNo  ：String
    * FTPIPアドレス       ：FtpIP　      ：String
    * 許可数量　　　      ：LicenseCount ：Double
    * モーバイルパスワード：MobilePw     ：String (牛？）
    * モーバイル数        ：MobileCount  ：Double (午？）
    */

    [Table("Setting")]
    public class Setting
    {
        
        /*
        [Key]
        [Display(Name = "顧客No")]
        [Required(ErrorMessage = "顧客ナンバーを入力してください。")]
        public string CustomerNo { get; set; }
        */


        [Key]
        [Display(Name = "キーモバイルNo")]
        [Required(ErrorMessage ="モバイルキーナンバーを入力してください。")]
        public string KeyMobileNo { get; set; }

        [Required]
        [Display(Name = "FTPIPアドレス")]
        public string FtpIp { get; set; }

        [Required]
        [Display(Name = "許可数量")]
        public int LicenseCount { get; set; }

        [Required]
        [Display(Name = "モーバイルパスワード")]
        public string MobilePw { get; set; }

        [Required]
        [Display(Name = "モーバイル数")]
        public int MobileCount { get; set; }
    }
}

