using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B2003C4.Data;
using Microsoft.AspNetCore.Components;

namespace B2003C4.Class
{
    public class BackHistory
    {
        public BackHistory(FormSearchDataModel formList , EventCallback<FormSearchDataModel> formListChanged)
        {
            /*
            formList.Back_History.Add(formList.Deep_Copy());
            if(formList.Back_History.Count == 10)
            {
                formList.Back_History.RemoveRange(0, 5);
            }
            formListChanged.InvokeAsync(formList);
            */
        }
    }
}
