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
        public String lore;
        public String pIcon;
        public String qIcon;
        public String wIcon;
        public String eIcon;
        public String rIcon;

        public Dictionary<string, Champion> Data { get; set; }
        public Champion()
        {
           
        }

    }
}
