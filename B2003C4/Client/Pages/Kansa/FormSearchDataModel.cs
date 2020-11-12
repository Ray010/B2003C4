using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace B2003C4.Client.Pages.Kansa
{
    public class FormSearchDataModel
    {

        //画面制御用
        public uint? PhaseNo { get; set; }=1;

        public string ShiftReason { get; set; }
        public string Etc { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        public uint? DokuCode { get; set; } = null;


        //検索条件格納用

        public uint? DokusyaCode = null;
        
        public uint? KuikiNo = null;
        
        public uint? Junro;
        
        public uint? Junro_Sub;
        
        public string DokusyaName;
        
        public string DokusyaKanaName;
        
        public uint? PhoneNo;
        
        [DataType(DataType.PhoneNumber)]
        public string PhoneNo_Sub;
        
        public string CityName;
        
        public string CityAddress;
        
        public string BuildingName; //建物名
        
        public string BuildingKanaName; //建物名(カナ)
        
        public uint? ShitsuBan;

        public string[] CheckResult = new string[0] { };


    }
}
