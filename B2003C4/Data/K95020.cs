﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//本番環境ではcolumn項のイニシャルが大文字


namespace B2003C4.Data
{
    [Table("Tome_K95020", Schema = "dbo")]
    public class Tome_K95020 
    {
        [Column("Tenpo")]
        public int? Tenpo { get; set; }

        [Column("kuiki")]
        public int? Kuiki { get; set; }

        //[Column("Nengetu")]
        [Column("nengetu")]
        public int? Nengetu { get; set; }

        //Junro
        [Column("junro")]
        public string Junro { get; set; }

        //DokuCode
        [Key]
        [Column("dokuCode")]
        public int? DokuCode { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("tel")]
        public string Tel { get; set; }

        [Column("meig")]
        public string Meig { get; set; }

        [Column("iri")]
        public string iri { get; set; }

        [Column("tome")]
        public string tome { get; set; }

        [Column("tantokbn")]
        public int? Tantokbn { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("build")]
        public string Build { get; set; }

        [Column("MgCode")]
        public int? MgCode { get; set; }

        [Column("MgNo")]
        public string MgNo { get; set; }

        [Column("IriRiyuu")]
        public string IriRiyuu { get; set; }

        [Column("KeizokuTuki")]
        public int? KeizokuTsuki { get; set; }

        [Column("DispNengetu")]
        public string DispNengetu { get; set; }

        [Column("NextKeiyaku")]
        public int? NextKeiyaku { get; set; }

        [Column("GaitoNo")]
        public int? GaitoNo { get; set; }

    }

    [Table("Dokusya_K95020", Schema = "dbo")]
    public class Dokusya_K95020 : Dokusya_K95010
    {
        /*
        [Column("Tenpo")]
        public int? Tenpo { get; set; }

        [Column("Kuiki")]
        public int? Kuiki { get; set; }

        [Column("Junro")]
        public string Junro { get; set; }

        [Key]
        [Column("DokuCode")]
        public int? DokuCode { get; set; }
        
        [Column("Name")]
        public string Name { get; set; }

        [Column("Tel")]
        public string Tel { get; set; }

        [Column("Address")]
        public string Address { get; set; }

        [Column("AddressRyaku")]
        public string AddressRyaku { get; set; }

        [Column("Banti")]
        public string Banti { get; set; }

        [Column("Build")]
        public string Build { get; set; }

        [Column("Misebi1")]
        public string Misebi1 { get; set; }

        [Column("Misebi2")]
        public string Misebi2 { get; set; }

        [Column("Misebi3")]
        public string Misebi3 { get; set; }

        [Column("Syumemo1")]
        public string Syumemo1 { get; set; }

        [Column("Syumemo2")]
        public string Syumemo2 { get; set; }

        [Column("Syumemo3")]
        public string Syumemo3 { get; set; }

        [Column("Bunrui")]
        public string Bunrui { get; set; }

        [Column("Rank")]
        public string Rank { get; set; }

        [Column("Kaiin")]
        public string Kaiin { get; set; }

        [Column("Syoken")]
        public string Syoken { get; set; }

        [Column("Siharai")]
        public string Iri { get; set; }

        [Column("DokuMemo")]
        public string DokuMemo { get; set; }

        [Column("Zu_Bekki")]
        public int? Zu_Bekki { get; set; }
        */

    }

    [Table("Koudoku_K95020", Schema = "dbo")]
    public class Koudoku_K95020 : Koudoku_K95010
    {
        [Column("Tenpo")]
        public int? Tenpo { get; set; }

        [Key]
        [Column("DokuCode")]
        public int? DokuCode { get; set; }

        [Column("OyaMgCode")]
        public int? OyaMgCode { get; set; }

        [Column("MgNo")]
        public string MgNo { get; set; }

        [Column("No")]
        public int? No { get; set; }

        [Column("MgCode")]
        public int? MgCode { get; set; }

        [Column("Busuu")]
        public int? Busuu { get; set; }

        [Column("KeiyakuSt")]
        public string KeiyakuSt { get; set; }

        [Column("KeiyakuEd")]
        public string KeiyakuEd { get; set; }

        [Column("Keiyakusya")]
        public string Keiyakusya { get; set; }

        [Column("KeiyakuDay")]
        public string KeiyakuDay { get; set; }

        [Column("IriRiyuu")]
        public string IriRiyuu { get; set; }

        [Column("TomeRiyuu")]
        public string TomeRiyuu { get; set; }

        [Column("TomeDay")]
        public string TomeDay { get; set; }

        [Column("MgName")]
        public string MgName { get; set; }

        [Column("GaitoFlg")]
        public int? GaitoFlg { get; set; }

        [Column("KakuzaiNo")]
        public int? KakuzaiNo { get; set; }

        [Column("Kubun")]
        public string Kubun { get; set; }

        [Column("Tukisu")]
        public int? Tukisu { get; set; }

        [Column("Haitatubi")]
        public int? Haitatubi { get; set; }

        [Column("DispHaitatubi")]
        public string DispHaitatubi { get; set; }

