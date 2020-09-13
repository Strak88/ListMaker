using System;
using System.Collections.Generic;
using System.Text;

namespace ListMakerBackEnd
{
    public class ListObject<T> : List<T>
    {
        string name { get; set; }

        List<ListRule> listRules { get; set; }
    }
}
