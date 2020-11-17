using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2003C4.Client.Data
{
    public class TempDataModel
    {
        public class Dokusya
        {
            public string DokusyaStatus; //読者の状態（現、休、止　等）

            //[StringLength(4, ErrorMessage = "Name is too long.")]
            public uint DokusyaCode; //読者コード


            public uint Kuiki; //区域
            public uint Junro;
            public uint Junro_Sub;
            public string DokusyaName; //読者名
            public string DokusyaKanaName; //読者名

            public uint PhoneNo;
            public string PhoneNo_Sub;

            public string CityName; //町名
            public string CityAddress; //町名以降
            public string CityFullName; //町名＋町名以降

            public string BuildingName;
            public string BuildingKanaName;
            public uint? ShitsuBan;
            public string M; // M（わからない）











        }
    }
}
