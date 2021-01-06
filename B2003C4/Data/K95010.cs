using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//本番環境ではcolumn項のイニシャルが大文字


namespace B2003C4.Data
{
    [Table("Iri_K95010", Schema = "dbo")]
    public class Iri
    {
        [Column("Tenpo")]
        public int Tenpo { get; set; }

        [Column("kuiki")]
        public int Kuiki { get; set; }

        //[Column("Nengetu")]
        [Column("nengetu")]
        public int Nengetu { get; set; }

        //Junro
        [Column("junro")]
        public string Junro { get; set; }

        //DokuCode
        [Key]
        [Column("dokuCode")]
        public int DokuCode { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("tel")]
        public string Tel { get; set; }

        [Column("meig")]
        public string Meig { get; set; }

        [Column("iri")]
        public string iri { get; set; }

        [Column("tome")]
        public string Tome { get; set; }

        [Column("tantokbn")]
        public int Tantokbn { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("build")]
        public string Build { get; set; }

        [Column("MgCode")]
        public int MgCode { get; set; }

        [Column("MgNo")]
        public string MgNo { get; set; }

        [Column("IriRiyuu")]
        public string IriRiyuu { get; set; }

        [Column("KeizokuTuki")]
        public int KeizokuTsuki { get; set; }

        [Column("DispNengetu")]
        public string DispNengetu { get; set; }

        [Column("NextKeiyaku")]
        public int NextKeiyaku { get; set; }

        [Column("GaitoNo")]
        public int GaitoNo { get; set; }

    }

    [Table("Tome_K95010", Schema = "dbo")]
    public class Tome
    {
        [Column("Tenpo")]
        public int Tenpo { get; set; }

        [Column("kuiki")]
        public int Kuiki { get; set; }

        //[Column("Nengetu")]
        [Column("nengetu")]
        public int Nengetu { get; set; }

        //Junro
        [Column("junro")]
        public string Junro { get; set; }

        //DokuCode
        [Key]
        [Column("dokuCode")]
        public int DokuCode { get; set; }

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
        public int Tantokbn { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("build")]
        public string Build { get; set; }

        [Column("MgCode")]
        public int MgCode { get; set; }

        [Column("MgNo")]
        public string MgNo { get; set; }

        [Column("IriRiyuu")]
        public string IriRiyuu { get; set; }

        [Column("KeizokuTuki")]
        public int KeizokuTsuki { get; set; }

        [Column("DispNengetu")]
        public string DispNengetu { get; set; }

        [Column("NextKeiyaku")]
        public int NextKeiyaku { get; set; }

        [Column("GaitoNo")]
        public int GaitoNo { get; set; }

    }

    [Table("Dokusya_K95010", Schema = "dbo")]
    public class Dokusya
    {
        [Column("kuiki")]
        public int Kuiki { get; set; }

        [Column("junro")]
        public string Junro { get; set; }

        [Key]
        [Column("dokuCode")]
        public int DokuCode { get; set; }



    }

    [Table("Kuiki_K95010", Schema = "dbo")]
    public class Kuiki_K95010
    {
        [Column("Tenpo")]
        public int Tenpo { get; set; }

        [Key]
        [Column("kuiki")]
        public int Kuiki { get; set; }

        [Column("Name")]
        public string Name { get; set; }
    }

    [Table("Nengetu_K95010", Schema = "dbo")]
    public class Nengetu_K95010
    {
        [Column("Tenpo")]
        public int Tenpo { get; set; }

        [Key]
        [Column("No")]
        public int No { get; set; }

        [Column("Nengetu")]
        public int Nengetu { get; set; }

        [Column("Name")]
        public string Name { get; set; }
    }
}
