using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B2003C4.Shared
{

    public class Dokusya
    {
        [Required]
        public int kuiki { get; set; }

        [Required]
        public string junro { get; set; }

        [Key]
        [Required]
        public int dokuCode { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string tel { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public string addressRyaku { get; set; }

        [Required]
        public string banti { get; set; }

        [Required]
        public string build { get; set; }

        [Required]
        public string misebi1 { get; set; }

        [Required]
        public string misebi2 { get; set; }

        [Required]
        public string misebi3 { get; set; }

        [Required]
        public string junrobi1 { get; set; }

        [Required]
        public string junrobi2 { get; set; }

        [Required]
        public string junrobi3 { get; set; }

        [Required]
        public string syumemo1 { get; set; }

        [Required]
        public string syumemo2 { get; set; }

        [Required]
        public string syumemo3 { get; set; }

        [Required]
        public string bunrui { get; set; }

        [Required]
        public string rank { get; set; }

        [Required]
        public string kaiin { get; set; }

        [Required]
        public string syoken { get; set; }

        [Required]
        public string siharai { get; set; }

        [Required]
        public string dokumemo { get; set; }

        [Required]
        public int zx { get; set; }

        [Required]
        public int zy { get; set; }

        [Required]
        public int x { get; set; }

        [Required]
        public int y { get; set; }

        [Required]
        public int zu_bekki { get; set; }

        /*
        public List<Dokusya> DokusyaList { get; set; }
        */


    }
}
