using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListMakerBackEnd
{
    class MovieList : ListObject<Movie>
    {
        public string name { get; set; }
        public List<ListRule> listRules { get; set; }
    }
}
