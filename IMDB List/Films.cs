using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_List
{
    public class Films
    {
        public string Name { get; set; }
        public double ImdbPuan { get; set; }

        public Films(string name, double imdbPuan)
        {
            Name = name;
            ImdbPuan = imdbPuan; 
        }


    }
}
