using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2003C4.Data
{
    public class History
    {
        public static List<FormSearchDataModel> Next_History { get; set; } = new List<FormSearchDataModel>();

        public static List<FormSearchDataModel> Back_History { get; set; } = new List<FormSearchDataModel>();
    }
}
