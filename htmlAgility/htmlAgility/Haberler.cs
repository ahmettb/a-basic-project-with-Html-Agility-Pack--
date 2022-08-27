using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htmlAgility
{
     class Haberler
    {
        public string baslik { get; set; }
        public string link { get; set; }
        public override string ToString()
        {
            return baslik + "---" + link;
        }

    }
}
