using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RitoAPI.Models
{
    public class Champion
    {
        public String id;
        public String title;
        public Dictionary<string, Champion> Data { get; set; }
        public Champion(string id, string title)
        {
            this.id = id;
            this.title = title;
        }

    }
}
