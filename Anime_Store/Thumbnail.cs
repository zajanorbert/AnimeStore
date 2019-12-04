using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Store
{
    class Thumbnail
    {

        public string imgURL { get; set; }
        public string label { get; set; }

        public Thumbnail(string url, string label)
        {
            imgURL = url;
            this.label = label;
        }
    }
}
