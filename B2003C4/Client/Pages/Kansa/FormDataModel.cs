using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace B2003C4.Client.Pages.Kansa
{
    public class FormDataModel
    {
        [DataType(DataType.PhoneNumber)]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        public uint? DokuCode { get; set; } = null;


    }
}
