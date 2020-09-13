using System;
using System.Collections.Generic;
using System.Text;

namespace ListMakerBackEnd
{
    public enum movieProperties
    {
        name,
        releaseDate
    }

    public class Movie : IListable
    {
        public Dictionary<string, string> properties { get; set; }

        public Movie(string name, DateTime releaseDate)
        {
            properties.Add("name", name);
            properties.Add("releaseDate", releaseDate.ToString());
        }
    }
}
