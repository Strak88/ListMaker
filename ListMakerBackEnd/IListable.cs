using System;
using System.Collections.Generic;
using System.Text;

namespace ListMakerBackEnd
{
    interface IListable
    {
        public Dictionary<string, string> properties { get; set; }
    }
}
