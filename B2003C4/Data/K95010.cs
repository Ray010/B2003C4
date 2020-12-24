using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//本番環境ではcolumn項のイニシャルが大文字


namespace B2003C4.Data
{
    [Table("Iri", Schema = "dbo")]
    public class Iri
    {
        [Column("kuiki")]
        public double Kuiki { get; set; }

        //[Column("Nengetu")]
        [Column("nengetu")]
        public double Nengetu { get; set; }

        //Junro
        [Column("junro")]
        public string Junro { get; set; }

        //DokuCode
        [Key]
        [Column("dokuCode")]
        public double DokuCode { get; set; }

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
        public double Tantokbn { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("build")]
        public string Build { get; set; }

        [Column("MgCode")]
        public double MgCode { get; set; }

        [Column("MgNo")]
        public string MgNo { get; set; }

        [Column("IriRiyuu")]
        public string IriRiyuu { get; set; }

        [Column("KeizokuTuki")]
        public double KeizokuTsuki { get; set; }

        [Column("DispNengetu")]
        public string DispNengetu { get; set; }

        [Column("NextKeiyaku")]
        public double NextKeiyaku { get; set; }

        [Column("GaitoNo")]
        public double GaitoNo { get; set; }

    }

    [Table("Tome", Schema = "dbo")]
    public class Tome
    {
        [Column("kuiki")]
        public double Kuiki { get; set; }

        //[Column("Nengetu")]
        [Column("nengetu")]
        public double Nengetu { get; set; }

        //Junro
        [Column("junro")]
        public string Junro { get; set; }

        //DokuCode
        [Key]
        [Column("dokuCode")]
        public double DokuCode { get; set; }

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
        public double Tantokbn { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("build")]
        public string Build { get; set; }

        [Column("MgCode")]
        public double MgCode { get; set; }

        [Column("MgNo")]
        public string MgNo { get; set; }

        [Column("IriRiyuu")]
        public string IriRiyuu { get; set; }

        [Column("KeizokuTuki")]
        public double KeizokuTsuki { get; set; }

        [Column("DispNengetu")]
        public string DispNengetu { get; set; }

        [Column("NextKeiyaku")]
        public double NextKeiyaku { get; set; }

        [Column("GaitoNo")]
        public double GaitoNo { get; set; }

    }

    [Table("Dokusya", Schema = "dbo")]
    public class Dokusya
    {
        [Column("kuiki")]
        public double Kuiki { get; set; }

        [Column("junro")]
        public string Junro { get; set; }

        [Key]
        [Column("dokuCode")]
        public double DokuCode { get; set; }



    }
}
