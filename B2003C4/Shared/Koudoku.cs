using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B2003C4.Shared
{

    /* 画面で必要な項目
     * 読者番号(必須)：DokuCode    ：double
     * No            ：No          ：double
     * 銘柄No        ：MgNo        ：string
     * 銘柄名  　　　：MgName      ：string
     * 銘柄正式名称　：MgFullName  ：string
     * 契約期間(開始)：KeiyakuSt   ：string
     * 契約期間(終了)：KeiyakuEd   ：string
     * 契約区分　　　：KeiyakuKbn  ：string
     * 契約者　　　　：Keiyakusya　：string
     * 契約日    　　：KeiyakuDay  ：string
     * 入理由    　　：IriRiyuu    ：string
     * 配達日　　　  ：haitatubi   ：double
     * 止理由　　　　：TomeRiyuu   ：string
     * 止め日　　　　：TomeDay     ：string
     * 月数　　　    ：tukisu      ：double
     * 拡材No        ：KakuzaiNo   ：double
    */

    [Table("Koudoku")]
    public class Koudoku
    {
        [Key]
        [Column(Order = 0)]
        [Display(Name = "読者番号")]
        public double? DokuCode { get; set; }

        [Key]
        [Column(Order = 1)]
        public double? OyaMgCode { get; set; }

        [Key]
        [Column(Order = 2)]
        // MgNo: 銘柄No
        public string MgNo { get; set; }

        [Key]
        [Column(Order = 3)]
        // No: No
        public double? No { get; set; }

        [Key]
        [Column(Order = 4)]
        public double? MgCode { get; set; }
        
        // MgName: 銘柄名
        public string MgName { get; set; }
        
        // MgFullName: 銘柄正式名称
        public string MgFullName { get; set; }
        
        // KeiyakuSt: 契約期間(開始)
        public string KeiyakuSt { get; set; }
        
        // KeiyakuEd: 契約期間(終了)
        public string KeiyakuEd { get; set; }
        
        // KeiyakuKbn: 契約区分
        public string KeiyakuKbn { get; set; }
        
        // Keiyakusya: 契約者
        public string Keiyakusya { get; set; }
        
        // KeiyakuDay: 契約日
        public string KeiyakuDay { get; set; }
        
        // IriRiyuu: 入理由
        public string IriRiyuu { get; set; }
        
        // haitatubi: 配達日
        public double? haitatubi { get; set; }
        
        // TomeRiyuu: 止理由
        public string TomeRiyuu { get; set; }
        
        // TomeDay: 止め日
        public string TomeDay { get; set; }
        
        // tukisu: 月数
        public double? tukisu { get; set; }
        
        // 拡材No: KakuzaiNo
        public double? KakuzaiNo { get; set; }


    }
}
