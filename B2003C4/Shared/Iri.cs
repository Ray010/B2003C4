using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B2003C4.Shared
{
    [Table("Iri")]
    public class Iri
    {
        public double? kuiki{ get; set; }
        public double? nengetu{ get; set; }
        public string junro { get; set; }
        [Key]
        public double? dokuCode{ get; set; }
        public string name{ get; set; }
        public string tel{ get; set; }
        public string meig{ get; set; }
        public string iri{ get; set; }
        public string tome{ get; set; }
        public double? tantokbn{ get; set; }
        public string address{ get; set; }
        public string build{ get; set; }
        public double? MgCode{ get; set; }
        public string MgNo{ get; set; }
        public string IriRiyuu{ get; set; }
        public double? KeizokuTuki{ get; set; }
        public string DispNengetu{ get; set; }
        public double? NextKeiyaku{ get; set; }
        public double? GaitoNo{ get; set; }

    }
}
