using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using Microsoft.EntityFrameworkCore;


namespace B2003C4.Data
{
    [Serializable]
    public class FormSearchDataModel
    {
        //MainLayout-----------------------------------------
        public Boolean HistoryBackState { get; set; } = false; //戻るボタンでページバックしたか
        //---------------------------------------------------


        //IriTome--------------------------------------------
        public Boolean IriActive { get; set; } = true;

        public Boolean TomeActive { get; set; } = true;

        public Boolean ButtonState = false;
        //---------------------------------------------------

        //端末情報用
        public int? Select_TenpoNo;

        //ローディング完了？
        public Boolean LoadingState = true; //trueが完了

        //画面制御用
        public Boolean State { get; set; } = false;

        public int? PhaseNo { get; set; } = 1;

        public string IndexURL { get; set; } ="Index"; //とび先のURL

        public string CurrentURL { get; set; } //とび前のURL


        public string ShiftReason { get; set; }
        public string Etc { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string Name { get; set; }

        /*
        [DataType(DataType.PhoneNumber)]
        [StringLength(4, ErrorMessage = "Name is too long.")]
        public string DokuCode { get; set; } = null;
        */

        //検索条件格納用
        public int? S_KuikiNo { get; set; } = null; //区域番号

        public int? S_Junro { get; set; } //順路（最初の４桁)

        public int S_KuikiJunro { get; set; }

        public string S_KuikiJunroView { get; set; }

        public int? S_DokuCode { get; set; } = null; //読者コード

        public string S_DokuName { get; set; } //読者名

        public string S_DokuKana { get; set; } //読者名

        public string S_DokuKbn { get; set; }

        public string S_Sigai { get; set; }

        public string S_Tel { get; set; }

        public int? S_ChomeiCode { get; set; }

        public string S_ChomeiName { get; set; } //町名

        public int? S_Banti { get; set; }

        public int? S_Gou { get; set; }

        public string S_BuildName { get; set; } //建物名

        public string S_BuildKana { get; set; } //建物名(カナ)

        public int? S_RoomNo { get; set; } //室番号

        public string[] CheckResult = new string[0] { };





        //保留-------------------------------------------------------------------------
        public int? S_Junro_Sub; //順路（最後の２桁）

        public uint? S_PhoneNo { get; set; } //未使用

        public string S_PhoneNo_Sub { get; set; } //電話番号4

        public string S_CityAddress { get; set; }

       

        //public List<string> CheckResult = new List<string>();


    }

}
