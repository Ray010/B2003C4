using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace B2003C4.Client.Data
{
    public class DummyDataModel
    {
        public List<Dokusya> DokusyaList = new List<Dokusya>
        {
            new Dokusya("Gendoku",117,1,0001,00,"加藤　次男","ｶﾄｳ","080-0888-0088","戸部町1","9","","",null,"M"),
            new Dokusya("Gendoku",48,1,0002,00,"横浜市健康保険福祉総合センタ","ﾖｺﾊﾏｼ","0120-111-111","戸部町1","10","","",null,"M"),
            new Dokusya("Tome",49,1,0003,00,"（有）沼田石版印刷所","ﾕｳｹﾞﾝ","","戸部町1","8","","",null,"M"),
            new Dokusya("Kyudoku",122,1,0011,00,"入居","ｲﾘｽｴ","080-0000-0000","戸部町1","2","ヒルトップ","ﾋﾙﾄｯﾌﾟ",401,"M"),
            new Dokusya("Gendoku",52,1,0016,00,"川島　捷男","ｶﾜｼﾏ","012-345-6789","宮崎町","","伊勢山ハイツＡ棟","ｲｾﾔﾏﾊｲﾂｴｰﾄｳ",102,"M"),
            new Dokusya("Yoyaku",256,2,0001,00,"野口","ﾉｸﾞﾁ","03-6925-8147","紅葉町","44","紅葉坂レジデンス","ｺｳﾖｳｻｶﾚｼﾞﾃﾞﾝｽ",102,"M"),
            new Dokusya("Gendoku",269,2,0006,00,"横浜　三郎","ﾖｺﾊﾏ","070-7418-5236","紅葉町","44","紅葉坂レジデンス","ｺｳﾖｳｻｶﾚｼﾞﾃﾞﾝｽ",206,"M"),
            new Dokusya("Kyudoku",270,2,0013,00,"関　洋","ｾｷ","236-5478-9999","紅葉町","44","紅葉坂レジデンス","ｺｳﾖｳｻｶﾚｼﾞﾃﾞﾝｽ",409,"M"),
            new Dokusya("Huryou",5462,3,0001,00,"海老沼　綱紀","ｴﾋﾞﾇﾏ","38-6548-9875","武蔵野10","44-88","武蔵野タワー","ﾑｻｼﾉﾀﾜｰ",9901,"M"),
            new Dokusya("Junro",1975,4,0001,00,"田中　信","ﾀﾅｶ","48-6325-7458","桐生","1152","","",null,"M"),
            new Dokusya("Midoku",2422,5,001,00,"高久","ﾀｶｸ","028-658-8745","那須町","1110","","",null,"M"),
            new Dokusya("Kyudoku",1955,2,0099,00,"東京都庁","ﾄｳｷｮｳ","00-0000-0000","西新宿２丁目","8-1","","",null,"M"),
        };

        public class Dokusya
        {
            public string DokusyaStatus; //読者の状態（現、休、止　等）

            [StringLength(4, ErrorMessage = "Name is too long.")]
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

            public Dokusya(
                            string dokusyaStatus, //読者の状態
                            uint dokusyaCode, //読者番号
                            uint kuiki, //区域番号

                            uint junro, //順路（ハイフンより前）
                            uint junro_Sub,

                            string dokusyaName,
                            string dokusyaKanaName,

                            //uint phoneNo,
                            string phoneNo_Sub,

                            string cityName,
                            string cityAddress,

                            string buildingName,
                            string buildingKanaName,
                            uint? shitsuBan,

                            string m
                )
            {
                DokusyaStatus = dokusyaStatus; //読者の状態
                DokusyaCode = dokusyaCode; //読者番号
                Kuiki = kuiki; //区域番号
                Junro = junro; //順路（ハイフンより前）
                Junro_Sub = junro_Sub; // 順路（ハイフン以降）
                DokusyaName = dokusyaName; //読者名
                DokusyaKanaName = dokusyaKanaName;  //読者名（ｶﾅ）
                                                    //PhoneNo = phoneNo; //未定
                PhoneNo_Sub = phoneNo_Sub; //電話番号
                CityName = cityName; //町名
                CityAddress = cityAddress; //町名以降
                BuildingName = buildingName; //建物名
                BuildingKanaName = buildingKanaName; //建物名（ｶﾅ）
                ShitsuBan = shitsuBan; //室版
                CityFullName = cityName + cityAddress;
                M = m;
            }

        }


    }
}
