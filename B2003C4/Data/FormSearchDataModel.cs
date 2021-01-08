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



        //画面制御用
        public Boolean State { get; set; } = false;

        public int? PhaseNo { get; set; } = 1;

        public string IndexURL { get; set; } ="Index"; //とび先のURL

        public string CurrentURL { get; set; } //とび前のURL


        public string ShiftReason { get; set; }
        public string Etc { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(4, ErrorMessage = "Name is too long.")]
        public string DokuCode { get; set; } = null;


        //検索条件格納用
        public int? S_DokusyaCode = null; //読者コード

        public uint? S_KuikiNo = null; //区域番号

        public uint? S_Junro; //順路（最初の４桁)

        public uint? S_Junro_Sub; //順路（最後の２桁）

        public string S_DokusyaName; //読者名

        public string S_DokusyaKanaName; //読者名

        public uint? S_PhoneNo; //未使用

        public string S_PhoneNo_Sub; //電話番号4

        public string S_CityName; //町名

        public string S_CityAddress;

        public string S_BuildingName; //建物名

        public string S_BuildingKanaName; //建物名(カナ)

        public uint? S_ShitsuBan;

        public string[] CheckResult = new string[0] { };

        //public List<string> CheckResult = new List<string>();


    }

}
