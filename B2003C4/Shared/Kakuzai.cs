using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B2003C4.Shared
{
    [Table("Kakuzai")]
    public class Kakuzai
    {
        [Key]
        [Column(Order = 0)]
        [Display(Name = "読者番号")]
        public double? DokuCode { get; set; }
        [Key]
        [Column(Order = 1)]
        public double? MgCode { get; set; }
        [Key]
        [Column(Order = 2)]
        public double? SeqNo { get; set; }

        public double? KetteisyaCD { get; set; }
        public string KetteisyaName { get; set; }
        public double? KansaCd { get; set; }
        public string KansaName { get; set; }
        public double? Cardryo { get; set; }
        public double? HinmeiCD1 { get; set; }
        [Display(Name = "品名")]
        public string HinmeiName1 { get; set; }
        [Display(Name = "日付")]
        public string HinmeiDate1 { get; set; }
        [Display(Name = "数量")]
        public double? HinmeiCnt1 { get; set; }
        public double? HinmeiCD2 { get; set; }
        public string HinmeiName2 { get; set; }
        public string HinmeiDate2 { get; set; }
        public double? HinmeiCnt2 { get; set; }
        public double? HinmeiCD3 { get; set; }
        public string HinmeiName3 { get; set; }
        public string HinmeiDate3 { get; set; }
        public double? HinmeiCnt3 { get; set; }
        public double? HinmeiCD4 { get; set; }
        public string HinmeiName4 { get; set; }
        public string HinmeiDate4 { get; set; }
        public double? HinmeiCnt4 { get; set; }
        public double? HinmeiCD5 { get; set; }
        public string HinmeiName5 { get; set; }
        public string HinmeiDate5 { get; set; }
        public double? HinmeiCnt5 { get; set; }
        public double? HinmeiCD6 { get; set; }
        public string HinmeiName6 { get; set; }
        public string HinmeiDate6 { get; set; }
        public double? HinmeiCnt6 { get; set; }
        public double? HinmeiCD7 { get; set; }
        public string HinmeiName7 { get; set; }
        public string HinmeiDate7 { get; set; }
        public double? HinmeiCnt7 { get; set; }
        public double? HinmeiCD8 { get; set; }
        public string HinmeiName8 { get; set; }
        public string HinmeiDate8 { get; set; }
        public double? HinmeiCnt8 { get; set; }
        public double? HinmeiCD9 { get; set; }
        public string HinmeiName9 { get; set; }
        public string HinmeiDate9 { get; set; }
        public double? HinmeiCnt9 { get; set; }
        public string Memo { get; set; }
        public string MgNo { get; set; }

    }
}
