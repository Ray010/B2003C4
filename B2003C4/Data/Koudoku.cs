using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2003C4.Data
{
    public class Koudoku
    {
        public uint DokuCode { get; set; } //読者番号
        public uint OyaMgCode { get; set; } //親銘版コード
        public string MgNo { get; set; } //銘版No
        public uint No { get; set; } //#(?)
        public uint MgCode { get; set; }  //銘版コード
        public uint Busuu { get; set; } //部数
        public string KeiyakuSt { get; set; } //契約開始
        public string KeiyakuEd { get; set; } //契約終了
        public string Keiyakusya { get; set; } //契約者名
        public string KeiyakuDay { get; set; } //契約日付
        public string IriRiyuu { get; set; } //入理由
        public string TomeRiyuu { get; set; } //止理由
        public string TomeDay { get; set; }　//止日
        public string MgName { get; set; } //銘版名
        public uint GaitoFlg { get; set; } //該当フラグ
        public uint KakuzaiNo { get; set; } //拡材No
        public string Kubun { get; set; } //区分
        public uint Tsukisu { get; set; } //月数
        public string Haitatsubi { get; set; } //配達日
        public string DispHaitatsu { get; set; } //表示配達日
        public string KeiyakuKbn { get; set; } //契約区分
        public string MgFullName { get; set; } //銘版正式名称


        public Koudoku(
            uint dokuCode,
            uint oyaMgCode,
            string mgNo,
            uint mgCode,
            uint busuu,
            string keiyakuSt,
            string keiyakuEd,
            string keiyakusya,
            string iriRiyuu,
            string tomeRiyuu,
            string tomeDay,
            string mgName,
            uint gaitoFlg,
            uint kakuzaiNo,
            string kubun,
            uint tsukisu,
            string haitatsubi,
            string dispHaitatsu,
            string keiyakukbn,
            string mgFullName)
        {
            DokuCode = dokuCode;
            OyaMgCode = oyaMgCode;
            MgNo = mgNo;
            MgCode = mgCode;
            Busuu = busuu;
            KeiyakuSt = keiyakuSt;
            KeiyakuEd = keiyakuEd;
            Keiyakusya = keiyakusya;
            IriRiyuu = iriRiyuu;
            TomeRiyuu = tomeRiyuu;
            TomeDay = tomeDay;
            MgName = mgName;
            GaitoFlg = gaitoFlg;
            KakuzaiNo = kakuzaiNo;
            Kubun = kubun;
            Tsukisu = tsukisu;
            Haitatsubi = haitatsubi;
            DispHaitatsu = dispHaitatsu;
            KeiyakuKbn = keiyakukbn;
            MgFullName = mgFullName;
        }



    }
}
