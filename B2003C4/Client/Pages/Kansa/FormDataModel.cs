using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace B2003C4.Client.Pages.Kansa
{
    public class FormDataModel
    {

        public uint? PhaseNo { get; set; }=1;

        [DataType(DataType.PhoneNumber)]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        public uint? DokuCode { get; set; } = null;

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

        public string CheckResult;


    }
}