        [Column("KeiyakuKbn")]
        public string KeiyakuKbn { get; set; }

        [Column("MgFullName")]
        public string MgFullName { get; set; }
    }

    [Table("Kuiki_K95020", Schema = "dbo")]
    public class Kuiki_K95020
    {
        [Column("Tenpo")]
        public int? Tenpo { get; set; }

        [Key]
        [Column("kuiki")]
        public int? Kuiki { get; set; }

        [Column("Name")]
        public string Name { get; set; }
    }

    [Table("Nengetu_K95020", Schema = "dbo")]
    public class Nengetu_K95020
    {
        [Column("Tenpo")]
        public int? Tenpo { get; set; }

        [Key]
        [Column("No")]
        public int? No { get; set; }

        [Column("Nengetu")]
        public int? Nengetu { get; set; }

        [Column("Name")]
        public string Name { get; set; }

    }

    [Table("Kakuzai_K95020", Schema = "dbo")]
    public class Kakuzai_K95020 : Kakuzai_K95010
    {
        [Column("Tenpo")]
        public int? Tenpo { get; set; }

        [Key]
        [Column("DokuCode")]
        public int? DokuCode { get; set; }

        [Column("MgCode")]
        public int? MgCode { get; set; }

        [Column("SeqNo")]
        public int? SeqNo { get; set; }

        [Column("KetteisyaCD")]
        public int? KetteisyaCD { get; set; }

        [Column("KetteisyaName")]
        public string KetteisyaName { get; set; }

        [Column("KansaCd")]
        public int? KansaCd { get; set; }

        [Column("KansaName")]
        public string KansaName { get; set; }

        [Column("Cardryo")]
        public int? Cardryo { get; set; }

        [Column("HinmeiCD1")]
        public int? HinmeiCD1 { get; set; }

        [Column("HinmeiName1")]
        public string HinmeiName1 { get; set; }

        [Column("HinmeiDate1")]
        public string HinmeiDate1 { get; set; }

        [Column("HinmeiCnt1")]
        public int? HinmeiCnt1 { get; set; }

        [Column("HinmeiCD2")]
        public int? HinmeiCD2 { get; set; }

        [Column("HinmeiName2")]
        public string HinmeiName2 { get; set; }

        [Column("HinmeiDate2")]
        public string HinmeiDate2 { get; set; }

        [Column("HinmeiCnt2")]
        public int? HinmeiCnt2 { get; set; }

        [Column("HinmeiCD3")]
        public int? HinmeiCD3 { get; set; }

        [Column("HinmeiName3")]
        public string HinmeiName3 { get; set; }

        [Column("HinmeiDate3")]
        public string HinmeiDate3 { get; set; }

        [Column("HinmeiCnt3")]
        public int? HinmeiCnt3 { get; set; }

        [Column("HinmeiCD4")]
        public int? HinmeiCD4 { get; set; }

        [Column("HinmeiName4")]
        public string HinmeiName4 { get; set; }

        [Column("HinmeiDate4")]
        public string HinmeiDate4 { get; set; }

        [Column("HinmeiCnt4")]
        public int? HinmeiCnt4 { get; set; }

        [Column("HinmeiCD5")]
        public int? HinmeiCD5 { get; set; }

        [Column("HinmeiName5")]
        public string HinmeiName5 { get; set; }

        [Column("HinmeiDate5")]
        public string HinmeiDate5 { get; set; }

        [Column("HinmeiCnt5")]
        public int? HinmeiCnt5 { get; set; }

        [Column("HinmeiCD6")]
        public int? HinmeiCD6 { get; set; }

        [Column("HinmeiName6")]
        public string HinmeiName6 { get; set; }

        [Column("HinmeiDate6")]
        public string HinmeiDate6 { get; set; }

        [Column("HinmeiCnt6")]
        public int? HinmeiCnt6 { get; set; }

        [Column("HinmeiCD7")]
        public int? HinmeiCD7 { get; set; }

        [Column("HinmeiName7")]
        public string HinmeiName7 { get; set; }

        [Column("HinmeiDate7")]
        public string HinmeiDate7 { get; set; }

        [Column("HinmeiCnt7")]
        public int? HinmeiCnt7 { get; set; }

        [Column("HinmeiCD8")]
        public int? HinmeiCD8 { get; set; }

        [Column("HinmeiName8")]
        public string HinmeiName8 { get; set; }

        [Column("HinmeiDate8")]
        public string HinmeiDate8 { get; set; }

        [Column("HinmeiCnt8")]
        public int? HinmeiCnt8 { get; set; }

        [Column("HinmeiCD9")]
        public int? HinmeiCD9 { get; set; }

        [Column("HinmeiName9")]
        public string HinmeiName9 { get; set; }

        [Column("HinmeiDate9")]
        public string HinmeiDate9 { get; set; }

        [Column("HinmeiCnt9")]
        public int? HinmeiCnt9 { get; set; }

        [Column("Memo")]
        public string Memo { get; set; }

        [Column("MgNo")]
        public string MgNo { get; set; }
    }
}
